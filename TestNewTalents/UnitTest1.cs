using NewTalents.Services;

namespace TestNewTalents;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2, 3)]
    [InlineData(2,3, 5)]
    public void TestSoma(int a, int b, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoEsperado = calc.Soma(a,b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(1,2, 2)]
    [InlineData(2,3, 6)]
    public void TestMultiplicar(int a, int b, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoEsperado = calc.Multiplicar(a,b);

        Assert.Equal(resultado, resultadoEsperado);
    }

    [Theory]
    [InlineData(5,2, 3)]
    [InlineData(3,3, 0)]
    public void TestSubtrair(int a, int b, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        int resultadoEsperado = calc.Subtrarir(a,b);

        Assert.Equal(resultado, resultadoEsperado);
    }[Theory]
    [InlineData(6,2, 3)]
    [InlineData(10,2, 5)]
    public void TestDividir(int a, int b, int resultado)
    {
        CalculadoraSimples calc = new CalculadoraSimples();

        var resultadoEsperado = calc.Dividir(a,b);

        Assert.Equal(resultado.ToString(), resultadoEsperado.ToString());
    }

    [Fact]
    public void HistoricoNaoVazio()
    {
        // Given
        CalculadoraSimples calc = new CalculadoraSimples();
        calc.Soma(1,2);
        calc.Soma(3,5);
        calc.Soma(3,5);
        calc.Soma(3,5);
        
        // When
        var lista = calc.Historico();
    
        // Then
        Assert.NotEmpty(lista);
    }
}