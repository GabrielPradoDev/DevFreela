﻿using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        //POST api/user
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }
    }
}