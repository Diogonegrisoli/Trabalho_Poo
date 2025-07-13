using Hospital.Validacoes;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital.Mapeamento
{
    public class Pacientes
    {
        private int id_paciente;
        public int Id_paciente
        {
            get { return id_paciente; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    id_paciente = value;
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
                    sexo = value;
                }
                else if (value == null)
                {
                    throw new Exception("Informe o sexo!");
                }
                else
                {
                    throw new Exception("Digite apenas M ou F!");
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
                    throw new Exception("Informe o nome!");
                }
                else
                {
                    nome = value;
                }
            }
        }

        private string tipo_sangue;
        public string Tipo_Sangue
        {
            get { return tipo_sangue; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("Informe o tipo sanguíneo!");
                }
                else
                {
                    tipo_sangue = value;
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
        private string cpf;
        public string Cpf
        {
            get { return cpf; }
            set
            {
                try
                {           
                    cpf = Validacao.ValidarCPF(value); 
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public Pacientes()
        {

        }

        public Pacientes(char sexo, string nome, string tipo_sangue, string telefone, DateTime data_nasc, string cpf)
        {
            Sexo = sexo;
            Nome = nome;
            Tipo_Sangue = tipo_sangue;
            Telefone = telefone;
            Data_nasc = data_nasc;
            Cpf = cpf;
        }
    }
}
