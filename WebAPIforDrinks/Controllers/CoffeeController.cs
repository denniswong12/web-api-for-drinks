using Microsoft.AspNetCore.Mvc;
using WebAPIforDrinks.Models;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("lover")]
        public String Get()
        {
            return "I like coffee!";
        }

        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            int id = 0;
            string coffeeName = name;
            if (name == "cappuccino")
            {
                id = 2;
                coffeeName = name;
            }
            else if (name == null)
            {
                    id = -1;
                    coffeeName = "latte";
            }

            return new Coffee(id, coffeeName);
        }
    }
}