using Xunit;
using System.Threading.Tasks;
using BXRest.Test.Utilities;

namespace BXRest.Test.Tests.IntegrationTests
{
    public class StageHistoriesTests : AbstractTest
    {
        [Fact]
        public async Task ListDealStagesTest()
        {
            var items = (await bitrix24.Crm.StageHistories.Deals.List()).Result;
        }
    }
}
