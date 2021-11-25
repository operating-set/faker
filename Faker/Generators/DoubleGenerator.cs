using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Generators
{
    public class DoubleGenerator : IGenerator
    {
        public Type GeneratorType => typeof(Double);

        public object GetRandomValue()
        {
            return new Random().NextDouble();
        }
    }
}
