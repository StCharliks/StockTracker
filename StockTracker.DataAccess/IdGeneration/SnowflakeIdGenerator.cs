using DolbojebInvest.Domain.Base;

namespace DolbojebInvest.Infrastructure.IdGeneration
{
    public class SnowflakeIdGenerator : IIdGenerator<long>
    {
        private readonly byte _machineId;
   
        public SnowflakeIdGenerator(byte machineId)
        {
            _machineId = machineId;
        }

        public long GenerateId()
        {
            throw new NotImplementedException();
        }

        public Task<long> GenerateIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
