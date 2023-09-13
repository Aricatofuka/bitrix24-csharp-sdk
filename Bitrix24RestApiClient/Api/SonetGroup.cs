using BXRest.Core.Client;
using BXRest.Core.Models;
using BXRest.Core.Models.Response;
using BXRest.Models.SonetGroup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BXRest.Api
{
    /// <summary>
    /// Подкласс по работе с битриксовыми рабочими группами
    /// </summary>
    public class SonetGroup
    {
        private IBitrix24Client client;
        public TaskMetodts.ElapsedItem ElapsedItem { get; set; }
        public SonetGroup(IBitrix24Client client)
        {
            this.client = client;
            ElapsedItem = new TaskMetodts.ElapsedItem(client);
        }

        /// <summary>
        /// Получить группу
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<iGetRespnse<List<iGroup>>> Get(iGet param)
        {
            return await client.SendPostRequest<iGet, iGetRespnse<List<iGroup>>>(RestMedots.SonetGroup.Get, param);
        }

    }
}
