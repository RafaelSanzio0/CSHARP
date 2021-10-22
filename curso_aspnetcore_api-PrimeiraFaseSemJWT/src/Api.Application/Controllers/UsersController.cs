using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers {

    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {

        private IUserService _service;

        public UsersController (IUserService service) {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid) //senao for valido por exemplo tipo de dado invalido
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = await _service.GetAll();
                return Ok(response);
            }
            catch(ArgumentException e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpGet]
        [Route ("{id}", Name = "GetWithId")] //dando nome para a rota
        public async Task<ActionResult> Get(Guid id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok (await _service.Get(id));
            }
            catch(ArgumentException e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] UserEntity user)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(user);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetWithId", new { id = result.Id })), result); //criei um id a partir do new
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (ArgumentException e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] UserEntity user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Put(user);

                if(result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (ArgumentException e)
            {
                return StatusCode((int) HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Delete(id)); // ja retorna o true o false dentro do retorno
            }
            catch (ArgumentException e)
            {
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }

        }
        
    }
}
