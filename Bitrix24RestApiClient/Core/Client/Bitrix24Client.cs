﻿using System;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using System.Text.RegularExpressions;

namespace BXRest.Core.Client
{
    /// <summary>
    /// Класс для отправки подготовленных запросов
    /// </summary>
    public class Bitrix24Client: IBitrix24Client
    {
        private string webhookUrl;
        private ILogger logger;

        /// <summary>
        /// init
        /// </summary>
        /// <param name="webhookUrl"></param>
        /// <param name="logger"></param>
        public Bitrix24Client(string webhookUrl, ILogger logger)
        {
            this.webhookUrl = webhookUrl;
            this.logger = logger;
        }

        /// <summary>
        /// Основной метод для запросов
        /// </summary>
        /// <typeparam name="TArgs"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="metod"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public async Task<TResponse> SendPostRequest<TArgs,TResponse>(string metod, TArgs args) where TResponse : class
        {
            string responseBodyStr = null;

            try
            {
                
                string serialized = JsonConvert.SerializeObject(args, Formatting.None, new JsonSerializerSettings
                {
                    NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                }); // пербразуем сторуку в json игнорируя ключи с пустыми значениями

                TResponse responseBody = await webhookUrl
                      .AppendPathSegment(metod)
                      .WithHeader("Content-Type", "application/json")
                      .PostStringAsync(serialized)
                      .ReceiveJson<TResponse>(); // PostJsonAsync - будет вносить пустые поля, поэтому его использовать не будет, так как битрикс зачемто на ни реагирует

                return responseBody;
            }
            catch(FlurlHttpException ex)
            {
                try
                {
                    responseBodyStr = Regex.Unescape(await ex.Call.Response.GetStringAsync());
                    logger.LogError($"Bitrix24 API request\r\n\tMethod: {metod}\r\n\t  Flurl: {ex.Message} {ex.ToString()}\r\n\t Args: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n\t");
                    throw new Exception(responseBodyStr);
                }
                catch 
                {
                    logger.LogError($"Bitrix24 API request\r\n\tMethod: {metod}\r\n\tArgs: {JsonConvert.SerializeObject(args)}\r\n\tBody: {responseBodyStr}\r\n");
                    throw new Exception(ex.Message + ex.ToString());
                }
            }
        }
    }
}
