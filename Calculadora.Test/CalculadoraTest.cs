using System;
using Xunit;

namespace Calculadora.Test
{
    /// <tESTE FATOS>
    /// TESTE DE FATOS E ACERTOS
    /// </ADICAO, SUBTRACAO, MULTIPLICACAO E DIVISAO>
    public class CalculadoraTest
    {
        ///teste de soma de 2 numeros
        [Fact]
        public void Adicao()
        {
            Assert.Equal(20, Calculadora.Adicao(10, 10));
        }
        ///teste de subtracao de 2 numeros
        [Fact]
        public void Subtracao()
        {
            Assert.Equal(5, Calculadora.Subtracao(10, 5));
        }
        ///teste de multiplicacao de 2 numeros
        [Fact]
        public void Multiplicacao()
        {
            Assert.Equal(20, Calculadora.Multiplicacao(10, 2));
        }
        ///teste de divisao de 2 numeros
        [Fact]
        public void Divisao()
        {
            Assert.Equal(20, Calculadora.Divisao(10, 5));
        }
    }
}
