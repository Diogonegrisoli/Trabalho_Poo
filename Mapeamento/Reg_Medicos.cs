using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Mapeamento
{
    internal class Reg_Medicos
    {
        private int id_reg_medico;
        public int Id_reg_medico
        {
            get { return id_reg_medico; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    id_reg_medico = value;
                }
            }
        }
        public string diagnostico;
        public string observacoes;
        private DateTime data_criacao;
        public DateTime Data_criacao
        {
            get { return data_criacao; }
            set
            {
                DateTime data = DateTime.Now;
                if (value > data)
                {
                    throw new Exception("Data inválida!");
                }
                else
                {
                    data_criacao = value;
                }
            }
        }
        public Reg_Medicos(int id, string diagnostico, string observacoes, DateTime data_criacao)
        {
            Id_reg_medico = id;
            this.diagnostico = diagnostico;
            this.observacoes = observacoes;
            Data_criacao = data_criacao;
        }
    }
}
