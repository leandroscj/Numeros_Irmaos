using System;

namespace Números_Irmãos
{
    public class Calculo
    {
        public int Resultado { get; set; }

        public int CalculoDescendente(int tamanhoNumero, int numero)
        {
            if (tamanhoNumero >= 8)
            {
                return Resultado = -1;
            }
            else
            {
                int[] digitos = new int[tamanhoNumero];

                for (int i = 0; i < tamanhoNumero; i++)
                {
                    digitos[i] = (numero % 10);
                    numero /= 10;
                }

                Array.Sort(digitos);

                int numeroDescendente = 0;
                for (int i = tamanhoNumero - 1; i >= 0; i--)
                {
                    numeroDescendente = numeroDescendente * 10 + digitos[i];
                }

                return Resultado = numeroDescendente;
            }
        }

        public override string ToString()
        {
            return "Seu numero é: " + Resultado;
        }
    }
}