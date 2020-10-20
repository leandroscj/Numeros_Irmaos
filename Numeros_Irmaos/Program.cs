using System;

namespace Números_Irmãos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var calculo = new Calculo();

            try
            {
                Console.Write("Insira um número inteiro: ");
                var numeroRecebido = Console.ReadLine();

                var tamanhoNumero = numeroRecebido.Length;

                var numero = Convert.ToInt32(numeroRecebido);
                calculo.CalculoDescendente(tamanhoNumero, numero);

                Console.WriteLine(calculo);
            }
            catch (Exception)
            {
                Console.WriteLine("Verifique o numero inserido e tente novamente.");
            }
        }
    }
}