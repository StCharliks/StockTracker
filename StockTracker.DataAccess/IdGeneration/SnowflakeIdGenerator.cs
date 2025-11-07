using DolbojebInvest.Domain.Base;

namespace DolbojebInvest.Infrastructure.IdGeneration
{
    public class SnowflakeIdGenerator : IIdGenerator<long>
    {
        private long? lastEpoch = null;
        private long sequence = 0L;

        private readonly long _machineId;
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

        public SnowflakeIdGenerator(ushort machineId)
        {
            _machineId = (long)(machineId & 0x3ff);
        }

        public async Task<long> GenerateIdAsync()
        {
            await _semaphoreSlim.WaitAsync();

            try
            {
                var timestamp = GetCurrentTimestamp();

                if (timestamp == lastEpoch)
                {
                    sequence = (sequence + 1) & 0xfff;
                    if (sequence == 0)
                    {
                        do
                        {
                            timestamp = GetCurrentTimestamp();
                        } while (timestamp <= lastEpoch);
                    }
                }
                else
                {
                    sequence = 0;
                }

                lastEpoch = timestamp;
                return (timestamp << 22) | (_machineId << 12) | sequence;
            }
            finally
            {
               _semaphoreSlim.Release();
            }
        }

        private long GetCurrentTimestamp()
        {
            return (long)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }
    }
}
