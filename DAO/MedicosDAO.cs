using Hospital.Interface;
using Hospital.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Hospital.Utilitarios;

namespace Hospital.DAO
{
    public class MedicosDAO : IDAO<Medicos>
    {
        public void Cadastrar(Medicos medico)
        {
            try
            {
                string sql = "INSERT INTO Medicos(nome, crm, cpf, sexo, telefone, data_nasc) VALUES (@nome, @crm, @cpf, @sexo, @telefone, @data_nasc);";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", medico.Nome);
                comando.Parameters.AddWithValue("@crm", medico.Crm);
                comando.Parameters.AddWithValue("cpf", medico.Cpf);
                comando.Parameters.AddWithValue("@sexo", medico.Sexo);
                comando.Parameters.AddWithValue("@telefone", medico.Telefone);
                comando.Parameters.AddWithValue("@data_nasc", medico.Data_nasc);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Atualizar(Medicos medico)
        {
            try
            {
                string sql = "UPDATE Medicos SET nome = @nome, telefone = @telefone, crm = @crm WHERE id_medico = @id_medico;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_medico", medico.Id_medico);
                comando.Parameters.AddWithValue("@nome", medico.Nome);
                comando.Parameters.AddWithValue("@telefone", medico.Telefone);
                comando.Parameters.AddWithValue("@crm", medico.Crm);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Deletar(Medicos medico)
        {
            try
            {
                string sql = "DELETE FROM Medicos WHERE id_medico = @id_medico;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_medico", medico.Id_medico);
                comando.ExecuteNonQuery();
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<Medicos> Selecionar(Medicos Medico)
        {
            List<Medicos> listaMedicos = new List<Medicos>();
            try
            {
                List<string> listaFiltros = new List<string>();
                string sql = "SELECT * FROM Medicos WHERE 1=1";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                if (!string.IsNullOrEmpty(Medico.Nome))
                {
                    listaFiltros.Add("nome LIKE @nome");
                    comando.Parameters.AddWithValue("@nome", "%" + Medico.Nome + "%");
                }
                if (Medico.Id_medico > 0)
                {
                    listaFiltros.Add("id_medico = @id_medico");
                    comando.Parameters.AddWithValue("@id_medico", Medico.Id_medico);
                }
                if (!string.IsNullOrEmpty(Medico.Cpf))
                {
                    listaFiltros.Add("cpf = @cpf");
                    comando.Parameters.AddWithValue("@cpf", Medico.Cpf);
                }
                if (!string.IsNullOrEmpty(Medico.Crm))
                {
                    listaFiltros.Add("crm LIKE @crm");
                    comando.Parameters.AddWithValue("@crm", "%" + Medico.Crm + "%");
                }

                if(listaFiltros.Count() > 0)
                {
                    sql += " AND " + string.Join(" AND ", listaFiltros);
                }

                comando.CommandText = sql;

                using(MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Medicos m = new Medicos();
                        m.Id_medico = dr.GetInt32("id_medico");
                        m.Nome = dr.GetString("nome");
                        m.Crm = dr.GetString("crm");
                        m.Cpf = dr.GetString("cpf");
                        m.Sexo = dr.GetChar("sexo");
                        m.Telefone = dr.GetString("telefone");
                        m.Data_nasc = dr.GetDateTime("data_nasc");
                        listaMedicos.Add(m);
                    }
                }
                Conexao.FecharConexao();
                return listaMedicos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Medicos> SelecionarTodos()
        {
            try
            {
                List<Medicos> lista = new List<Medicos>();

                string sql = "SELECT * FROM Medicos;";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());

                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Medicos m = new Medicos();
                        m.Id_medico = dr.GetInt32("id_medico");
                        m.Nome = dr.GetString("nome");
                        m.Crm = dr.GetString("crm");
                        m.Cpf = dr.GetString("cpf");
                        m.Sexo = dr.GetChar("sexo");
                        m.Telefone = dr.GetString("telefone");
                        m.Data_nasc = dr.GetDateTime("data_nasc");
                        lista.Add(m);
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
