using Domain.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service.Test.Usuario
{
    //criando dados para os testes

    public class UsuarioTestes
    {
        public static string NomeUsuario { get; set; }

        public static string EmailUsuario { get; set; }

        public static string NomeUsuarioAlterado { get; set; }

        public static string EmailUsuarioAlterado { get; set; }

        public static Guid IdUsuario { get; set; }

        public List<UserDTO> listaUserDTO = new List<UserDTO>();

        public UserDTO userDTO;

        public CreateUserDTO createUserDTO;

        public ReadUserCreateDTO readUserCreateDTO;

        public UpdateUserDTO updateUserDTO;

        public ReadUserUpdateDTO readUserUpdateDTO;

        public UsuarioTestes()
        {
            IdUsuario = Guid.NewGuid();
            NomeUsuario = Faker.Name.FullName();
            EmailUsuario = Faker.Internet.Email();
            NomeUsuarioAlterado = Faker.Name.FullName();
            EmailUsuarioAlterado = Faker.Internet.Email();

            for (int i = 0; i < 10; i++) //para teste do getAll
            {
                var dto = new UserDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email()
                };

                listaUserDTO.Add(dto);
            }

            userDTO = new UserDTO // para teste do get
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            createUserDTO = new CreateUserDTO
            {
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            readUserCreateDTO = new ReadUserCreateDTO
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
                CreateAt = DateTime.UtcNow
            };

            updateUserDTO = new UpdateUserDTO
            {
                id = IdUsuario,
                Name = NomeUsuarioAlterado,
                Email = EmailUsuarioAlterado
            };

            readUserUpdateDTO = new ReadUserUpdateDTO
            {
                Id = IdUsuario,
                Name = NomeUsuarioAlterado,
                Email = EmailUsuarioAlterado,
                UpdateAt = DateTime.UtcNow
            };

        }
    }
}
