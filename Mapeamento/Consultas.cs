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

                data_hora = value;

            }
        }


        private int fk_id_medico;
        public int Fk_id_medico
        {
            get { return fk_id_medico; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    fk_id_medico = value;
                }
            }
        }
        private int fk_id_paciente;
        public int Fk_id_paciente
        {
            get { return fk_id_paciente; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("O id não pode ser menor ou igual a zero.");
                }
                else
                {
                    fk_id_paciente = value;
                }
            }
        }
        public Medicos medicoConsulta { get; set; }
        public Pacientes pacienteConsulta { get; set; }
    }
}
