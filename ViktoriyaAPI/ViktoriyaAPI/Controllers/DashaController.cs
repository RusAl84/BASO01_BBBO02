using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViktoriyaAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DashaController : ControllerBase
  {
    // GET: api/<DashaController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Костя поехал ", " в КАБУЛ" };
    }

    // GET api/<DashaController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Ваня съел " + id.ToString() + " ЁЖИКОВ";
    }

    // POST api/<DashaController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DashaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DashaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
