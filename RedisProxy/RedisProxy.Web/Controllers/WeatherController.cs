using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RedisProxy.Common.Entities;

namespace RedisProxy.Web.Controllers
{
    [Route("weather")]
    public class WeatherController : Controller
    {

        [HttpPost]
        public async Task PostReadingAsync([FromBody] Reading reading)
        {
            
        }
    }
}