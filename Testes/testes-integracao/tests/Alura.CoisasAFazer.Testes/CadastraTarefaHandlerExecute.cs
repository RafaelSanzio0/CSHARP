using Alura.CoisasAFazer.Core.Commands;
using Alura.CoisasAFazer.Core.Models;
using Alura.CoisasAFazer.Services.Handlers;
using System;
using System.Linq;
using Xunit;

namespace Alura.CoisasAFazer.Testes
{
    public class CadastraTarefaHandlerExecute
    {
        [Fact]
        public void DadaTarefaComInfoValidasDeveIncluirNoBD()
        {
            //arrange
            var cadastraTarefa = new CadastraTarefa("Estudar Xunit", new Categoria("Estudo"), new DateTime(2019, 12, 31)); // poderia colocar o _fixture aqui 
            var repo = new RepositorioFake(); // provavelmente vai ser substituido pelo mock.SetupSetence
            var cadastraTarefaHandler = new CadastraTarefaHandler(repo); // poderia deixar fora daqui tipo no setup pois essa instancia vai ser utilizada para demais testes

            //act
            cadastraTarefaHandler.Execute(cadastraTarefa); //SUT >> CadastraTarefaHandlerExecute

            //assert
            var tarefa = repo.ObtemTarefas(t => t.Titulo == "Estudar Xunit").FirstOrDefault();
            Assert.NotNull(tarefa);
        }
    }
}
