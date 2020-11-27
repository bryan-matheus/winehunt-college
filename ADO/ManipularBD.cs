using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ADO
{
    public class ManipularBD
    {
        private static MySqlConnection cn;
        private static MySqlCommand cmd;
        private static MySqlDataReader dr;
        private static MySqlDataAdapter da;
        private static DataSet ds;
        private static DataTable dt;

        private static readonly string stringConexao = @"User ID=root;Password=;Host=localhost;Port=3306;Database=winehunt_db;Protocol=TCP;Compress=false;Pooling=true;Min Pool Size=0;Max Pool Size=100;Connection Lifetime=0;";

        public static MySqlConnection ConectarBanco()
        {
            try
            {
                cn = new MySqlConnection(stringConexao);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                return cn;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void FecharBanco(MySqlConnection minhaStringConexao)
        {
            try
            {
                if (minhaStringConexao.State == ConnectionState.Open)
                {
                    minhaStringConexao.Close();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static string InformacaoBancoDados()
        {
            try
            {
                string info = "";
                cn = new MySqlConnection(stringConexao);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                    info = "Conectado com o banco versão " + cn.ServerVersion + " utilizando a fonte de dados " + cn.DataSource;
                }
                return info;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader RetornarDataReader(string meuComandoSql)
        {
            try
            { 
                cmd = new MySqlCommand(meuComandoSql, ConectarBanco());
                dr = cmd.ExecuteReader();
                return dr;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataTable RetornarDataTable(string meuComandoSql)
        {
            try
            {
                dt = new DataTable();
                cmd = new MySqlCommand(meuComandoSql, ConectarBanco());
                da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public DataSet RetornarDataSet(string meuComandoSql)
        {
            try
            {
                ds = new DataSet();
                cmd = new MySqlCommand(meuComandoSql, ConectarBanco());
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarComando(string instrucao)
        {
            try
            {
                cmd = new MySqlCommand(instrucao, ConectarBanco());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ExecutarComandoParametro(string instrucao, MySqlParameter[] listaParametros)
        {
            try
            {
                cmd = new MySqlCommand
                {
                    Connection = ConectarBanco(),
                    CommandText = instrucao,
                    CommandType = CommandType.Text
                };
                if (listaParametros != null)
                {
                    foreach (MySqlParameter item in listaParametros)
                    {
                        cmd.Parameters.Add(item);
                    }
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
