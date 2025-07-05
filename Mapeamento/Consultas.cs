using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Mapeamento
{
    internal class Consultas
    {
        private int id_consulta;
        public int Id_consulta
        {
            get { return id_consulta; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    id_consulta = value;
                }
            }
        }

        private DateTime data_hora;
        public DateTime Data_hora
        {
            get { return data_hora; }
            set
            {
                DateTime data = DateTime.Now;
                if (value > data)
                {
                    throw new Exception("Data inválida!");
                }
                else
                {
                    data_hora = value;
                }
            }
        }

        private int fk_id_medico;
        private int fk_id_paciente;
        private int fk_id_reg_medico;
        public Medicos medicoConsulta;
        public Pacientes pacienteConsulta;
        public Reg_Medicos regMedicoConsulta;
    }
}
