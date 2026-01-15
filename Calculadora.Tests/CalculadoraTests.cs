using Xunit;
using Calculadora.Core;

namespace Calculadora.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Somar_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora.Core.Calculadora();

        var resultado = calculadora.Somar(2, 3);

        Assert.Equal(5, resultado);
    }
}
