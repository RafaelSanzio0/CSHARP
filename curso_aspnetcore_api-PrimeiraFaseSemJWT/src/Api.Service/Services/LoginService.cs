using Api.Domain.Entities;
using Domain.DTO;
using Domain.Interfaces;
using Domain.Repository;
using Domain.Security;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LoginService : ILoginService
    {
        private IUserRepository _userRepository;

        private SigningConfigurations _signingConfigurations;
        private TokenConfigurations _tokenConfigurations;
        private IConfiguration _configuration;

        public LoginService(IUserRepository userRepository, SigningConfigurations signingConfigurations, TokenConfigurations tokenConfigurations, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _signingConfigurations = signingConfigurations;
            _tokenConfigurations = tokenConfigurations;
            _configuration = configuration;
        }

        public async Task<Object> FindByLogin(CreateLoginDTO user)
        {
            var baseUser = new UserEntity();

            if (user != null && !string.IsNullOrWhiteSpace(user.Email)) //user que recebi e diferente de null e o email recebido é diferente de null ou espaco em branco
            {
                baseUser = await _userRepository.FindByLogin(user.Email); //como temos o crosscuting entre IUserRepository e UserImplementation quando, assim que é criado a propriedade _userRepository eu automaticamente instancio um obj da UserImplementation
                if (baseUser == null)
                {
                    return new { autenticated = false, message = "Falha ao autenticar" };
                }
                else
                {
                    var identity = new ClaimsIdentity(new GenericIdentity(baseUser.Email),
                        new[]
                        {
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()), //jti id do token
                            new Claim(JwtRegisteredClaimNames.UniqueName, baseUser.Email),
                        }
                    );

                    DateTime createDate = DateTime.Now;
                    DateTime expirationDate = createDate + TimeSpan.FromSeconds(_tokenConfigurations.Seconds);

                    var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
                    string token = CreateToken(identity, createDate, expirationDate, jwtSecurityTokenHandler);

                    return SucessObject(createDate, expirationDate, token, user);
                }
            }
            else
            {
                return new { autenticated = false, message = "Falha ao autenticar" };
            }
        }

        private string CreateToken(ClaimsIdentity claimsIdentity, DateTime createDate, DateTime expirationDate, JwtSecurityTokenHandler jwtSecurityTokenHandler)
        {
            var securityToken = jwtSecurityTokenHandler.CreateToken(new SecurityTokenDescriptor
            {
                Issuer = _tokenConfigurations.Issuer,
                Audience = _tokenConfigurations.Audience,
                SigningCredentials = _signingConfigurations.SigningCredentials,
                Subject = claimsIdentity,
                NotBefore = createDate,
                Expires = expirationDate,
            }); // cria o token

            var token = jwtSecurityTokenHandler.WriteToken(securityToken);
            return token;
        }

        private object SucessObject(DateTime createDate, DateTime expirationDate, string token, CreateLoginDTO user)
        {
            return new
            {
                authenticated = true,
                created = createDate.ToString("yyyy-MM-dd HH:mm:ss"),
                expiration = expirationDate.ToString("yyyy-MM-dd HH:mm:ss"),
                acessToken = token,
                userName = user.Email,
                message = "Usuario logado com sucesso!"
            };
        }
    }
}
        
    


/* iremos fazer o login para posteriormente utilizar as demais apis
 * 
 * 1 - login (jwt)
 * 2 - criar usuario (usando jwt do login)
 * 3 - obter usuario (usando jwt do login)
 * 4 - atualizar usuario (usando jwt do login)
 * 5 - deletar usuario (usando jwt do login)
*/