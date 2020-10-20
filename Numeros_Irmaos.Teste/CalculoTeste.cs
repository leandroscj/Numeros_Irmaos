using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Números_Irmãos.Teste
{
    [TestClass]
    public class CalculoTeste
    {
        [TestMethod]
        public void Calculo_QuandoNumeroForMenorQue100000000_DeveRetornarCalculoDescendente()
        {
            // Arrange
            Calculo calculo = new Calculo();
            int numero = 486;
            int tamanho = 3;
            int resultado_Esperado = 864;

            //Act

            calculo.CalculoDescendente(tamanho, numero);
            int resultado_Retornado = calculo.Resultado;

            //Assert
            Assert.AreEqual(resultado_Esperado, resultado_Retornado);
        }

        [TestMethod]
        public void Calculo_QuandoNumeroForMaiorQue100000000_DeveRetornarNumeroPreDefinido()
        {
            // Arrange
            Calculo calculo = new Calculo();
            int numero = 1000000000;
            int tamanhoNumero = 10;
            int resultado_Esperado = -1;

            //Act
            calculo.CalculoDescendente(tamanhoNumero, numero);
            int resultado_Retornado = calculo.Resultado;

            //Assert

            Assert.AreEqual(resultado_Esperado, resultado_Retornado);
        }
    }
}