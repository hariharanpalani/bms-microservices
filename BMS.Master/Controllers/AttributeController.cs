using BMS.Master.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BMS.Master.Controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        private readonly IAttributeRepository _repository;

        public AttributeController(IAttributeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Entities.Attribute>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Entities.Attribute>>> GetUsers()
        {
            var attributes = await _repository.GetAttributes();
            return Ok(attributes);
        }
    }
}
