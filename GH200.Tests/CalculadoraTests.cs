
using GH200.Api;
using Xunit;

namespace GH200.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Somar_DoisNumeros_DeveRetornarCinco()
    {
        // Arrange: preparar os dados
        int a = 2;
        int b = 3;

        // Act: executar o método
        int resultado = Calculadora.Somar(a, b);

        // Assert: verificar o resultado
        Assert.Equal(5, resultado);
    }
}
