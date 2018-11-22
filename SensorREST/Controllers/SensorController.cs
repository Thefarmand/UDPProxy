using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

namespace SensorREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private static List<SensorData> sList = new List<SensorData>();

        // GET: api/Sensor
        [HttpGet]
        public List<SensorData> Get()
        {
            return sList;
        }

        // GET: api/Sensor/5
        [HttpGet("{id}", Name = "Get")]
        public SensorData Get(int id)
        {
            return sList[id];
        }

        // POST: api/Sensor
        [HttpPost]
        public void Post([FromBody] SensorData sData)
        {
            sList.Add(sData);
        }

    }
}
