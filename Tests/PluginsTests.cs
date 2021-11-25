using NUnit.Framework;
using Faker;
using Faker.Generators;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class PluginsTests
    {

        private PluginLoader pluginLoader;
        private Dictionary<Type, IGenerator> externalGenerators;

        [OneTimeSetUp]
        public void Setup()
        {
            externalGenerators = new Dictionary<Type, IGenerator>();
            pluginLoader = new PluginLoader(externalGenerators);
            pluginLoader.LoadPluginGenerators();
        }

        [Test]
        public void CorrectPluginsCountTest()
        {
            int expected = 2;
            int actual = externalGenerators.Count;
            Assert.AreEqual(expected, actual, "Incorrect count of generators");
        }

        [Test]
        public void UIntGeneratorTest()
        {
            var faker = new Faker.Faker();
            var value = faker.Create<uint>();
            Type expected = typeof(uint);
            Type actual = value.GetType();
            Assert.AreEqual(expected, actual, "Generated value type doesn't match expected type");
        }

        [Test]
        public void ULongGeneratorTest()
        {
            var faker = new Faker.Faker();
            var value = faker.Create<ulong>();
            Type expected = typeof(ulong);
            Type actual = value.GetType();
            Assert.AreEqual(expected, actual, "Generated value type doesn't match expected type");
        }
    }
}