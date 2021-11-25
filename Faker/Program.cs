using System;
using Newtonsoft.Json;

namespace Faker
{
    public class Program
    {
        static void Main(string[] args)
        {
            var faker = new Faker();
            User user = faker.Create<User>();
            string userJson = JsonConvert.SerializeObject(user, Formatting.Indented);
            Console.WriteLine(userJson);
        }
    }
}
