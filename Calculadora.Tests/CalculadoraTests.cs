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

    [Fact]
    public void Subtrair_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora.Core.Calculadora();

        var resultado = calculadora.Subtrair(5, 3);

        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Multiplicar_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora.Core.Calculadora();

        var resultado = calculadora.Multiplicar(2, 3);

        Assert.Equal(6, resultado);
    }

    [Fact]
    public void Dividir_DeveRetornarResultadoCorreto()
    {
        var calculadora = new Calculadora.Core.Calculadora();

        var resultado = calculadora.Dividir(6, 3);

        Assert.Equal(2, resultado);
    }

    [Fact]
    public void Dividir_PorZero_DeveLancarExcecao()
    {
        var calculadora = new Calculadora.Core.Calculadora();

        Assert.Throws<ArgumentException>(() => calculadora.Dividir(6, 0));
    }
}
