using HozottAsp.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HozottAsp.Controllers
{
    [Route("api/nyersanyagok")]
    [ApiController]
    public class NyersanyagController : ControllerBase
    {
        // GET: api/<NyersanyagController>
        [HttpGet]
        public IActionResult Get()
        {
            ReceptContext context = new ReceptContext();
            return Ok(context.Nyersanyagok.ToList());
        }

        // GET api/<NyersanyagController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ReceptContext context = new ReceptContext();
            var keresettNya = (from x in context.Nyersanyagok
                                where x.NyersanyagId == id
                                select x).FirstOrDefault();
            return Ok(keresettNya);
        }

        // POST api/<NyersanyagController>
        [HttpPost]
        public void Post([FromBody] Nyersanyagok ujNya)
        {
            ReceptContext context = new ReceptContext();
            context.Nyersanyagok.Add(ujNya);
            context.SaveChanges();
        }



    }
}
