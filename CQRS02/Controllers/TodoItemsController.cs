using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CQRS02.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRS02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly IMediator _mediatR;
        public TodoItemsController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post([FromBody] CreateCommand command)
        {
            return Ok(await _mediatR.Send(command));
        }
    }
}