using BMS.Admin.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BMS.Admin.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Entities.User>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Entities.User>>> GetUsers()
        {
            var users = await _repository.GetUsers();
            return Ok(users);
        }
    }
}
