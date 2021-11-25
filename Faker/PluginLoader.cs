using Faker.Generators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class PluginLoader
    {
        private static readonly List<string> PluginPaths = new List<string>
        {
            "C:/Users/vanya/source/repos/Faker/FloatGenerator/bin/Debug/net5.0/ULongGeneratorPlugin.dll",
            "C:/Users/vanya/source/repos/Faker/UIntGeneratorPlugin/bin/Debug/net5.0/UIntGeneratorPlugin.dll"
        }; 
        private Dictionary<Type, IGenerator> generators;

        public PluginLoader(Dictionary<Type, IGenerator> gen)
        {
            this.generators = gen;
        }

        public void LoadPluginGenerators()
        {
            foreach (string file in PluginPaths)
            {
                if (!File.Exists(file))
                {
                    TextWriter error = Console.Error;
                    error.Write("Failed to load plugin " + file);
                } 
                else
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    LoadPluginGenerator(assembly);
                }
            }
        }

        private void LoadPluginGenerator(Assembly plugin)
        {
            Type generatorType = plugin.GetTypes().FirstOrDefault(type => typeof(IGenerator).IsAssignableFrom(type));

            if (generatorType == null)
                return;

            if (generatorType.FullName == null)
                return;

            if (!generatorType.IsClass)
                return;

            if (plugin.CreateInstance(generatorType.FullName) is IGenerator generatorPlugin)
            {
                this.generators.Add(generatorPlugin.GeneratorType, generatorPlugin);
            }
        }
    }
}
