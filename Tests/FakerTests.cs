using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Faker;

namespace Tests
{
    public class FakerTests
    {
        [Test]
        public void ConstructedObjectNotNull()
        {
            var faker = new Faker.Faker();
            var user = faker.Create<User>();
            Assert.NotNull(user);
        }

        [Test]
        public void ConstructorDoesntThrowsExceptionTest()
        {
            var faker = new Faker.Faker();
            Assert.DoesNotThrow(() => faker.Create<User>());
        }

        [Test]
        public void PrivateConstructorGeneratesTest()
        {
            var faker = new Faker.Faker();
            var user = faker.Create<User>();
            bool hasNull = false;
            foreach(Dog dog in user.dogs)
            {
                if (dog == null)
                {
                    hasNull = true;
                    break;
                }
            }
            Assert.IsFalse(hasNull);
        }
    }
}
