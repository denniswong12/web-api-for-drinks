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
    }
}