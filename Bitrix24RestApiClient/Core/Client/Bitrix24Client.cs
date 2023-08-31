using System;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;
using System.Diagnostics.CodeAnalysis;

namespace BXRest.Core.Client
{
    public class Bitrix24Client: IBitrix24Client
    {
        private string webhookUrl;
        private ILogger logger;

        public Bitrix24Client(string webhookUrl, ILogger logger)
        {
            this.webhookUrl = webhookUrl;
            this.logger = logger;
        }

        public async Task<TResponse> SendPostRequest<TArgs,TResponse>(string metod, TArgs args) where TResponse : class
        {
            string responseBodyStr = null;

            try
            {

                IFlurlResponse response = await webhookUrl
                       .AppendPathSegment(metod)
                       .PostJsonAsync(args);


                TResponse responseBody = await response.GetJsonAsync<TResponse>();
                return responseBody;
            }
            catch(FlurlHttpException ex)
            {
                try
                {
                    responseBodyStr = Regex.Unescape(await ex.Call.Response.GetStringAsync());
                    logger.LogError($"Bitrix24 API request\r\n\tMethod: {metod}\r\n\tArgs: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n\t Flurl: {ex.Message} {ex.ToString()}\r\n\t");
                    throw new Exception(responseBodyStr);
                }
                catch 
                {
                    logger.LogError($"Bitrix24 API request\r\n\tMethod: {metod}\r\n\tArgs: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n");
                    throw;
                }
            }
        }
    }
}
