using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenMaiChiTrung_5951071112.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<Models.WeatherInfo> Get()
        {
            var WeatherInfList = new List<Models.WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var WeatherInfo = new Models.WeatherInfo
                {
                    Location1 = $"Location {i}",
                    Degree1 = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()
                }; 
                WeatherInfList.Add(WeatherInfo);
            }
            return WeatherInfList;
        }

        // GET: api/Weather/5
        public Models.WeatherInfo Get(int id)
        {
            return new Models.WeatherInfo
            {
                Location1 = $"Location {id}",
                Degree1 = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

        // POST: api/Weather
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Weather/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Weather/5
        public void Delete(int id)
        {
        }
    }
}
