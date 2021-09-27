using AluraRest.Data.DTO.Gerente;
using AluraRest.Models;
using AutoMapper;
using FilmesApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDTO dto)
        {
            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = gerente.Id }, gerente);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            var gerente = _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null)
            {
                ReadGerenteDTO gerenteDTO = _mapper.Map<ReadGerenteDTO>(gerente);
                return Ok(gerenteDTO);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarGerente(int id)
        {
            var gerente = _context.Enderecos.FirstOrDefault(gerente => gerente.Id == id);
            if (gerente != null)
            {
                _context.Enderecos.Remove(gerente);
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound();
        }
    }
}
