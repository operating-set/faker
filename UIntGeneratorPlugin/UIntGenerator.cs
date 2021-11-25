using System;
using Faker.Generators;

namespace UIntGeneratorPlugin
{
    public class UIntGenerator : IGenerator
    {

        public Type GeneratorType => typeof(uint);

        public object GetRandomValue()
        {
            return (uint) (new Random().Next());
        }
    }
}
