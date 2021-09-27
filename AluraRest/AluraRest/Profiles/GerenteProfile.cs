using AluraRest.Data.DTO.Gerente;
using AluraRest.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluraRest.Profiles
{
    public class GerenteProfile : Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDTO, Gerente>();

            CreateMap<Gerente, ReadGerenteDTO>() // mapea de gerente para readgerentedto                                  RESUMO => Estamos mapeando de um Gerente para um ReadGerenteDto. Para o campo Cinemas, estamos selecionando apenas os campos Id, Nome, Endereco e EnderedoId.
                .ForMember(gerente => gerente.Cinemas, opts => opts // e para o membro cinemas dentro do meu gerente
                .MapFrom(gerente => gerente.Cinemas.Select // para esse gerente traga apenas id,nome etc e armazene no obj anonimo... @pra isso o objeto  manipulado como o cinema no caso deve ser do tipo object
                (cinema => new { cinema.Id, cinema.Nome, cinema.Endereco, cinema.EnderecoId })));
        }
    }
}

// alem do json ignore podemos especificar exatamente o que queeremos trazer no read como exemplo acima

