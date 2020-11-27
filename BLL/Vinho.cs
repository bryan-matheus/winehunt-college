using System;
using System.Data;
using MySql.Data.MySqlClient;


namespace BLL
{
    public class Vinho
    {
        
        private int _IdVinho;
        private string _ImagemVinho;
        private string _NomeVinho;
        private string _DescricaoVinho;
        private string _NomeProdutor;
        private string _TemperaturaServico;
        private double _TamanhoGarrafa;
        private double _TeorAlcoolico;
        private double _PrecoVinho;
        private byte _StatusVinho;
        private int _TipoVinhoId;
        private int _PaisVinhoId;

        public int IdVinho { get => _IdVinho; set => _IdVinho = value; }
        public string NomeVinho { get => _NomeVinho; set => _NomeVinho = value; }
        public string ImagemVinho { get => _ImagemVinho; set => _ImagemVinho = value; }
        public string DescricaoVinho { get => _DescricaoVinho; set => _DescricaoVinho = value; }
        public string NomeProdutor { get => _NomeProdutor; set => _NomeProdutor = value; }
        public string TemperaturaServico { get => _TemperaturaServico; set => _TemperaturaServico = value; }
        public double TamanhoGarrafa { get => _TamanhoGarrafa; set => _TamanhoGarrafa = value; }
        public double TeorAlcoolico { get => _TeorAlcoolico; set => _TeorAlcoolico = value; }
        public double PrecoVinho { get => _PrecoVinho; set => _PrecoVinho = value; }
        public byte StatusVinho { get => _StatusVinho; set => _StatusVinho = value; }
        public int TipoVinhoId { get => _TipoVinhoId; set => _TipoVinhoId = value; }
        public int PaisVinhoId { get => _PaisVinhoId; set => _PaisVinhoId = value; }

        private ADO.ManipularBD bd = new ADO.ManipularBD();

        private static string instrucaoSql;
        public DataSet Listar(string parteNome)
        {
            try
            {
                if (string.IsNullOrEmpty(parteNome))
                {
                    instrucaoSql = $"SELECT id_vinho,nome_vinho,descricao_vinho,nome_produtor,temperatura_servico,tamanho_garrafa,preco_vinho,teor_alcoolico,nome_pais,descricao_tipo_vinho FROM tb_vinho AS vinho INNER JOIN tb_pais_vinho AS pais ON vinho.pais_vinho_id = pais.id_pais_vinho INNER JOIN tb_tipo_vinho AS tipo ON vinho.tipo_vinho_id = tipo.id_tipo_vinho WHERE status_vinho = 1";
                }
                else
                {
                    instrucaoSql = $"SELECT id_vinho,nome_vinho,descricao_vinho,nome_produtor,temperatura_servico,tamanho_garrafa,preco_vinho,teor_alcoolico,nome_pais,descricao_tipo_vinho FROM tb_vinho AS vinho INNER JOIN tb_pais_vinho AS pais ON vinho.pais_vinho_id = pais.id_pais_vinho INNER JOIN tb_tipo_vinho AS tipo ON vinho.tipo_vinho_id = tipo.id_tipo_vinho WHERE nome_vinho LIKE '%{parteNome}%' AND status_vinho = 1";
                }
                return bd.RetornarDataSet(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IncluirVinho()
        {
            try
            {
                MySqlParameter[] listaDeParametros = {
                            new MySqlParameter("@nome_vinho", MySqlDbType.VarChar) { Value = NomeVinho },
                            new MySqlParameter("@descricao_vinho", MySqlDbType.VarChar) { Value = DescricaoVinho },
                            new MySqlParameter("@nome_produtor", MySqlDbType.VarChar) { Value = NomeProdutor },
                            new MySqlParameter("@preco_vinho", MySqlDbType.Decimal) { Value =  PrecoVinho },
                            new MySqlParameter("@temperatura_servico", MySqlDbType.VarChar) { Value = TemperaturaServico },
                            new MySqlParameter("@tamanho_garrafa", MySqlDbType.Decimal) { Value = TamanhoGarrafa },
                            new MySqlParameter("@teor_alcoolico", MySqlDbType.Decimal) { Value = TeorAlcoolico },
                            new MySqlParameter("@status_vinho", MySqlDbType.Bit) { Value = StatusVinho },
                            new MySqlParameter("@tipo_vinho_id", MySqlDbType.Int32) { Value = TipoVinhoId },
                            new MySqlParameter("@pais_vinho_id", MySqlDbType.Int32) { Value = PaisVinhoId }
                    };
                string comandoSql = "INSERT INTO tb_vinho (nome_vinho, descricao_vinho, nome_produtor, temperatura_servico, tamanho_garrafa, preco_vinhO, status_vinho, tipo_vinho_id, pais_vinho_id, teor_alcoolico) VALUES (@nome_vinho, @descricao_vinho, @nome_produtor, @temperatura_servico, @tamanho_garrafa, @preco_vinhO, @status_vinho, @tipo_vinho_id, @pais_vinho_id, @teor_alcoolico)";
                bd.ExecutarComandoParametro(comandoSql, listaDeParametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                instrucaoSql = $"UPDATE tb_vinho SET status_vinho = 0 WHERE id_vinho = '{id}'";
                bd.ExecutarComando(instrucaoSql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
