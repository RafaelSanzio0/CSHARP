using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.CrossCutting.DependencyInjection;
using Domain.Security;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Application {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            ConfigureService.ConfigureDependenciesService(services);
            ConfigureRepository.ConfigureDependenciesRepository(services);

            var signingConfigurations = new SigningConfigurations(); // injecao de dependencias diferente pois n utilizamos interface no contexto de jwt
            services.AddSingleton(signingConfigurations);

            var tokenConfigurations = new TokenConfigurations();
            new ConfigureFromConfigurationOptions<TokenConfigurations>(
                Configuration.GetSection("TokenConfigurations")) //INSERE O VALOR DO APPSETTINGS DENTRO DAS PROPRIEDAS DA CLASSE DE TOKENCONFIGURATION
                .Configure(tokenConfigurations);
            services.AddSingleton(tokenConfigurations);

            //adicionando o uso do token

            services.AddAuthentication(authOptions =>
            {
                authOptions.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                authOptions.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(bearerOptions =>
            {
                var paramsValidation = bearerOptions.TokenValidationParameters;
                paramsValidation.IssuerSigningKey = signingConfigurations.Key;
                paramsValidation.ValidAudience = tokenConfigurations.Audience;
                paramsValidation.ValidIssuer = tokenConfigurations.Issuer;
                paramsValidation.ValidateIssuerSigningKey = true; // valida assinatura de token recebido
                paramsValidation.ValidateLifetime = true; // verifica se o token recebido ainda é valido
                paramsValidation.ClockSkew = TimeSpan.Zero; //n aceita token vencido(salvo casos onde ha problemas de sincronismo de horario entre diferentes computadores envolvido no processo de comunicacao)
            });


            //ativa o uso do token como forma de autorizar o acesso ao recurso este projeto
            services.AddAuthorization(auth =>
            {
                auth.AddPolicy("Bearer", new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser().Build()); 
            });
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Curso de Api com ApsNetCore 3.1",
                    Description = "Arquitetura DDD",
                    Contact = new OpenApiContact
                    {
                        Name = "Rafael Sanzio",
                        Email = "RafaelQA@gmail.com"
                    }
                });

                //add btn de token no swagger
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Entre com o token JWT",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Id = "Bearer",
                                Type = ReferenceType.SecurityScheme
                            }
                        }, new List<string>()
                    }
                });
            });

            services.AddMvc(option => option.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            }

            
            // Ativando middlewares para uso do Swagger
            app.UseSwagger ();
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "Curso de API com AspNetCore 3.1");
                c.RoutePrefix = "swagger"; // swagger/index.html
            });
                
            app.UseMvc();
        }
    }
}
