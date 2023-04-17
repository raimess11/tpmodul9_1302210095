using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tpmodul9_1302210095
{
    [Route("api/mahasiswa")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {

        static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa("Rahma Sakti Rahardian","1302210095"),
            new Mahasiswa("Alif Taufiqurrahman" ,"1302213011"),
            new Mahasiswa("Deva Angela Felisitas Toding", "1302213111"),
            new Mahasiswa("Iqro Banyuanto", "1302213061"),
            new Mahasiswa("Regy Renanda Rahman","1302213117")
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswas;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataUser;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
