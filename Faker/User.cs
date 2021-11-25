using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    public class User
    {
        public string name;
        public int age { get; set; }
        float money = 10.05f;
        public List<Dog> dogs;
        public Profile profile;

    }

    public class Dog
    {
        public String name;
        public User owner;

        private Dog()
        {

        }


    }

    public class Profile
    {
        public String address;
        public Profile()
        {
        }
        public Profile(string addr)
        {
            address = addr;
            throw new Exception();
        }
    }
}
