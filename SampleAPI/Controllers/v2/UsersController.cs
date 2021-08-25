using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers.v2
{
    [ApiController]
    // [Route("api/v{version:apiVersion}/Users")]
    [Route("api/Users")]
    [ApiVersion("2.0")]
    public class UsersController:ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            List<UserV2> users = new List<UserV2>()
            {
                new UserV2
                {
                    Id= System.Guid.NewGuid(),
                    Name = "Adrian"
                },
                new UserV2
                {
                    Id= System.Guid.NewGuid(),
                    Name="Test"
                },
                new UserV2
                {
                    Id= System.Guid.NewGuid(),
                    Name="Test2"
                }
            };

            return Ok(users);
        }
        
    }
}