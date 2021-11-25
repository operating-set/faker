using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class StringGenerator : IGenerator
    {
        public Type GeneratorType => typeof(string);
        private const int MaxStringLength = 16;

        public object GetRandomValue()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            CharGenerator chr = new CharGenerator();
            for (int i = 0; i < MaxStringLength; i++)
            {
                builder.Append(chr.GetRandomValue());
            }
            return builder.ToString();
        }
    }
}
