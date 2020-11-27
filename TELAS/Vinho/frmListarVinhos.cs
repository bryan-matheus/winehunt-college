using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using TELAS.models;

namespace TELAS.Vinho
{
    public partial class frmListarVinhos : frmModel
    {
        public frmListarVinhos()
        {
            InitializeComponent();
        }
        private void Pesquisar(Object o, EventArgs e)
        {
            try
            {
                BLL.Vinho vinho = new BLL.Vinho();
                dgvVinhos.DataSource = vinho.Listar(txtPesquisa.Text).Tables[0];
                DefineCells();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(null, ex.Message, "Winehunt", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void DefineCells()
        {
            dgvVinhos.Columns[0].HeaderText = "ID";
            dgvVinhos.Columns[1].HeaderText = "Vinho";
            dgvVinhos.Columns[2].HeaderText = "Descrição";
            dgvVinhos.Columns[3].HeaderText = "Produtor";
            dgvVinhos.Columns[4].HeaderText = "Temperatura";
            dgvVinhos.Columns[5].HeaderText = "Garrafa";
            dgvVinhos.Columns[6].HeaderText = "Preço";
            dgvVinhos.Columns[7].HeaderText = "Teor Alcool";
            dgvVinhos.Columns[9].HeaderText = "País";
            dgvVinhos.Columns[10].HeaderText = "Tipo";
            dgvVinhos.Select();
        }
        private void CarregarFormulario(object o, EventArgs  e)
        {
            try
            {
                BLL.Vinho vinho = new BLL.Vinho();
                dgvVinhos.DataSource = vinho.Listar("").Tables[0];
                DefineCells();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(null, ex.Message, "Winehunt", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void linkVoltar_Click(object o, EventArgs e)
        {
            this.Close();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Todos os dados serão excluidos", "Você quer realmente excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                BLL.Vinho vinho = new BLL.Vinho();
                vinho.Excluir(Convert.ToInt32(dgvVinhos.SelectedRows[0].Cells[0].Value));
                dgvVinhos.DataSource = vinho.Listar("").Tables[0];
            }
        }
    }
}
