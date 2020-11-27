using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TELAS
{
    public partial class frmLogin : Form
    {
        MySqlDataReader dr;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void FecharAplicacao(object o, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizarJanela(object o, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private int _IdUsuario;
        private void Logar(Object o, EventArgs e)
        {
            try
            {
                BLL.Usuario usuario = new BLL.Usuario
                {
                    Nickname = txtNickname.Text.Trim().ToLower(),
                    Senha = txtSenha.Text
                };

                 _IdUsuario = usuario.LogarRecuperarCodigo();
                dr = usuario.RetornaNome(_IdUsuario);
                dr.Read();
                if (_IdUsuario != 0)
                {
                    usuario.IdUsuario = _IdUsuario;
                    frmDashboard dashboard = new frmDashboard
                    {
                        NomeUsuario = dr["nome"].ToString()
                    };
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                    lblError.Text = "Usuário ou senha incorretos. Tente novamente!";
                    txtSenha.Clear();
                    txtNickname.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, ex.Message, "WINEHUNT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
