using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class LongGenerator : IGenerator
    {
        public Type GeneratorType => typeof(long);

        public object GetRandomValue()
        {
            Random random = new Random();
            long result = random.Next(int.MinValue, int.MaxValue);
            result = result << 32;
            result |= (long)random.Next(int.MinValue, int.MaxValue) & int.MaxValue;
            return result;
        }
    }
}
