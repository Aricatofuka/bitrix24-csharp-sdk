using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using BXRest.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using BXRest.Models.Task.Item;
using BXRest.Models.Task.Item.Userfield;

namespace BXRest.Api.TaskMethods.ItemMethods
{
    /// <summary>
    /// Класс для работы с пользовательскими полями задач из битрикса
    /// </summary>
    /// <param name="client"></param>
    public class UserField(IBitrix24Client client)
    {
        /// <summary>
        /// Получение списка записей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<List<iUserfield>>> GetList(iGetList param)
        {
            return await client.SendPostRequest<iGetList, iBXRespnse<List<iUserfield>>>(RestMedots.Task.Item.Userfield.GetList, param);
        }


        /// <summary>
        /// Получение списка записей о треках в задачу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iBXRespnse<iUserfieldWhenGetOne>> Get(iGet param)
        {
            return await client.SendPostRequest<iGet, iBXRespnse<iUserfieldWhenGetOne>>(RestMedots.Task.Item.Userfield.Get, param);
        }

    }
}
