using AspNetCoreTest.DataAcces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AspNetCoreTest.Acces.Tests
{
    [TestClass]
    public class PersonRepositoryTests
    {
        [TestMethod]
        public async Task AddNewPerson_ReturnsOk()
        {
            var repository = new PersonRepository();

            var person = new Person()
            {
                Name = "janis",
                Surname = "anga",
                Address = new Address{ Country = "lv", City = "riga", Street = "briv iela" },
                Age = 14,
                Email = "no",
                IsMale = false
            };

            await repository.AddAsync(person);
        }

        [TestMethod]
        public void GetPerson_ReturnsPerson()
        {
            var repository = new PersonRepository();
            var result = repository.GetByName("janis");
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void GetPerson_ReturnsNoPerson()
        {
            var repository = new PersonRepository();
            var result = repository.GetByName("jaanis");
            Assert.AreEqual(0, result.Count);
        }
    }
}
;