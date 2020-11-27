using MetroFramework;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TELAS.Vinho
{
    public partial class frmCadastrarVinho : models.frmModel
    {
        public frmCadastrarVinho()
        {
            InitializeComponent();
        }

        MySqlDataReader dr;
        private void CarregarFormulario(object o, EventArgs e)
        {
            CarregarComboPais();
            CarregarComboTipoVinho();

            cboPaisVinho.SelectedIndex = -1;
            cboPaisVinho.Text = "Escolha o país";
            cboTipoVinho.SelectedIndex = -1;
            cboTipoVinho.Text = "Escolha o tipo";

            Bitmap iconBmp = new Bitmap(Properties.Resources.flag);
            pbImagemPais.Image = iconBmp;
        }
        private void CarregarImagemVinho(object o, EventArgs e)
        {
            try
            {
                WebRequest request;
                if (Uri.IsWellFormedUriString(txtLinkImagemVinho.Text, UriKind.RelativeOrAbsolute))
                { 
                    request = WebRequest.Create(txtLinkImagemVinho.Text);
                    using (var response = request.GetResponse())
                    {
                        using (var str = response.GetResponseStream())
                        {
                            pbImagemVinho.SizeMode = PictureBoxSizeMode.Zoom;
                            pbImagemVinho.Image = Bitmap.FromStream(str);
                        }
                    }
                }
                else
                {
                    txtLinkImagemVinho.Clear();
                }
            }
            catch (Exception)
            {
                txtLinkImagemVinho.Clear();
            }
        }
        private void CarregarImagemPais(object o, EventArgs e)
        {

            try
            {
                BLL.PaisVinho paisVinho = new BLL.PaisVinho();
                dr = paisVinho.ListarPais(Convert.ToInt32(cboPaisVinho.SelectedValue));
                dr.Read();
                WebRequest request;
                request = WebRequest.Create(dr["imagem_bandeira"].ToString());
                using (var response = request.GetResponse())
                {
                    using (var str = response.GetResponseStream())
                    {
                        pbImagemPais.SizeMode = PictureBoxSizeMode.Normal;
                        pbImagemPais.Image = Image.FromStream(str);
                    }
                }
                
            }
            catch (Exception)
            {
                txtLinkImagemVinho.Clear();
            }
            
        }
        private void CarregarComboPais()
        {
            try
            {
                BLL.PaisVinho paisVinho = new BLL.PaisVinho();
                cboPaisVinho.DataSource = null;
                cboPaisVinho.DataSource = paisVinho.ListarPaises().Tables[0];
                cboPaisVinho.ValueMember = "id_pais_vinho";
                cboPaisVinho.DisplayMember = "nome_pais";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(cboPaisVinho, "Houveram erros na consulta dos paises.", "Winehunt", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void CarregarComboTipoVinho()
        {
            try
            {
                BLL.TipoVinho tipoVinho = new BLL.TipoVinho();
                cboTipoVinho.DataSource = null;
                cboTipoVinho.DataSource = tipoVinho.ListarTiposDeVinho(). Tables[0];
                cboTipoVinho.ValueMember = "id_tipo_vinho";
                cboTipoVinho.DisplayMember = "descricao_tipo_vinho";
            }
            catch (Exception)
            {
                MetroMessageBox.Show(cboTipoVinho, "Houveram erros na consulta dos paises.", "Winehunt", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private bool isWithErrors()
        {
            if (string.IsNullOrEmpty(txtLinkImagemVinho.Text))
            {
                errorProvider.SetError(txtLinkImagemVinho, "Link da imagem do vinho não pode ficar vazio");
                return true;
            }
            else if (string.IsNullOrEmpty(txtNomeVinho.Text))
            {
                errorProvider.SetError(txtNomeVinho, "O vinho não pode ficar sem nome");
                return true;
            }
            else if (string.IsNullOrEmpty(txtProdutorVinho.Text))
            {
                errorProvider.SetError(txtProdutorVinho, "O vinho precisa ter um produtor");
                return true;
            }
            else if (string.IsNullOrEmpty(txtTamanhoGarrafa.Text))
            {
                errorProvider.SetError(txtTamanhoGarrafa, "O vinho precisa ter um produtor");
                return true;
            }
            else if (string.IsNullOrEmpty(txtTamanhoGarrafa.Text))
            {
                errorProvider.SetError(txtTamanhoGarrafa, "É necessário informar o tamanho da garrafa em ml");
                return true;
            }
            else if (string.IsNullOrEmpty(txtTemperaturaServico.Text))
            {
                errorProvider.SetError(txtTemperaturaServico, "É necessário informar o temperatura de serviço do vinho");
                return true;
            }
            else if (string.IsNullOrEmpty(txtTeorAlcoolico.Text))
            {
                errorProvider.SetError(txtTeorAlcoolico, "É necessário informar o teor alcoolico do vinho");
                return true;
            }
            else
            {
                errorProvider.Clear();
                return false;
            }
            
        }

        private void LimparCampos()
        {
            txtLinkImagemVinho.Text = "";
            txtNomeVinho.Text = "";
            txtProdutorVinho.Text = "";
            txtDescricao.Text = "";
            txtPrecoVinho.Text = "";
            txtNomeVinho.Text = "";
            txtTamanhoGarrafa.Text = "";
            txtTemperaturaServico.Text = "";
            txtTeorAlcoolico.Text = "";

            cboPaisVinho.SelectedIndex = -1;
            cboPaisVinho.Text = "Escolha o país";
            cboTipoVinho.SelectedIndex = -1;
            cboTipoVinho.Text = "Escolha o tipo";
        }

        private void InserirDados(object o, EventArgs e)
        {
            if (!isWithErrors())
            {
                BLL.Vinho vinho = new BLL.Vinho()
                {
                    NomeVinho = txtNomeVinho.Text.Trim(),
                    NomeProdutor = txtProdutorVinho.Text.Trim(),
                    ImagemVinho = txtLinkImagemVinho.Text.Trim(),
                    DescricaoVinho = txtDescricao.Text.Trim(),
                    TamanhoGarrafa = Convert.ToDouble(txtTamanhoGarrafa.Text.Trim()),
                    TemperaturaServico = txtTemperaturaServico.Text.Trim(),
                    TeorAlcoolico = Convert.ToDouble(txtTeorAlcoolico.Text.Trim()),
                    StatusVinho = 1,
                    PrecoVinho = Convert.ToDouble(txtPrecoVinho.Text.Trim()),
                    PaisVinhoId = Convert.ToInt32(cboPaisVinho.SelectedValue),
                    TipoVinhoId = Convert.ToInt32(cboTipoVinho.SelectedValue)
                };
                vinho.IncluirVinho();
                LimparCampos();
                MetroMessageBox.Show(this, "Vinho adicionado com sucesso", "Winehunt", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void  AbrirListarVinhos(object o, EventArgs e)
        {
            Form listarVinhos = new frmListarVinhos();
            listarVinhos.ShowDialog();
        }
    }
}
