using DolbojebInvest.Domain.Base;

namespace DolbojebInvest.Infrastructure.IdGeneration
{
    public class SnowflakeIdGenerator : IIdGenerator<ulong>
    {
        private ulong? lastEpoch = null;
        private ulong sequence = 0L;

        private readonly ulong _machineId;
        private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);

        public SnowflakeIdGenerator(ushort machineId)
        {
            _machineId = (ulong)(machineId & 0x3ff);
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

                return (timestamp << 22) | (_machineId << 12) | sequence;
            }
            finally
            {
               _semaphoreSlim.Release();
            }
        }

        private ulong GetCurrentTimestamp()
        {
            return (ulong)DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
        }
    }
}
