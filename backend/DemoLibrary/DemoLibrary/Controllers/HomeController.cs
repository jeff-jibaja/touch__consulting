using DemoLibrary.Application.Handlers.Queries.BookController.FindAll;
using DemoLibrary.Application.Handlers.Queries.MasterTableController.FindId;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reec.Inspection;

namespace DemoLibrary.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly IMediator _mediator;

        public HomeController(IMediator mediator) {
            _mediator = mediator;
        }


        [HttpPost]
        public async Task<IActionResult> FindAll([FromBody] BookFindAllRequest request)
        {
            var result = await _mediator.Send(new FindAll(request));
            if (result != null && result.Count == 0)
                throw new ReecException(ReecEnums.Category.PartialContent, "No se encontraron registros");

            return Ok(result);
        }

    }
}
