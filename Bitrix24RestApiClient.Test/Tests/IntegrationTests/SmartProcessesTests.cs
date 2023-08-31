using Xunit;
using System;
using System.Linq;
using System.Threading.Tasks;
using BXRest.Core.Models.Enums;
using BXRest.Api.Crm.CrmDeal.Models;
using BXRest.Test.Utilities;

namespace BXRest.Test.Tests.IntegrationTests
{
    public class SmartProcessesTests : AbstractTest
    {
        [Fact]
        public async Task SmartProcessesListTest()
        {
            var data = await bitrix24.Crm.SmartProcesses
                .ByEntityId(EntityTypeIdEnum.Deal.EntityTypeId)
                .List<Deal>();
        }
    }
}
