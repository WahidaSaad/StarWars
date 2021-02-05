using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeleQuebecStarWars.Controllers;
using TeleQuebecStarWars.Models;

namespace UnitTestProjectStarWars
{
    [TestClass]
    public class UnitTestPersonnage
    {
        [TestMethod]
        [Timeout(TestTimeout.Infinite)]
        public async Task GetPersonnages()
        {          

            // Arrange
            var mockRepository = new Mock<IRepository>();

            var controller = new StarWarsController(mockRepository.Object);

            // Act
            var personnageEnum = controller.Get().GetEnumerator();
            TestObject(personnageEnum.Current);

        }

        private void TestObject(PersonnageModel personnage)
        {
            Assert.AreEqual(personnage.name, "Luke Skywalker");
            Assert.AreEqual(personnage.height, "172");
            Assert.AreEqual(personnage.mass, "77");
            Assert.AreEqual(personnage.hair_color, "blond");

            Assert.AreEqual(personnage.skin_color, "fair");
            Assert.AreEqual(personnage.eye_color, "blue");
            Assert.AreEqual(personnage.birth_year, "19BBY");
            Assert.AreEqual(personnage.gender, "male");

            Assert.AreEqual(personnage.homeworld, "http://swapi.co/api/planets/1/");

            Assert.AreEqual(personnage.films, new string[] {
                       "http://swapi.co/api/films/1/",
                       "http://swapi.co/api/films/2/",
                       "http://swapi.co/api/films/3/",
                       "http://swapi.co/api/films/6/",
                       "https://swapi.co/api/films/7/"
                });

            Assert.AreEqual(personnage.species, new string[]{
                "http://swapi.co/api/species/1/"
            });

            Assert.AreEqual(personnage.vehicles, new string[]{
                "http://swapi.co/api/vehicles/14/",
                "http://swapi.co/api/vehicles/30/"
            });

            Assert.AreEqual(personnage.starships, new string[]{
                 "http://swapi.co/api/starships/12/",
                 "http://swapi.co/api/starships/22/"
            });

            Assert.AreEqual(personnage.created, "2014-12-09T13:50:51.644000Z");
            Assert.AreEqual(personnage.edited, "2014-12-20T21:17:56.891000Z");
            Assert.AreEqual(personnage.url, "https://swapi.co/api/people/1/");
        }
    }
}
