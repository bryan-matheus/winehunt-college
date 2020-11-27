using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TipoVinho
    {
        private int _IdTipoVinho;
        private string _DescricaoTipoVinho;
        private bool _StatusTipoVinho;

        public int IdTipoVinho { get => _IdTipoVinho; set => _IdTipoVinho = value; }
        public string DescricaoTipoVinho { get => _DescricaoTipoVinho; set => _DescricaoTipoVinho = value; }
        public bool StatusTipoVinho { get => _StatusTipoVinho; set => _StatusTipoVinho = value; }


        ADO.ManipularBD bd = new ADO.ManipularBD();
        private static string instrucaoSql;

        public DataSet ListarTiposDeVinho()
        {
            try
            {
                instrucaoSql = $"SELECT id_tipo_vinho, descricao_tipo_vinho, status_tipo_vinho FROM tb_tipo_vinho WHERE status_tipo_vinho = 1 ORDER BY descricao_tipo_vinho ASC";
                return bd.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
