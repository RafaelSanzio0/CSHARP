using Alura.CoisasAFazer.Infrastructure;
using Alura.CoisasAFazer.Services.Handlers;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace Alura.CoisasAfazer.Tests
{
    public class CadastraTarefaHandlerTest
    {
        private Mock<IRepositorioTarefas> _repositorioTarefas;
        private Mock<ILogger<CadastraTarefaHandler>> _logger;
        private CadastraTarefaHandler _cadastraTarefaHandler;

        [SetUp]
        public void SetUp()
        {
            _repositorioTarefas = new Mock<IRepositorioTarefas>();
            _logger = new Mock<ILogger<CadastraTarefaHandler>>();
        }

        [Test]
        public void Constructor_ShouldBeSucces()
        {
            // Arrange

            // Act
            _cadastraTarefaHandler = new CadastraTarefaHandler();


            // Assert
            Assert.IsInstanceOf<CadastraTarefaHandler>(_cadastraTarefaHandler);

        }
    }
}
