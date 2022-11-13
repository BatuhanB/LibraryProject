using Library.Service.Features.Books.Commands.Create;
using Library.Service.Features.Books.Commands.Delete;
using Library.Service.Features.Books.Commands.Update;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBookCommand command)
        {
            var result = await Mediator!.Send(command);
            return Created("",result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateBookCommand command)
        {
            var result = await Mediator!.Send(command);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteBookCommand command)
        {
            var result = await Mediator!.Send(command);
            return Ok(result);  
        }
    }
}
