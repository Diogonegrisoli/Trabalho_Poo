using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Interface;
using Hospital.Mapeamento;
using Hospital.Utilitarios;
using MySql.Data.MySqlClient;
namespace Hospital.DAO
{
    internal class ConsultasDAO : IDAO<Consultas>
    {
        public void Cadastrar(Consultas consulta)
        {
            try
            {
                string sql = "INSERT INTO Consultas(data_hora, fk_id_medico, fk_id_paciente) VALUES (@data_hora, @fk_id_medico, @fk_id_paciente);";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@data_hora", consulta.Data_hora);
                comando.Parameters.AddWithValue("@fk_id_medico", consulta.Fk_id_medico);
                comando.Parameters.AddWithValue("@fk_id_paciente", consulta.Fk_id_paciente);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Atualizar(Consultas consulta)
        {

        }

        public void Deletar(Consultas consulta)
        {
            string sql = "DELETE FROM Consultas WHERE id_consulta = @id_consulta";
            MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
            comando.Parameters.AddWithValue("@id_consulta", consulta.Id_consulta);
            comando.ExecuteNonQuery();
            Conexao.FecharConexao();
        }

        public List<Consultas> Selecionar(Consultas consulta)
        {
            List<Consultas> listaConsultas = new List<Consultas>();
            try
            {
                List<string> listaFiltros = new List<string>();
                string sql = @"SELECT c.id_consulta,c.data_hora,p.nome AS nome_paciente,
                            p.cpf AS cpf_paciente, m.nome AS nome_medico, 
                            m.id_medico FROM Consultas AS c
                            INNER JOIN Pacientes AS p ON c.fk_id_paciente = p.id_paciente
                            INNER JOIN Medicos AS m ON c.fk_id_medico = m.id_medico WHERE 1=1";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                if (consulta.Id_consulta > 0)
                {
                    listaFiltros.Add("c.id_consulta = @id_consulta");
                    comando.Parameters.AddWithValue("@id_consulta", consulta.Id_consulta);
                }

                if (consulta.pacienteConsulta != null && !string.IsNullOrEmpty(consulta.pacienteConsulta.Nome))
                {
                    listaFiltros.Add("p.nome LIKE @nome_paciente");
                    comando.Parameters.AddWithValue("@nome_paciente", "%" + consulta.pacienteConsulta.Nome + "%");
                }
               
                if (consulta.pacienteConsulta != null && !string.IsNullOrEmpty(consulta.pacienteConsulta.Cpf))
                {
                    listaFiltros.Add("p.cpf = @cpf_paciente");
                    comando.Parameters.AddWithValue("@cpf_paciente", consulta.pacienteConsulta.Cpf);
                }

                if (consulta.medicoConsulta != null && !string.IsNullOrEmpty(consulta.medicoConsulta.Nome))
                {
                    listaFiltros.Add("m.nome LIKE @nome_medico");
                    comando.Parameters.AddWithValue("@nome_medico","%" + consulta.medicoConsulta.Nome + "%");
                }
                if (consulta.medicoConsulta != null && consulta.medicoConsulta.Id_medico > 0)
                {
                    listaFiltros.Add("m.id_medico = @id_medico");
                    comando.Parameters.AddWithValue("@id_medico", consulta.medicoConsulta.Id_medico);
                }

                if (listaFiltros.Count > 0)
                {
                    sql += " AND " + string.Join(" AND ", listaFiltros);
                }

                sql += " ORDER BY c.id_consulta";
                comando.CommandText = sql;

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Consultas c = new Consultas();
                        c.Id_consulta = dr.GetInt32("id_consulta");
                        c.Data_hora = dr.GetDateTime("data_hora");

                        c.pacienteConsulta = new Pacientes()
                        {
                            Cpf = dr.GetString("cpf_paciente"),
                            Nome = dr.GetString("nome_paciente")
                        };

                        c.medicoConsulta = new Medicos()
                        {
                            Nome = dr.GetString("nome_medico"),
                            Id_medico = dr.GetInt32("id_medico")
                        };

                        listaConsultas.Add(c);
                    }
                }
                Conexao.FecharConexao();
                return listaConsultas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Consultas> SelecionarTodos()
        {
            List<Consultas> listaConsultas = new List<Consultas>();
            try
            {
                List<string> listaFiltros = new List<string>();
                string sql = @"SELECT c.id_consulta,c.data_hora,p.nome AS nome_paciente,
                            p.cpf AS cpf_paciente, m.nome AS nome_medico, 
                            m.id_medico FROM Consultas AS c
                            INNER JOIN Pacientes AS p ON c.fk_id_paciente = p.id_paciente
                            INNER JOIN Medicos AS m ON c.fk_id_medico = m.id_medico ORDER BY c.id_consulta";

                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Consultas c = new Consultas();
                        c.Id_consulta = dr.GetInt32("id_consulta");
                        c.Data_hora = dr.GetDateTime("data_hora");

                        c.pacienteConsulta = new Pacientes()
                        {
                            Nome = dr.GetString("nome_paciente"),
                            Cpf = dr.GetString("cpf_paciente")
                        };

                        c.medicoConsulta = new Medicos()
                        {
                            Nome = dr.GetString("nome_medico"),
                            Id_medico = dr.GetInt32("id_medico")
                        };

                        listaConsultas.Add(c);
                    }
                }
                Conexao.FecharConexao();
                return listaConsultas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
