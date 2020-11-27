namespace TELAS.Pais
{
    partial class frmCadastroPais
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
            this.mrbDesativado = new MetroFramework.Controls.MetroRadioButton();
            this.mrbAtivo = new MetroFramework.Controls.MetroRadioButton();
            this.txtDescricaoTipoVinho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbImagemBandeira = new System.Windows.Forms.PictureBox();
            this.linkListaPaises = new System.Windows.Forms.LinkLabel();
            this.btnCadastrarVinho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemBandeira)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(464, 0);
            // 
            // mrbDesativado
            // 
            this.mrbDesativado.AutoSize = true;
            this.mrbDesativado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbDesativado.Location = new System.Drawing.Point(108, 341);
            this.mrbDesativado.Name = "mrbDesativado";
            this.mrbDesativado.Size = new System.Drawing.Size(93, 19);
            this.mrbDesativado.TabIndex = 23;
            this.mrbDesativado.Text = "Desativado";
            this.mrbDesativado.UseSelectable = true;
            // 
            // mrbAtivo
            // 
            this.mrbAtivo.AutoSize = true;
            this.mrbAtivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.mrbAtivo.Location = new System.Drawing.Point(32, 341);
            this.mrbAtivo.Name = "mrbAtivo";
            this.mrbAtivo.Size = new System.Drawing.Size(57, 19);
            this.mrbAtivo.TabIndex = 24;
            this.mrbAtivo.Text = "Ativo";
            this.mrbAtivo.UseSelectable = true;
            // 
            // txtDescricaoTipoVinho
            // 
            this.txtDescricaoTipoVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtDescricaoTipoVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtDescricaoTipoVinho.Location = new System.Drawing.Point(32, 184);
            this.txtDescricaoTipoVinho.Name = "txtDescricaoTipoVinho";
            this.txtDescricaoTipoVinho.Size = new System.Drawing.Size(454, 28);
            this.txtDescricaoTipoVinho.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 32);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cadastro de País";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(28, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.Location = new System.Drawing.Point(28, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Link da bandeira do país";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(28, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Nome do País";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.textBox1.Location = new System.Drawing.Point(32, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 28);
            this.textBox1.TabIndex = 22;
            // 
            // pbImagemBandeira
            // 
            this.pbImagemBandeira.Location = new System.Drawing.Point(32, 76);
            this.pbImagemBandeira.Name = "pbImagemBandeira";
            this.pbImagemBandeira.Size = new System.Drawing.Size(116, 68);
            this.pbImagemBandeira.TabIndex = 25;
            this.pbImagemBandeira.TabStop = false;
            // 
            // linkListaPaises
            // 
            this.linkListaPaises.AutoSize = true;
            this.linkListaPaises.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.linkListaPaises.Location = new System.Drawing.Point(316, 405);
            this.linkListaPaises.Name = "linkListaPaises";
            this.linkListaPaises.Size = new System.Drawing.Size(117, 21);
            this.linkListaPaises.TabIndex = 26;
            this.linkListaPaises.TabStop = true;
            this.linkListaPaises.Text = "Ver mais países";
            // 
            // btnCadastrarVinho
            // 
            this.btnCadastrarVinho.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarVinho.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVinho.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCadastrarVinho.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVinho.Location = new System.Drawing.Point(32, 389);
            this.btnCadastrarVinho.Name = "btnCadastrarVinho";
            this.btnCadastrarVinho.Size = new System.Drawing.Size(211, 52);
            this.btnCadastrarVinho.TabIndex = 27;
            this.btnCadastrarVinho.Text = "Cadastrar país";
            this.btnCadastrarVinho.UseVisualStyleBackColor = false;
            // 
            // frmCadastroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 469);
            this.Controls.Add(this.btnCadastrarVinho);
            this.Controls.Add(this.linkListaPaises);
            this.Controls.Add(this.pbImagemBandeira);
            this.Controls.Add(this.mrbDesativado);
            this.Controls.Add(this.mrbAtivo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtDescricaoTipoVinho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroPais";
            this.Text = "frmCadastroPais";
            this.Controls.SetChildIndex(this.btnFechar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtDescricaoTipoVinho, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.mrbAtivo, 0);
            this.Controls.SetChildIndex(this.mrbDesativado, 0);
            this.Controls.SetChildIndex(this.pbImagemBandeira, 0);
            this.Controls.SetChildIndex(this.linkListaPaises, 0);
            this.Controls.SetChildIndex(this.btnCadastrarVinho, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemBandeira)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroRadioButton mrbDesativado;
        private MetroFramework.Controls.MetroRadioButton mrbAtivo;
        private System.Windows.Forms.TextBox txtDescricaoTipoVinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pbImagemBandeira;
        private System.Windows.Forms.LinkLabel linkListaPaises;
        private System.Windows.Forms.Button btnCadastrarVinho;
    }
}