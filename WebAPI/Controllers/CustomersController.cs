﻿
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult Get(int Id)
        {
            var result = _customerService.Get(Id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult update(Customer customer)
        {
            var result = _customerService.Update(customer);
            if (result != null)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
