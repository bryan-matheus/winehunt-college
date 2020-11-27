namespace TELAS
{
    partial class frmDashboard
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pbMesssageTurn = new System.Windows.Forms.PictureBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbrirPaises = new System.Windows.Forms.Button();
            this.btnAbrirTiposPagemento = new System.Windows.Forms.Button();
            this.btnAbrirUsers = new System.Windows.Forms.Button();
            this.btnAbrirTipoVinho = new System.Windows.Forms.Button();
            this.btnAbrirVinhos = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesssageTurn)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.pnHeader.Controls.Add(this.pbMesssageTurn);
            this.pnHeader.Controls.Add(this.lblMensagem);
            this.pnHeader.Controls.Add(this.lblNomeFuncionario);
            this.pnHeader.Controls.Add(this.btnMinimizar);
            this.pnHeader.Controls.Add(this.btnFechar);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(856, 144);
            this.pnHeader.TabIndex = 7;
            // 
            // pbMesssageTurn
            // 
            this.pbMesssageTurn.Location = new System.Drawing.Point(34, 80);
            this.pbMesssageTurn.Margin = new System.Windows.Forms.Padding(0);
            this.pbMesssageTurn.Name = "pbMesssageTurn";
            this.pbMesssageTurn.Size = new System.Drawing.Size(20, 20);
            this.pbMesssageTurn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMesssageTurn.TabIndex = 8;
            this.pbMesssageTurn.TabStop = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMensagem.ForeColor = System.Drawing.Color.White;
            this.lblMensagem.Location = new System.Drawing.Point(61, 81);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(71, 19);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Boa tarde,";
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblNomeFuncionario.Location = new System.Drawing.Point(29, 103);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(214, 25);
            this.lblNomeFuncionario.TabIndex = 7;
            this.lblNomeFuncionario.Text = "{NOME_FUNCIONÁRIO}";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::TELAS.Properties.Resources.minus;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(742, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(54, 23);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.MinimizarJanela);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackgroundImage = global::TELAS.Properties.Resources.x;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(801, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(54, 23);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.FecharAplicacao);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnAbrirPaises);
            this.panel1.Controls.Add(this.btnAbrirTiposPagemento);
            this.panel1.Controls.Add(this.btnAbrirUsers);
            this.panel1.Controls.Add(this.btnAbrirTipoVinho);
            this.panel1.Controls.Add(this.btnAbrirVinhos);
            this.panel1.Location = new System.Drawing.Point(199, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(28, 0, 28, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 445);
            this.panel1.TabIndex = 9;
            // 
            // btnAbrirPaises
            // 
            this.btnAbrirPaises.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbrirPaises.BackgroundImage = global::TELAS.Properties.Resources.waving_flag;
            this.btnAbrirPaises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirPaises.FlatAppearance.BorderSize = 0;
            this.btnAbrirPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirPaises.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbrirPaises.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAbrirPaises.Location = new System.Drawing.Point(280, 3);
            this.btnAbrirPaises.Name = "btnAbrirPaises";
            this.btnAbrirPaises.Size = new System.Drawing.Size(152, 181);
            this.btnAbrirPaises.TabIndex = 2;
            this.btnAbrirPaises.Text = "Paises";
            this.btnAbrirPaises.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirPaises.UseVisualStyleBackColor = true;
            this.btnAbrirPaises.Click += new System.EventHandler(this.AbrirPaises);
            // 
            // btnAbrirTiposPagemento
            // 
            this.btnAbrirTiposPagemento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAbrirTiposPagemento.BackgroundImage = global::TELAS.Properties.Resources.credit_card;
            this.btnAbrirTiposPagemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirTiposPagemento.FlatAppearance.BorderSize = 0;
            this.btnAbrirTiposPagemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirTiposPagemento.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbrirTiposPagemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAbrirTiposPagemento.Location = new System.Drawing.Point(280, 254);
            this.btnAbrirTiposPagemento.Name = "btnAbrirTiposPagemento";
            this.btnAbrirTiposPagemento.Size = new System.Drawing.Size(152, 181);
            this.btnAbrirTiposPagemento.TabIndex = 5;
            this.btnAbrirTiposPagemento.Text = "Tipos de pagamento";
            this.btnAbrirTiposPagemento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirTiposPagemento.UseVisualStyleBackColor = true;
            this.btnAbrirTiposPagemento.Click += new System.EventHandler(this.AbrirTipoPagamento);
            // 
            // btnAbrirUsers
            // 
            this.btnAbrirUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAbrirUsers.BackgroundImage = global::TELAS.Properties.Resources.users;
            this.btnAbrirUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirUsers.FlatAppearance.BorderSize = 0;
            this.btnAbrirUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbrirUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAbrirUsers.Location = new System.Drawing.Point(26, 254);
            this.btnAbrirUsers.Name = "btnAbrirUsers";
            this.btnAbrirUsers.Size = new System.Drawing.Size(152, 181);
            this.btnAbrirUsers.TabIndex = 3;
            this.btnAbrirUsers.Text = "Usuarios";
            this.btnAbrirUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirUsers.UseVisualStyleBackColor = true;
            this.btnAbrirUsers.Click += new System.EventHandler(this.AbrirUsuarios);
            // 
            // btnAbrirTipoVinho
            // 
            this.btnAbrirTipoVinho.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirTipoVinho.BackgroundImage = global::TELAS.Properties.Resources.bottle;
            this.btnAbrirTipoVinho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirTipoVinho.FlatAppearance.BorderSize = 0;
            this.btnAbrirTipoVinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirTipoVinho.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbrirTipoVinho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAbrirTipoVinho.Location = new System.Drawing.Point(155, 128);
            this.btnAbrirTipoVinho.Name = "btnAbrirTipoVinho";
            this.btnAbrirTipoVinho.Size = new System.Drawing.Size(152, 181);
            this.btnAbrirTipoVinho.TabIndex = 1;
            this.btnAbrirTipoVinho.Text = "Tipos de vinho";
            this.btnAbrirTipoVinho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirTipoVinho.UseVisualStyleBackColor = true;
            this.btnAbrirTipoVinho.Click += new System.EventHandler(this.AbrirTipoVinhos);
            // 
            // btnAbrirVinhos
            // 
            this.btnAbrirVinhos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAbrirVinhos.BackgroundImage = global::TELAS.Properties.Resources.wine;
            this.btnAbrirVinhos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbrirVinhos.FlatAppearance.BorderSize = 0;
            this.btnAbrirVinhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirVinhos.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAbrirVinhos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnAbrirVinhos.Location = new System.Drawing.Point(26, 3);
            this.btnAbrirVinhos.Name = "btnAbrirVinhos";
            this.btnAbrirVinhos.Size = new System.Drawing.Size(152, 181);
            this.btnAbrirVinhos.TabIndex = 0;
            this.btnAbrirVinhos.Text = "Vinhos";
            this.btnAbrirVinhos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAbrirVinhos.UseVisualStyleBackColor = true;
            this.btnAbrirVinhos.Click += new System.EventHandler(this.AbrirVinhos);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 144);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 445);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(856, 589);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CarregarDashboard);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMesssageTurn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Button btnAbrirUsers;
        private System.Windows.Forms.Button btnAbrirTiposPagemento;
        private System.Windows.Forms.Button btnAbrirVinhos;
        private System.Windows.Forms.Button btnAbrirTipoVinho;
        private System.Windows.Forms.Button btnAbrirPaises;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbMesssageTurn;
    }
}