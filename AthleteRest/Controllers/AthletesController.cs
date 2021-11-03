using AtheleteLibrary;
using AthleteRest.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AthleteRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AthletesController : ControllerBase
    {
        private readonly AthletesManager _manager = new AthletesManager();

        //GET: api/<AthletesController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]
        public ActionResult<IEnumerable<Athlete>> Get([FromQuery] string contains, [FromQuery] string sort_by)
        {
            IEnumerable<Athlete> athlete = _manager.GetAll(contains, sort_by);
            if (athlete.Count() == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(athlete);
            }

        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{country}")]
        public List<Athlete> GetByCountry(string country)
        {
                return _manager.GetByCountry(country);
        }


        //[Microsoft.AspNetCore.Mvc.HttpGet("{country}")]
        //public Athlete GetByCountry(string country)
        //{
        //    return _manager.GetByCountry(country);
        //}


        // POST api/<AthletesController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public ActionResult<Athlete> Post([FromBody] Athlete value)
        {
            return Ok(_manager.Add(value));
        }

        // DELETE api/<AthletesController>/5
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public ActionResult<Athlete> Delete(int id)
        {
            Athlete result = _manager.Delete(id);
            if (result == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(result);
            }
                
      
        }
    }
}
