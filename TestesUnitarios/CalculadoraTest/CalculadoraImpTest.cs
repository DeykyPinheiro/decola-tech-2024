using System.ComponentModel;
using System.Runtime.CompilerServices;
using Calculadora.Services;

namespace CalculadoraTest;

public class CalculadoraImpTest
{

    private CalculadoraImp _calculadora;

    public CalculadoraImpTest()
    {
        // aqui era pra ser injetada
        _calculadora = new CalculadoraImp();
    }

    [Fact] // [Fact] diz que é um teste
    public void DeveRetornar15_QuandoSomarCorretamente10Com5()
    {
        // cenario / Arrange
        int a = 5;
        int b = 10;

        // acao / Act
        int resultado = _calculadora.Soma(a, b);

        // assercao / Assert
        Assert.Equal(15, resultado);
    }



    [Fact]
    public void DeveRetornarTrue_QuandoPassarNumeroPares()
    {
        // cenario / Arrange
        int n = 2;

        // acao / Act
        bool resultado = _calculadora.EhPar(n);

        // assercao / Assert
        Assert.True(resultado);
    }


    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    public void DeveRetornarTrue_QuandoPassarUmNumeroPar(int n)
    {
        // acao / Act
        bool resultado = _calculadora.EhPar(n);

        // assercao / Assert
        Assert.True(resultado);
    }


    [Theory]
    [InlineData(new int[] { 2, 4, })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveRetornarTrue_QuandoPassarUmaListaDePares(int[] numeros)
    {
        //  Act / Assert
        Assert.All(numeros, n => Assert.True(_calculadora.EhPar(n)));
    }

}

