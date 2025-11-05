using DolbojebInvest.Infrastructure.IdGeneration;

namespace StockTracker.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var generator = new SnowflakeIdGenerator(1);

            var id1 = await generator.GenerateIdAsync();
        }
    }
}