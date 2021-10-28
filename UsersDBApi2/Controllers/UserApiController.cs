using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersDBApi2.Models;
using UsersDBApi2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace UsersDBApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersApiController : ControllerBase

    {
        private readonly IUserService _userService;
        public UsersApiController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _userService.Get();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUsers([FromBody]User user)
        {
            var newUser = await _userService.Create(user);

            return CreatedAtAction(nameof(GetUser), new { id = newUser.Id}, newUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(int id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            await _userService.Update(user);

            return Ok("Updated succesfully");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> Delete(int id)
        {
            var user = await _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            await _userService.Delete(user.Id);
           
            return Ok("User was deleted succesfully");
        }

    }
}
