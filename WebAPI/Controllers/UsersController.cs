﻿using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyemail")]
        public IActionResult Get(string email)
        {
            var result = _userService.Get(email);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallclaims")]
        public IActionResult GetByUsersOperationClaim(User user)
        {
            var result = _userService.GetByUsersOperationClaim(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcustomers")]
        public IActionResult GetByUsersCustomer(User user)
        {
            var result = _userService.GetByUsersCustomer(user);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(User user)
        {
            var result = _userService.Update(user);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
