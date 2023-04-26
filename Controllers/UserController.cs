﻿using Backend.Models;
using Backend.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetallUser()
        {
            try
            {
                return Ok(await _userRepository.GetAllUserAsync());

            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            var user = await _userRepository.GetUserAsync(id);
            return user == null ? BadRequest() : Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewUser(User model)
        {
            try
            {
                var newUser = await _userRepository.AddUserAsync(model);
                var user = await _userRepository.GetUserAsync(newUser);
                return user == null ? BadRequest() : Ok(user);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id,[FromBody] User user)
        {
            if (id != user.UserID)
            {
                return NotFound();
            }
            else
            {
                await _userRepository.UpdateUserAsync(id, user);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            await _userRepository.DeleteUserAsync(id);
            return Ok();
        }
    }
}
