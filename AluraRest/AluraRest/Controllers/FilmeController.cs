using AluraRest.Data;
using AluraRest.Data.DTO;
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
    public class FilmeController : ControllerBase
    {
        private AppDbContext _context; // podemos utilizar para acessar e guardar info do banco
        private IMapper _mapper;

        public FilmeController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
   
        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDTO filmeDto) // criamos um dto para proteger algumas informacoes, tipo o ID que agora nao pode ser mais manipulado pelo usuario na requisicao do body
        {
            // JEITO DE CONVERTER COM MAPPER
            Filme filme = _mapper.Map<Filme>(filmeDto); // __mapper.Map<PARA>(DE)

            // JEITO ANTIGO DE CONVERTER 
            // Filme filme = new Filme
            //{
            //   Titulo = filmeDto.Titulo,
            //  Genero = filmeDto.Genero,
            // Duracao = filmeDto.Duracao,
            // Diretor = filmeDto.Diretor
            //};

            _context.Filmes.Add(filme); // adiciona no banco
            _context.SaveChanges(); // salva no banco
            return CreatedAtAction(nameof(RecuperaFilmePorId), new  { Id = filme.Id }, filme); // aqui eu digo onde foi criado este objeto no header da reposta
        }

        [HttpGet]
        public IActionResult RecuperaFilmes([FromQuery] int? classificacaoEtaria = null) // usamos o IEnumerable pois se precisarmos mudar o tipo la na frente nao teremos problemas | digo que pode ser null ou inteiro
        {
            List<Filme> filmesComClassificacao = _context.Filmes.ToList();

            if (!filmesComClassificacao.Any())
            {
                return NotFound();
            }

            if (classificacaoEtaria == null)
            {
                return Ok(_context.Filmes);
            }
            else
            {
                filmesComClassificacao = _context.Filmes
                   .Where(filmesComClassificacao => filmesComClassificacao.ClassificacaoEtaria == classificacaoEtaria).ToList();

                var readDTO = _mapper.Map<List<ReadyFilmeDTO>>(filmesComClassificacao);

                return Ok(readDTO);
            }
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if(filme != null)
            {
                ReadyFilmeDTO filmeDto = _mapper.Map<ReadyFilmeDTO>(filme); // __mapper.Map<PARA>(DE)

                // ReadyFilmeDTO filmeDto = new ReadyFilmeDTO
                //{
                //   Id = filme.Id,
                //  Titulo = filme.Titulo,
                // Diretor = filme.Diretor,
                // Genero = filme.Genero,
                // Duracao = filme.Duracao,
                // HoraDaConsulta = DateTime.Now // retornando informacao extra com o dto da ready filme pois esse atributo nao existe na classe filme
                //};

                return Ok(filmeDto); // retorna 200
            }
            return NotFound(); // retornar 404

            /*
            foreach (var filme in filmes)
            {
                if (filme.Id.Equals(id))
                {
                    return filme;
                }
            }
            return null;
            */
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarFilme(int id)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                _context.Filmes.Remove(filme);
                _context.SaveChanges(); 
                return NoContent();
            }

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilme(int id, [FromBody] UpdateFilmeDTO filmeDto)
        {
            var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme != null)
            {
                //filme.Titulo = filmeDto.Titulo;
                //filme.Genero = filmeDto.Genero;
                //filme.Duracao = filmeDto.Duracao;
                //filme.Diretor = filmeDto.Diretor;

                _mapper.Map(filmeDto,filme); //aqui nao queremos converter um objeto de um tipo para outro e sim converter 2 objetos entre si (origem, destino)
                _context.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
    }
}

/* sobre mapper
 * 
 * var obj = _mapper.Map<Endereco>(enderecoDto);
 * obj será do tipo Endereco e foi mapeado a partir de um parâmetro chamado enderecoDto.
 * Alternativa correta! Primeiro é passado o tipo de destino e dentro dos parênteses passamos o parâmetro a ser convertido.
 * 
 */