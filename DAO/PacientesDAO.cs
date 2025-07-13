using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Interface;
using System.Windows.Forms;
using Hospital.Mapeamento;
using MySql.Data.MySqlClient;
using Hospital.Utilitarios;
using System.Drawing;
using Hospital.Formularios;
namespace Hospital.DAO
{

    public class PacientesDAO : IDAO<Pacientes>
    {
        public void Cadastrar(Pacientes paciente)
        {
            try
            {
                string sql = "INSERT INTO Pacientes(nome, cpf, data_nasc, telefone, sexo, tipo_sangue) VALUES (@nome, @cpf, @data_nasc, @telefone, @sexo, @tipo_sangue);";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", paciente.Nome);
                comando.Parameters.AddWithValue("@cpf", paciente.Cpf);
                comando.Parameters.AddWithValue("@data_nasc", paciente.Data_nasc);
                comando.Parameters.AddWithValue("@telefone", paciente.Telefone);
                comando.Parameters.AddWithValue("@sexo", paciente.Sexo);
                comando.Parameters.AddWithValue("@tipo_sangue", paciente.Tipo_Sangue);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Atualizar(Pacientes paciente)
        {
            try
            {
                string sql = "UPDATE Pacientes SET nome = @nome,telefone = @telefone WHERE id_paciente = @id_paciente;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", paciente.Nome);
                comando.Parameters.AddWithValue("@telefone", paciente.Telefone);
                comando.Parameters.AddWithValue("@id_paciente", paciente.Id_paciente);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Deletar(Pacientes paciente)
        {
            try
            {
                string sql = "DELETE FROM Pacientes WHERE id_paciente = @id_paciente;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_paciente", paciente.Id_paciente);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível deletar o registro!");
            }

        }

        public List<Pacientes> Selecionar(Pacientes paciente)
        {
            List<Pacientes> listaPacientes = new List<Pacientes>();
            try
            {
                List<string> listaFiltros = new List<string>();
                string sql = "SELECT * FROM Pacientes WHERE 1=1";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
   
                if (!string.IsNullOrEmpty(paciente.Nome))
                {
                    listaFiltros.Add("nome LIKE @nome");
                    comando.Parameters.AddWithValue("@nome", "%" + paciente.Nome + "%");
                }
                if (paciente.Id_paciente > 0)
                {
                    listaFiltros.Add("id_paciente = @id_paciente");
                    comando.Parameters.AddWithValue("@id_paciente", paciente.Id_paciente);
                }
                if (!string.IsNullOrEmpty(paciente.Cpf))
                {
                    listaFiltros.Add("cpf = @cpf");
                    comando.Parameters.AddWithValue("@cpf", paciente.Cpf);
                }

                if (listaFiltros.Count > 0)
                {
                    sql += " AND " + string.Join(" AND ", listaFiltros);
                }

                comando.CommandText = sql;

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Pacientes p = new Pacientes(); 
                        p.Id_paciente = dr.GetInt32("id_paciente");
                        p.Nome = dr.GetString("nome");
                        p.Cpf = dr.GetString("cpf");
                        p.Telefone = dr.GetString("telefone");
                        p.Tipo_Sangue = dr.GetString("tipo_sangue");
                        listaPacientes.Add(p);
                    }
                }
                Conexao.FecharConexao();
                return listaPacientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
