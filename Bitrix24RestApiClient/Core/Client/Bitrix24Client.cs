using System;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Linq;
using Serilog;

namespace BXRest.Core.Client
{
    /// <summary>
    /// Класс для отправки подготовленных запросов
    /// </summary>
    /// <param name="webhookUrl"></param>
    public class Bitrix24Client(string webhookUrl) : IBitrix24Client
    {
        private readonly string _webhookUrl = webhookUrl;
        private static readonly ILogger _logger = Log.Logger.ForContext<Bitrix24Client>();

        /// <summary>
        /// Основной метод для запросов
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="method"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<TResponse> SendPostRequest<TArgs, TResponse>(string method, TArgs args) where TResponse : class
        {
            try
            {
                TResponse responseBody = await SendPostRequestHttp(method, args)
                      .ReceiveJson<TResponse>(); // PostJsonAsync - будет вносить пустые поля, поэтому его использовать не будет, так как битрикс зачем-то на ни реагирует

                return responseBody;
            }
            catch (FlurlHttpException ex)
            {
                string responseBodyStr = null;
                string file = "unknown";
                int line = 0;

                try
                {
                    var stackTrace = new StackTrace(ex, true);
                    var frame = stackTrace.GetFrames()?.FirstOrDefault(f => !string.IsNullOrEmpty(f.GetFileName()));

                    if (frame != null)
                    {
                        file = frame.GetFileName();
                        line = frame.GetFileLineNumber();
                    }
                }
                catch
                {
                    // Игнорировать ошибки при анализе StackTrace
                }
                try
                {
                    responseBodyStr = Regex.Unescape(await ex.Call.Response.GetStringAsync());
                    _logger.ForContext("CallerFilePath", file)
                        .ForContext("CallerLineNumber", line)
                        .Warning(ex, "{Message}", $"Bitrix24 API request\r\n\tMethod: {method}\r\n\tArgs: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n");
                    throw new Exception(responseBodyStr);
                }
                catch(Exception exx)
                {
                    try
                    {
                        var stackTrace = new StackTrace(exx, true);
                        var frame = stackTrace.GetFrames()?.FirstOrDefault(f => !string.IsNullOrEmpty(f.GetFileName()));

                        if (frame != null)
                        {
                            file = frame.GetFileName();
                            line = frame.GetFileLineNumber();
                        }
                    }
                    catch
                    {
                        // Игнорировать ошибки при анализе StackTrace
                    }

                    _logger.ForContext("CallerFilePath", file)
                      .ForContext("CallerLineNumber", line)
                      .Warning(ex, "{Message}", $"Bitrix24 API request\r\n\tMethod: {method}\r\n\tArgs: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n");
                    throw new Exception(ex.Message + ex.ToString());
                }
            }
        }

        /// <summary>
        /// Основной метод для запросов
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <param name="method"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public Task<IFlurlResponse> SendPostRequestHttp<TArgs>(string method, TArgs args) 
        {
            string serialized = JsonConvert.SerializeObject(args, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            }); // преобразуем строку в json игнорируя ключи с пустыми значениями

            return _webhookUrl
                      .AppendPathSegment(method)
                      .WithHeader("Content-Type", "application/json")
                      .PostStringAsync(serialized);
        }
    }
}
