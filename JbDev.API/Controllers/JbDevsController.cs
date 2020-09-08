using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JbDev.API.Data;
using JbDev.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace JbDev.API.Controllers
{   
    
    [Route("api/commands")]
    [ApiController]
    public class JbDevsController : ControllerBase
    {
        private readonly IJbDevRepo _repository;
        public JbDevsController(IJbDevRepo repository)
        {
            _repository = repository;
        }

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}
