using BXRest.Core.Client;
using BXRest.Core.Models;
using BXRest.Core.Models.Response;
using BXRest.Models.SonetGroup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BXRest.Api
{
    /// Подкласс по работе с битриксовыми рабочими группами
    public class SonetGroup(IBitrix24Client client)
    {
        private readonly IBitrix24Client client = client;

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
