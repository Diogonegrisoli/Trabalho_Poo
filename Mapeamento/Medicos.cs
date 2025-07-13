using Hospital.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Mapeamento
{
    internal class Medicos
    {
        private int id_medico;
        public int Id_medico
        {
            get { return id_medico; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    id_medico = value;
                }
            }
        }

        private char sexo;
        public char Sexo
        {
            get { return sexo; }
            set
            {             
                if (value == 'F' || value == 'M')
                {
                    sexo = Convert.ToChar(value.ToString().ToUpper());
                }
                else
                {
                    throw new Exception("Digite apenas M ou F.");
                }
            }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set
            {
                if (value == String.Empty)
                {
                    throw new Exception("Não deixe o campo vazio!");
                }
                else
                {
                    nome = value;
                }
            }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Digite o número de telefone.");
                }
                else
                {
                    telefone = value;
                }
            }
        }
        private DateTime data_nasc;
        public DateTime Data_nasc
        {
            get { return data_nasc; }
            set
            {
                DateTime data = DateTime.Now;
                if (value > data)
                {
                    throw new Exception("Data inválida!");
                }
                else
                {
                    data_nasc = value;
                }
            }
        }
        private string crm;
        public string Crm
        {
            get { return crm; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Não deixe o campo vazio!");
                }
                else
                {
                    crm = value;
                }
            }
        }
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set
            {         
                cpf = Validacao.ValidarCPF(value);
            }
        }

        public Medicos(int id, char sexo, string nome, string crm, string telefone, DateTime data_nasc, string cpf)
        {
            Id_medico = id;
            Sexo = sexo;
            Crm = crm;
            Nome = nome;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Cpf = cpf;
        }

    }
}
