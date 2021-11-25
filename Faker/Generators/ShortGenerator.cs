using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class ShortGenerator : IGenerator
    {
        public Type GeneratorType => typeof(short);

        public object GetRandomValue()
        {
            return (short)(new Random().Next(short.MinValue, short.MaxValue));
        }
    }
}
