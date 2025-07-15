using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Validacoes
{
    public static class Validacao
    {
        public static string ValidarCPF(string cpf)
        {
            int primeiroDigito = 0;
            int segundoDigito = 0;
            string dentroCpf = cpf.Replace(".", "").Replace("-", "").Trim();
            int index = 0;
            if (string.IsNullOrEmpty(dentroCpf) || dentroCpf.Length != 11)
            {
                throw new Exception("Este CPF não possui 11 números!");
            }
            else
            {
                // Primeiro identificador
                int soma1 = 0;

                for (int i = 10; i > 1; i--)
                {
                    soma1 += i * Convert.ToInt32(dentroCpf.Substring(index, 1));
                    index++;
                }

                int restoDivisao1 = soma1 % 11;

                if (restoDivisao1 < 2)
                {
                    primeiroDigito = 0;
                }
                else
                {
                    primeiroDigito = 11 - restoDivisao1;
                }

                // Segundo identificador
                int soma2 = 0;
                int index2 = 0;

                for (int i = 11; i > 1; i--)
                {
                    soma2 += i * Convert.ToInt32(dentroCpf.Substring(index2, 1));
                    index2++;
                }
                int restoDivisao2 = soma2 % 11;

                if (restoDivisao2 < 2)
                {
                    segundoDigito = 0;
                }
                else
                {
                    segundoDigito = 11 - restoDivisao2;
                }

                if (primeiroDigito == Convert.ToInt32(dentroCpf.Substring(9, 1)) && segundoDigito == Convert.ToInt32(dentroCpf.Substring(10, 1)))
                {
                    Console.WriteLine($"O CPF: {dentroCpf} é válido!");
                    return dentroCpf;
                }
                else
                {
                    throw new Exception("CPF inválido!");
                }
            }
        }
    }
}
