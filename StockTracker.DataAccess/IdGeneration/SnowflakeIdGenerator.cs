using DolbojebInvest.Domain.Base;

namespace DolbojebInvest.Infrastructure.IdGeneration
{
    public class SnowflakeIdGenerator : IIdGenerator<ulong>
    {
        private readonly short _machineId;
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(0, 1);
        private ulong snowflakeBase = 0L;
   
        public SnowflakeIdGenerator(short machineId)
        {
            _machineId = machineId;
        }

        public ulong GenerateId()
        {
            throw new NotImplementedException();
        }

        public async Task<ulong> GenerateIdAsync()
        {
            await _semaphoreSlim.WaitAsync();

            try
            {

            }
            finally
            {
               _semaphoreSlim.Release();
            }
        }
    }
}
