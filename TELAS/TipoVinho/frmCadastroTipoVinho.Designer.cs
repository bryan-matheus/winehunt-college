namespace TELAS.TipoVinho
{
    partial class frmCadastroTipoVinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricaoTipoVinho = new System.Windows.Forms.TextBox();
            this.mrbAtivo = new MetroFramework.Controls.MetroRadioButton();
            this.mrbDesativado = new MetroFramework.Controls.MetroRadioButton();
            this.btnCadastrarTipoPagamento = new System.Windows.Forms.Button();
            this.linkListaTipoPagamentos = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(424, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Descrição do tipo de vinho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(14, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Status ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cadastro de tipo de vinho";
            // 
            // txtDescricaoTipoVinho
            // 
            this.txtDescricaoTipoVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtDescricaoTipoVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtDescricaoTipoVinho.Location = new System.Drawing.Point(18, 125);
            this.txtDescricaoTipoVinho.Name = "txtDescricaoTipoVinho";
            this.txtDescricaoTipoVinho.Size = new System.Drawing.Size(441, 29);
            this.txtDescricaoTipoVinho.TabIndex = 11;
            // 
            // mrbAtivo
            // 
            this.mrbAtivo.AutoSize = true;
            this.mrbAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbAtivo.Location = new System.Drawing.Point(18, 210);
            this.mrbAtivo.Name = "mrbAtivo";
            this.mrbAtivo.Size = new System.Drawing.Size(57, 19);
            this.mrbAtivo.TabIndex = 12;
            this.mrbAtivo.Text = "Ativo";
            this.mrbAtivo.UseSelectable = true;
            // 
            // mrbDesativado
            // 
            this.mrbDesativado.AutoSize = true;
            this.mrbDesativado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDesativado.Location = new System.Drawing.Point(94, 210);
            this.mrbDesativado.Name = "mrbDesativado";
            this.mrbDesativado.Size = new System.Drawing.Size(93, 19);
            this.mrbDesativado.TabIndex = 12;
            this.mrbDesativado.Text = "Desativado";
            this.mrbDesativado.UseSelectable = true;
            // 
            // btnCadastrarTipoPagamento
            // 
            this.btnCadastrarTipoPagamento.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarTipoPagamento.FlatAppearance.BorderSize = 0;
            this.btnCadastrarTipoPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarTipoPagamento.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCadastrarTipoPagamento.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarTipoPagamento.Location = new System.Drawing.Point(12, 261);
            this.btnCadastrarTipoPagamento.Name = "btnCadastrarTipoPagamento";
            this.btnCadastrarTipoPagamento.Size = new System.Drawing.Size(255, 52);
            this.btnCadastrarTipoPagamento.TabIndex = 31;
            this.btnCadastrarTipoPagamento.Text = "Cadastrar tipo de vinho";
            this.btnCadastrarTipoPagamento.UseVisualStyleBackColor = false;
            // 
            // linkListaTipoPagamentos
            // 
            this.linkListaTipoPagamentos.AutoSize = true;
            this.linkListaTipoPagamentos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.linkListaTipoPagamentos.Location = new System.Drawing.Point(287, 277);
            this.linkListaTipoPagamentos.Name = "linkListaTipoPagamentos";
            this.linkListaTipoPagamentos.Size = new System.Drawing.Size(172, 21);
            this.linkListaTipoPagamentos.TabIndex = 30;
            this.linkListaTipoPagamentos.TabStop = true;
            this.linkListaTipoPagamentos.Text = "Ver mais tipos de vinho";
            // 
            // frmCadastroTipoVinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 325);
            this.Controls.Add(this.btnCadastrarTipoPagamento);
            this.Controls.Add(this.linkListaTipoPagamentos);
            this.Controls.Add(this.mrbDesativado);
            this.Controls.Add(this.mrbAtivo);
            this.Controls.Add(this.txtDescricaoTipoVinho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "frmCadastroTipoVinho";
            this.Text = "frmCadastroTipoVinho";
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescricaoTipoVinho, 0);
            this.Controls.SetChildIndex(this.mrbAtivo, 0);
            this.Controls.SetChildIndex(this.mrbDesativado, 0);
            this.Controls.SetChildIndex(this.linkListaTipoPagamentos, 0);
            this.Controls.SetChildIndex(this.btnCadastrarTipoPagamento, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricaoTipoVinho;
        private MetroFramework.Controls.MetroRadioButton mrbAtivo;
        private MetroFramework.Controls.MetroRadioButton mrbDesativado;
        private System.Windows.Forms.Button btnCadastrarTipoPagamento;
        private System.Windows.Forms.LinkLabel linkListaTipoPagamentos;
    }
}