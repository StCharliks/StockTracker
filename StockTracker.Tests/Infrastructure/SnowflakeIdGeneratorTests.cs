using DolbojebInvest.Infrastructure.IdGeneration;

namespace DolbojebInvest.Tests.Infrastructure
{
    public class SnowflakeIdGeneratorTests
    {
        private readonly SnowflakeIdGenerator _sut = new SnowflakeIdGenerator(1);

        [Fact]
        public async Task GenerateIdAsync_ShouldGenerateUniqueIds()
        {
            // Arrange
            var generatedIds = new HashSet<long>();
            var tasks = new List<Task<long>>();

            // Act
            for (int i = 0; i < 5000; i++)
            {
                tasks.Add(_sut.GenerateIdAsync());
            }
            var ids = await Task.WhenAll(tasks);

            // Assert
            foreach (var id in ids)
            {
                Assert.True(generatedIds.Add(id), $"Duplicate ID generated: {id}");
            }
        }
    }
}
