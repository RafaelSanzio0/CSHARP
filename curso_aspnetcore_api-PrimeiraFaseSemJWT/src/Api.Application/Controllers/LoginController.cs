using Api.Domain.Entities;
using Domain.Interfaces;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<Object> Login([FromBody] CreateLoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.FindByLogin(loginDTO);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound(); // n encontrou na base
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
