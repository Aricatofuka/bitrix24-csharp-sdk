﻿using BXRest.Api.Models.Tasks.ElapsedItem;
using BXRest.Core.Client;
using BXRest.Core.Models;
using BXRest.Core.Models.Response;
using BXRest.Models.Tasks.ElapsedItem;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BXRest.Api.TaskMethods
{
    /// Набор запросов для работы с записами к задачам
    /// <summary>
    /// init
    /// </summary>
    /// <param name="client"></param>
    public class ElapsedItem(IBitrix24Client client)
    {

        private readonly IBitrix24Client client = client;

        /// <summary>
        /// Получение списка зписей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<List<iElapsedItem>>> GetList(iGetList param)
        {
            return await client.SendPostRequest<iGetList, iBXRespnse<List<iElapsedItem>>>(RestMedots.Task.ElapsedItem.GetList, param);
        }

        /*

        /// <summary>
        /// Получение списка зписей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iGetRespnse<List<iElapsedItem>>> GetListAll(iGetList param)
        {
            var respon = await client.SendPostRequest<iGetList, iGetRespnse<List<iElapsedItem>>>(RestMedots.Task.ElapsedItem.GetList, param);

            if(respon.next != null && respon.next != 0)
            {
                param.PARAMS = new iGetListParam()
                {
                    NAV_PARAMS = new iGetListParamNavParams()
                    {
                        nPageSize = 50,
                        iNumPage = respon.next / 50 + 1
                    }
                };


                var respon2 = await GetListAll(param);

                respon.result.AddRange(respon2.result);

                return respon;
            } 
            else
            {
                return respon;
            }
        }
        */
    }
}
