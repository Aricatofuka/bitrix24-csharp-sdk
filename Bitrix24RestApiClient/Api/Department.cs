using BXRest.Core.Client;
using BXRest.Core.Models.Response;
using BXRest.Core.Models;
using System.Threading.Tasks;
using BXRest.Models.Department;
using System.Collections.Generic;

namespace BXRest.Api
{
    /// Набор api методов для подразделений
    /// Конструктор
    public class Department(IBitrix24Client client)
    {
        /// Получение фильтрованного списка подразделений
        public async Task<iBXRespnse<List<iGetItem>>> Get(iGetParam param)
        {
            return await client.SendPostRequest<iGetParam, iBXRespnse<List<iGetItem>>>(RestMedots.Department.Get, param);
        }

    }
}
