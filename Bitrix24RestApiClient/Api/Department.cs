using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using BXRest.Core.Models;
using BXRest.Models.Tasks.Task;
using System.Threading.Tasks;
using BXRest.Models.Department;
using System.Collections.Generic;

namespace BXRest.Api
{
    /// Набор api методов для подразделений
    public class Department
    {
        private IBitrix24Client client;

        /// Конструктор
        public Department(IBitrix24Client client)
        {
            this.client = client;
        }

        /// Получение фильтрованного списка подразделений
        public async Task<iBXRespnse<List<iGetItem>>> Get(iGetParam param)
        {
            return await client.SendPostRequest<iGetParam, iBXRespnse<List<iGetItem>>>(RestMedots.Department.Get, param);
        }

    }
}
