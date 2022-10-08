using API_Interactive_Lab_1.Controllers;
using NUnit.Framework;
using WebAPIforDrinks.Models;

namespace API_Interactive_Lab_1.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetCoffee()
        {

            string expectedContent = "I like coffee!";
        
            var controller = new CoffeeController();
            var result = controller.Get();
            Assert.AreEqual(expectedContent, result);
        }

        [Test]
        public void TestDefault()
        {
            Coffee expected = new Coffee(-1, "latte");
            var controller = new CoffeeController();
            var result = controller.Get(null);
            Assert.AreEqual(expected.Id, result.Id);
            Assert.AreEqual(expected.Name, result.Name);
        }

        [Test]
        public void TestCappuccino()
        {
            Coffee expected = new Coffee(2, "cappuccino");
            var controller = new CoffeeController();
            var result = controller.Get("cappuccino");
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}