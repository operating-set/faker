using System;
using Faker.Generators;

namespace ULongGeneratorPlugin
{
    public class ULongGenerator : IGenerator
    {

        public Type GeneratorType => typeof(ulong);

        public object GetRandomValue()
        {
            return (ulong) (new Random().Next());
        }
    }
}
