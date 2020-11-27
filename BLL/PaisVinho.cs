using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PaisVinho
    {
        private int _IdPaisVinho;
        private string _NomePais;
        private string _ImagemBandeira;
        private bool _StatusPais;

        public int IdPaisVinho { get => _IdPaisVinho; set => _IdPaisVinho = value; }
        public string NomePais { get => _NomePais; set => _NomePais = value; }
        public string ImagemBandeira { get => _ImagemBandeira; set => _ImagemBandeira = value; }
        public bool StatusPais { get => _StatusPais; set => _StatusPais = value; }

        ADO.ManipularBD bd = new ADO.ManipularBD();
        private static string instrucaoSql;
        public MySqlDataReader ListarPais(int id)
        {
            try
            {
                instrucaoSql = $"SELECT id_pais_vinho, nome_pais, imagem_bandeira FROM tb_pais_vinho WHERE status_pais = 1 AND id_pais_vinho = {id}";
                return bd.RetornarDataReader(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ListarPaises()
        {
            try
            {
                instrucaoSql = $"SELECT id_pais_vinho, nome_pais, imagem_bandeira FROM `tb_pais_vinho` WHERE status_pais = 1 ORDER BY nome_pais ASC";
                return bd.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
