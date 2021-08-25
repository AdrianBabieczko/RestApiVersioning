using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleAPI.Models;

namespace SampleAPI.Controllers.v1
{
    [ApiController]
    [Route("api/users")]
    public class UsersController: ControllerBase
    {
        [HttpGet()]
        public IActionResult AllUsers()
        {
            List<UserV1> users = new List<UserV1>()
            {
                new UserV1
                {
                    Id= 1,
                    Name = "Adrian"
                },
                new UserV1
                {
                    Id = 2,
                    Name="Test"
                },
                new UserV1
                {
                    Id = 3,
                    Name="Test2"
                }
            };

            return Ok(users);
        }
    }
}