namespace WebApiCoreWithEF.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using CourseApi.Models;
    

    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private AppDbContext _countryContext;

        public CountryController(AppDbContext countryContext)
        {
            _countryContext = countryContext;
        }

        // GET: api/<CountryController>
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryContext.CountryItem;
        }

        // GET api/<CountryController>/5
        [HttpGet("{id}")]
        public Country Get(int id)
        {
            return _countryContext.CountryItem.FirstOrDefault(s => s.CountryId == id);
        }

        // POST api/<CountryController>
        [HttpPost]
        public void Post([FromBody] Country value)
        {
            _countryContext.CountryItem.Add(value);
            _countryContext.SaveChanges();
        }

        // PUT api/<CountryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Country value)
        {
            var Country = _countryContext.CountryItem.FirstOrDefault(s => s.CountryId == id);
            if (Country != null)
            {
                _countryContext.Entry<Country>(Country).CurrentValues.SetValues(value);
                _countryContext.SaveChanges();
            }
        }

        // DELETE api/<CountryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var student = _countryContext.CountryItem.FirstOrDefault(s => s.CountryId == id);
            if (student != null)
            {
                _countryContext.CountryItem.Remove(student);
                _countryContext.SaveChanges();
            }
        }
    }
}