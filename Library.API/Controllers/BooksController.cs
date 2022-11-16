using Library.Core.CrossCuttingConcerns.Requests;
using Library.Service.Features.Books.Commands.Create;
using Library.Service.Features.Books.Commands.Delete;
using Library.Service.Features.Books.Commands.Update;
using Library.Service.Features.Books.Queries.GetById;
using Library.Service.Features.Books.Queries.GetList;
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
            return Created("", result);
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

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBookQuery query)
        {
            var result = await Mediator!.Send(query);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest request)
        {
            GetListBookQuery query = new() { PageRequest = request };
            var result = await Mediator!.Send(query);
            return Ok(result);
        }
    }
}
