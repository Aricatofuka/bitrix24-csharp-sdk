using BXRest.Api.Models.Tasks.ElapsedItem;
using BXRest.Core.Client;
using BXRest.Core.Models.Enums;
using BXRest.Core.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BXRest.Api.TaskMetodts
{
    public class ElapsedItem
    {

        private IBitrix24Client client;

        public ElapsedItem(IBitrix24Client client)
        {
            this.client = client;
        }

        public async Task<GetResponse<List<iElapsedItem>>> GetList(iGetList param)
        {
            return await client.SendPostRequest<iGetList, GetResponse<List<iElapsedItem>>>(RestMedots.Task.ElapsedItem.GetList, param);
        }
    }
}
