using CleanArchDemo.Application.Users.Query;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var query = new GetAllUserQuery();
            var result = await _mediator.Send(query);
            return Ok(result);
        }
    }
}
