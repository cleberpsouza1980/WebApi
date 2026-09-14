using Web.Application.Interfaces;
using WebApi.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Web.Application.DTOs;

namespace WebApi.Tests;

public class AccontServiceControllerTests
{
    private Mock<IAccountPlanServices> _service;
    private AccontServiceController _controller;

    public AccontServiceControllerTests()
    {
        _service = new Mock<IAccountPlanServices>();
        _controller = new AccontServiceController(_service.Object);
    }

    [Fact(DisplayName = "GET All - Deve retornar lista de contas")]
    [Trait("Category", "Get")]
    public async Task GetAccountAll_ReturnsOkResult_WithListOfAccounts()
    {
        // Arrange - Configura o mock para retornar uma lista
        var expectedAccounts = new List<AccountPlanDto>
    {
        new AccountPlanDto { Id = 1, Code= "1.12", Name = "Conta 1",Type="Receita",AcceptsLaunches=false },
        new AccountPlanDto { Id = 2,  Code= "1.12", Name = "Conta 2", AcceptsLaunches=true }
    };

        _service.Setup(x => x.GetAllAccountPlansAsync())
                    .ReturnsAsync(expectedAccounts);

        // Act - Executa o método do controller
        var result = await _controller.GetAccountAll();

        // Assert - Verifica o resultado
        var okResult = Assert.IsType<OkObjectResult>(result);
        var actualAccounts = Assert.IsType<List<AccountPlanDto>>(okResult.Value);
        Assert.Equal(expectedAccounts.Count, actualAccounts.Count);
        Assert.Equal(expectedAccounts[0].Id, actualAccounts[0].Id);
    }
}
