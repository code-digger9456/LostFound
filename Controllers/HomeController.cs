using LostFound.Modals;
using LostFound.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LostFound.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userservice)
        {
            _userService = userservice;
        }
        [HttpGet]
        public IActionResult GetUserDetails()
        {
            return Ok(_userService.GetUserDetails());
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public IActionResult GetUserDetail(Guid id)
        {
            return Ok(_userService.GetUserDetail(id));
        }

        // POST api/<HomeController>
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails user)
        {
            return Ok(_userService.AddUser(user));

        }

        // PUT api/<HomeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
