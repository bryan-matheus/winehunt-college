using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TELAS.models;
using MetroFramework;

namespace TELAS
{
    public partial class frmDashboard : Form
    {

        private string _NomeUsuario;
        public string NomeUsuario { get => _NomeUsuario; set => _NomeUsuario = value; }

        public frmDashboard()
        {
            InitializeComponent();   
        }

        private void FecharAplicacao(object o, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Todas as tarefas não salvas, serão perdidas ", "Você quer realmente sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void MinimizarJanela(object o, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void CarregarDashboard(object o, EventArgs e)
        {
            lblMensagem.Text = CarregarMensagem();
            lblNomeFuncionario.Text = NomeUsuario;
        }

        private string CarregarMensagem()
        {
            Bitmap iconBmp;
            DateTime localDate = DateTime.Now;

            if (localDate.TimeOfDay >= TimeSpan.FromHours(5) && localDate.TimeOfDay < TimeSpan.FromHours(12))
            {
                iconBmp = new Bitmap(Properties.Resources.sunrise);
                pbMesssageTurn.Image = iconBmp;

                return "Bom dia,";
            }else if (localDate.TimeOfDay >= TimeSpan.FromHours(12) && localDate.TimeOfDay < TimeSpan.FromHours(18))
            {
                iconBmp = new Bitmap(Properties.Resources.sun);
                pbMesssageTurn.Image = iconBmp;

                return "Boa tarde,";
            }
            else
            {
                iconBmp = new Bitmap(Properties.Resources.moon);
                pbMesssageTurn.Image = iconBmp;

                return "Boa noite,";
            }
        }

        private void AbrirVinhos(object o, EventArgs e)
        {
            Form cadastroVinho = new Vinho.frmCadastrarVinho();
            cadastroVinho.ShowDialog();
        }
        private void AbrirPaises(object o, EventArgs e)
        {
            Form paises = new Pais.frmCadastroPais();
            paises.ShowDialog();
        }
        private void AbrirTipoVinhos(object o, EventArgs e)
        {
            Form tipoVinho = new TipoVinho.frmCadastroTipoVinho();
            tipoVinho.ShowDialog();
        }
        private void AbrirUsuarios(object o, EventArgs e)
        {
            Form usuarios = new Usuario.frmCadastroUsuario();
            usuarios.ShowDialog();
        }
        private void AbrirTipoPagamento(object o, EventArgs e)
        {
            Form tipoPagamento = new TipoPagamento.frmCadastroTipoPagamento();
            tipoPagamento.ShowDialog();
        }
    }
}
