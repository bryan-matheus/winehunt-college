namespace TELAS.Vinho
{
    partial class frmCadastrarVinho
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarVinho));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbImagemVinho = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLinkImagemVinho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeVinho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTemperaturaServico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTeorAlcoolico = new System.Windows.Forms.TextBox();
            this.cboPaisVinho = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbImagemPais = new System.Windows.Forms.PictureBox();
            this.btnCadastrarVinho = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdutorVinho = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lkVinhosCadastrados = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.cboTipoVinho = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTamanhoGarrafa = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecoVinho = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemVinho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.Location = new System.Drawing.Point(844, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro de vinho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(835, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "%";
            // 
            // pbImagemVinho
            // 
            this.pbImagemVinho.Image = global::TELAS.Properties.Resources.no_image;
            this.pbImagemVinho.InitialImage = global::TELAS.Properties.Resources.wine_bottle;
            this.pbImagemVinho.Location = new System.Drawing.Point(30, 90);
            this.pbImagemVinho.Name = "pbImagemVinho";
            this.pbImagemVinho.Size = new System.Drawing.Size(336, 524);
            this.pbImagemVinho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagemVinho.TabIndex = 9;
            this.pbImagemVinho.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(385, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Link da imagem do vinho";
            // 
            // txtLinkImagemVinho
            // 
            this.txtLinkImagemVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtLinkImagemVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtLinkImagemVinho.Location = new System.Drawing.Point(389, 189);
            this.txtLinkImagemVinho.Name = "txtLinkImagemVinho";
            this.txtLinkImagemVinho.Size = new System.Drawing.Size(473, 29);
            this.txtLinkImagemVinho.TabIndex = 10;
            this.txtLinkImagemVinho.Leave += new System.EventHandler(this.CarregarImagemVinho);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(385, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome do vinho";
            // 
            // txtNomeVinho
            // 
            this.txtNomeVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtNomeVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtNomeVinho.Location = new System.Drawing.Point(389, 257);
            this.txtNomeVinho.Name = "txtNomeVinho";
            this.txtNomeVinho.Size = new System.Drawing.Size(261, 29);
            this.txtNomeVinho.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(385, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Adicione uma descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtDescricao.Location = new System.Drawing.Point(389, 320);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(473, 48);
            this.txtDescricao.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.Location = new System.Drawing.Point(532, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Temp. Serviço";
            // 
            // txtTemperaturaServico
            // 
            this.txtTemperaturaServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtTemperaturaServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtTemperaturaServico.Location = new System.Drawing.Point(536, 474);
            this.txtTemperaturaServico.Name = "txtTemperaturaServico";
            this.txtTemperaturaServico.Size = new System.Drawing.Size(101, 29);
            this.txtTemperaturaServico.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(756, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teor Alcoolico";
            // 
            // txtTeorAlcoolico
            // 
            this.txtTeorAlcoolico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtTeorAlcoolico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtTeorAlcoolico.Location = new System.Drawing.Point(760, 474);
            this.txtTeorAlcoolico.Name = "txtTeorAlcoolico";
            this.txtTeorAlcoolico.Size = new System.Drawing.Size(75, 29);
            this.txtTeorAlcoolico.TabIndex = 10;
            this.txtTeorAlcoolico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboPaisVinho
            // 
            this.cboPaisVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.cboPaisVinho.FormattingEnabled = true;
            this.cboPaisVinho.Location = new System.Drawing.Point(680, 405);
            this.cboPaisVinho.Name = "cboPaisVinho";
            this.cboPaisVinho.Size = new System.Drawing.Size(182, 29);
            this.cboPaisVinho.TabIndex = 11;
            this.cboPaisVinho.SelectedValueChanged += new System.EventHandler(this.CarregarImagemPais);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label8.Location = new System.Drawing.Point(676, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "De qual país?";
            // 
            // pbImagemPais
            // 
            this.pbImagemPais.Image = global::TELAS.Properties.Resources.flag;
            this.pbImagemPais.Location = new System.Drawing.Point(798, 90);
            this.pbImagemPais.Name = "pbImagemPais";
            this.pbImagemPais.Size = new System.Drawing.Size(64, 64);
            this.pbImagemPais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImagemPais.TabIndex = 9;
            this.pbImagemPais.TabStop = false;
            // 
            // btnCadastrarVinho
            // 
            this.btnCadastrarVinho.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarVinho.FlatAppearance.BorderSize = 0;
            this.btnCadastrarVinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarVinho.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnCadastrarVinho.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarVinho.Location = new System.Drawing.Point(389, 560);
            this.btnCadastrarVinho.Name = "btnCadastrarVinho";
            this.btnCadastrarVinho.Size = new System.Drawing.Size(211, 52);
            this.btnCadastrarVinho.TabIndex = 12;
            this.btnCadastrarVinho.Text = "Cadastrar vinho";
            this.btnCadastrarVinho.UseVisualStyleBackColor = false;
            this.btnCadastrarVinho.Click += new System.EventHandler(this.InserirDados);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label9.Location = new System.Drawing.Point(385, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Produtor";
            // 
            // txtProdutorVinho
            // 
            this.txtProdutorVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtProdutorVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtProdutorVinho.Location = new System.Drawing.Point(389, 405);
            this.txtProdutorVinho.Name = "txtProdutorVinho";
            this.txtProdutorVinho.Size = new System.Drawing.Size(248, 29);
            this.txtProdutorVinho.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label10.Location = new System.Drawing.Point(26, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Aqui você pode cadastrar os vinhos";
            // 
            // lkVinhosCadastrados
            // 
            this.lkVinhosCadastrados.AutoSize = true;
            this.lkVinhosCadastrados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.lkVinhosCadastrados.Location = new System.Drawing.Point(643, 576);
            this.lkVinhosCadastrados.Name = "lkVinhosCadastrados";
            this.lkVinhosCadastrados.Size = new System.Drawing.Size(192, 21);
            this.lkVinhosCadastrados.TabIndex = 13;
            this.lkVinhosCadastrados.TabStop = true;
            this.lkVinhosCadastrados.Text = "Ir para vinhos cadastrados";
            this.lkVinhosCadastrados.Click += new System.EventHandler(this.AbrirListarVinhos);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label11.Location = new System.Drawing.Point(389, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tipo de vinho";
            // 
            // cboTipoVinho
            // 
            this.cboTipoVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.cboTipoVinho.FormattingEnabled = true;
            this.cboTipoVinho.Location = new System.Drawing.Point(389, 474);
            this.cboTipoVinho.Name = "cboTipoVinho";
            this.cboTipoVinho.Size = new System.Drawing.Size(123, 29);
            this.cboTipoVinho.TabIndex = 11;
            this.cboTipoVinho.Text = "Escolha o tipo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label12.Location = new System.Drawing.Point(720, 477);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 21);
            this.label12.TabIndex = 8;
            this.label12.Text = "ml";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label13.Location = new System.Drawing.Point(658, 450);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Garrafa";
            // 
            // txtTamanhoGarrafa
            // 
            this.txtTamanhoGarrafa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtTamanhoGarrafa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtTamanhoGarrafa.Location = new System.Drawing.Point(662, 474);
            this.txtTamanhoGarrafa.Name = "txtTamanhoGarrafa";
            this.txtTamanhoGarrafa.Size = new System.Drawing.Size(58, 29);
            this.txtTamanhoGarrafa.TabIndex = 10;
            this.txtTamanhoGarrafa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label14.Location = new System.Drawing.Point(707, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Preço";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label15.Location = new System.Drawing.Point(685, 260);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 21);
            this.label15.TabIndex = 8;
            this.label15.Text = "R$";
            // 
            // txtPrecoVinho
            // 
            this.txtPrecoVinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.txtPrecoVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txtPrecoVinho.Location = new System.Drawing.Point(711, 257);
            this.txtPrecoVinho.Name = "txtPrecoVinho";
            this.txtPrecoVinho.Size = new System.Drawing.Size(151, 29);
            this.txtPrecoVinho.TabIndex = 10;
            // 
            // frmCadastrarVinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 642);
            this.Controls.Add(this.lkVinhosCadastrados);
            this.Controls.Add(this.btnCadastrarVinho);
            this.Controls.Add(this.cboTipoVinho);
            this.Controls.Add(this.cboPaisVinho);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtTamanhoGarrafa);
            this.Controls.Add(this.txtTeorAlcoolico);
            this.Controls.Add(this.txtTemperaturaServico);
            this.Controls.Add(this.txtProdutorVinho);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPrecoVinho);
            this.Controls.Add(this.txtNomeVinho);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLinkImagemVinho);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImagemPais);
            this.Controls.Add(this.pbImagemVinho);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmCadastrarVinho";
            this.Text = "frmCadastrarVinho";
            this.Load += new System.EventHandler(this.CarregarFormulario);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.pbImagemVinho, 0);
            this.Controls.SetChildIndex(this.pbImagemPais, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.txtLinkImagemVinho, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label11, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtNomeVinho, 0);
            this.Controls.SetChildIndex(this.txtPrecoVinho, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.txtProdutorVinho, 0);
            this.Controls.SetChildIndex(this.txtTemperaturaServico, 0);
            this.Controls.SetChildIndex(this.txtTeorAlcoolico, 0);
            this.Controls.SetChildIndex(this.txtTamanhoGarrafa, 0);
            this.Controls.SetChildIndex(this.txtDescricao, 0);
            this.Controls.SetChildIndex(this.cboPaisVinho, 0);
            this.Controls.SetChildIndex(this.cboTipoVinho, 0);
            this.Controls.SetChildIndex(this.btnCadastrarVinho, 0);
            this.Controls.SetChildIndex(this.lkVinhosCadastrados, 0);
            this.Controls.SetChildIndex(this.btnFechar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemVinho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbImagemVinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLinkImagemVinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeVinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTemperaturaServico;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTeorAlcoolico;
        private System.Windows.Forms.ComboBox cboPaisVinho;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbImagemPais;
        private System.Windows.Forms.Button btnCadastrarVinho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProdutorVinho;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lkVinhosCadastrados;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTipoVinho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTamanhoGarrafa;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrecoVinho;
    }
}