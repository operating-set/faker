using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class FloatGenerator : IGenerator
    {
        public Type GeneratorType => typeof(float);

        public object GetRandomValue()
        {
            return (float)(new Random().NextDouble());
        }
    }
}
