using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using BXRest.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using BXRest.Models.Task.Item;
using BXRest.Models.Task.Item.Userfield;

namespace BXRest.Api.TaskMetodts.ItemMetodts
{
    /// <summary>
    /// Класс для работы с пользоватльскими полями задач из битрикса
    /// </summary>
    public class Userfield
    {
        private IBitrix24Client client;

        /// <summary>
        /// init
        /// </summary>
        /// <param name="client"></param>
        public Userfield(IBitrix24Client client)
        {
            this.client = client;
        }

        /// <summary>
        /// Получение списка зписей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iGetRespnse<List<iUserfield>>> GetList(iGetList param)
        {
            return await client.SendPostRequest<iGetList, iGetRespnse<List<iUserfield>>>(RestMedots.Task.Item.Userfield.GetList, param);
        }


        /// <summary>
        /// Получение списка зписей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iGetRespnse<iUserfieldWhenGetOne>> Get(iGet param)
        {
            return await client.SendPostRequest<iGet, iGetRespnse<iUserfieldWhenGetOne>>(RestMedots.Task.Item.Userfield.Get, param);
        }

    }
}
