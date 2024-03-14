using System;
namespace PrimeiroProjeto
{
	public class Uteis
	{
        public static string zerosAEsquerda(int numero,
                                            int tamanho)
        {
            string numeroEmString = "" + numero;

            while (tamanho > numeroEmString.Length)
            {
                numeroEmString = "0" + numeroEmString;
            }

            return numeroEmString;
        }
    }
}
