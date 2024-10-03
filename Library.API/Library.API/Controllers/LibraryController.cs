using Library.Application.Commands;
using Library.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LibraryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/library
        [HttpPost]
        public async Task<IActionResult> Post(CreateBookCommand command)
        {
            var result = await _mediator.Send(command);

            if(!result.IsSuccess)
                return BadRequest(result.Message);

            return CreatedAtAction(nameof(GetById), new { id = result.Data }, result);
        }

        // GET api/library
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllBooksQuery());

            if (!result.IsSuccess)
                return NotFound(result.Message);

            return Ok(result);
        }

        // GET api/library/1234
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return null;
        }

        // PUT api/library
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id)
        {
            return null;
        }
        // DELETE api/library/1234
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return null;
        }

    }
}
