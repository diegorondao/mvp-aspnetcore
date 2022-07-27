using Application.Queries.GetCategories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class Categories : ControllerBase
    {
        private readonly IMediator _mediator;

        public Categories(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategories()
        {
            var getCategoriesQuery = new GetCategoriesQuery();

            var result = await _mediator.Send(getCategoriesQuery);

            return Ok(result);
        }
    }
}