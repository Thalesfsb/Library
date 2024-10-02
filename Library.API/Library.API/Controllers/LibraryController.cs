using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        // POST api/library
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return null;
        }

        // GET api/library
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return null;
        }

        // GET api/library/1234
        [HttpGet("api/library/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return null;
        }

        // PUT api/library
        [HttpPut]
        public async Task<IActionResult> Put(int id)
        {
            return null;
        }
        // DELETE api/library/1234
        [HttpDelete("api/library/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return null;
        }

    }
}
