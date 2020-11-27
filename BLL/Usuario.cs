using ADO;
using System;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        private int _IdUsuario;
        private string _Nome;
        private string _Nickname;
        private string _Senha;
        private bool _StatusUsu;

        public int IdUsuario { get => _IdUsuario; set => _IdUsuario = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Nickname { get => _Nickname; set => _Nickname = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public bool StatusUsu { get => _StatusUsu; set => _StatusUsu = value; }

        private static string instrucaoSql;
        readonly ManipularBD bd = new ManipularBD();
        public int LogarRecuperarCodigo()
        {
            try
            {
                instrucaoSql = $"SELECT id_usuario, nome, nickname, senha, status_usu FROM tb_usuario WHERE nickname ='{_Nickname}' AND senha ='{_Senha}' AND status_usu = 1";
                MySqlDataReader dr = bd.RetornarDataReader(instrucaoSql);
                if (dr.Read())
                {
                    _IdUsuario = Convert.ToInt32(dr["id_usuario"]);
                    return _IdUsuario;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader RetornaNome(int IdUsuario)
        {
            try
            {
                instrucaoSql = "SELECT nome FROM tb_usuario WHERE id_usuario = " + IdUsuario;
                return bd.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
