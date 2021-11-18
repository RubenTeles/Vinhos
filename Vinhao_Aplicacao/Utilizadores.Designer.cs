namespace Vinhao_Aplicacao
{
    partial class Utilizadores
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxDescricao = new System.Windows.Forms.TextBox();
            this.TxNomeUtilizador = new System.Windows.Forms.TextBox();
            this.BtEditar = new System.Windows.Forms.Button();
            this.BtBloquear = new System.Windows.Forms.Button();
            this.TxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridUtilizadores = new System.Windows.Forms.DataGridView();
            this.btUtilizadoresBloqueados = new System.Windows.Forms.Button();
            this.btUtilizadores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DataNascimento = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtilizadores)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(304, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 44);
            this.label4.TabIndex = 8;
            this.label4.Text = "Utilizadores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(431, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(457, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // TxDescricao
            // 
            this.TxDescricao.Location = new System.Drawing.Point(512, 284);
            this.TxDescricao.Multiline = true;
            this.TxDescricao.Name = "TxDescricao";
            this.TxDescricao.Size = new System.Drawing.Size(307, 98);
            this.TxDescricao.TabIndex = 4;
            // 
            // TxNomeUtilizador
            // 
            this.TxNomeUtilizador.Location = new System.Drawing.Point(512, 161);
            this.TxNomeUtilizador.Name = "TxNomeUtilizador";
            this.TxNomeUtilizador.Size = new System.Drawing.Size(307, 22);
            this.TxNomeUtilizador.TabIndex = 1;
            // 
            // BtEditar
            // 
            this.BtEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtEditar.Location = new System.Drawing.Point(512, 404);
            this.BtEditar.Name = "BtEditar";
            this.BtEditar.Size = new System.Drawing.Size(85, 25);
            this.BtEditar.TabIndex = 5;
            this.BtEditar.Text = "Editar";
            this.BtEditar.UseVisualStyleBackColor = false;
            this.BtEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // BtBloquear
            // 
            this.BtBloquear.BackColor = System.Drawing.Color.Red;
            this.BtBloquear.Location = new System.Drawing.Point(603, 404);
            this.BtBloquear.Name = "BtBloquear";
            this.BtBloquear.Size = new System.Drawing.Size(109, 25);
            this.BtBloquear.TabIndex = 6;
            this.BtBloquear.Text = "Bloquear";
            this.BtBloquear.UseVisualStyleBackColor = false;
            this.BtBloquear.Click += new System.EventHandler(this.BtBloquear_Click);
            // 
            // TxEmail
            // 
            this.TxEmail.Location = new System.Drawing.Point(512, 202);
            this.TxEmail.Name = "TxEmail";
            this.TxEmail.Size = new System.Drawing.Size(307, 22);
            this.TxEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(460, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(244, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(319, 50);
            this.label13.TabIndex = 30;
            this.label13.Text = "                           ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Vinhao_Aplicacao.Properties.Resources.UtilizadorIcon_removebg_preview;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(248, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // gridUtilizadores
            // 
            this.gridUtilizadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUtilizadores.EnableHeadersVisualStyles = false;
            this.gridUtilizadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridUtilizadores.Location = new System.Drawing.Point(42, 132);
            this.gridUtilizadores.Name = "gridUtilizadores";
            this.gridUtilizadores.RowHeadersWidth = 51;
            this.gridUtilizadores.RowTemplate.Height = 24;
            this.gridUtilizadores.Size = new System.Drawing.Size(351, 306);
            this.gridUtilizadores.TabIndex = 52;
            this.gridUtilizadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUtilizadores_CellClick);
            // 
            // btUtilizadoresBloqueados
            // 
            this.btUtilizadoresBloqueados.BackColor = System.Drawing.Color.Tomato;
            this.btUtilizadoresBloqueados.Location = new System.Drawing.Point(169, 97);
            this.btUtilizadoresBloqueados.Name = "btUtilizadoresBloqueados";
            this.btUtilizadoresBloqueados.Size = new System.Drawing.Size(193, 29);
            this.btUtilizadoresBloqueados.TabIndex = 53;
            this.btUtilizadoresBloqueados.Text = "Utilizadores Bloqueados";
            this.btUtilizadoresBloqueados.UseVisualStyleBackColor = false;
            this.btUtilizadoresBloqueados.Click += new System.EventHandler(this.btUtilizadoresBloqueados_Click);
            // 
            // btUtilizadores
            // 
            this.btUtilizadores.BackColor = System.Drawing.Color.LightGreen;
            this.btUtilizadores.Location = new System.Drawing.Point(58, 97);
            this.btUtilizadores.Name = "btUtilizadores";
            this.btUtilizadores.Size = new System.Drawing.Size(105, 29);
            this.btUtilizadores.TabIndex = 53;
            this.btUtilizadores.Text = "Utilizadores";
            this.btUtilizadores.UseVisualStyleBackColor = false;
            this.btUtilizadores.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(424, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nascimento:";
            // 
            // DataNascimento
            // 
            this.DataNascimento.Location = new System.Drawing.Point(512, 242);
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.Size = new System.Drawing.Size(200, 22);
            this.DataNascimento.TabIndex = 56;
            // 
            // Utilizadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources.Utilizadores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 484);
            this.Controls.Add(this.DataNascimento);
            this.Controls.Add(this.btUtilizadores);
            this.Controls.Add(this.btUtilizadoresBloqueados);
            this.Controls.Add(this.gridUtilizadores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtEditar);
            this.Controls.Add(this.BtBloquear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxEmail);
            this.Controls.Add(this.TxDescricao);
            this.Controls.Add(this.TxNomeUtilizador);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Utilizadores";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Utilizadores";
            this.Load += new System.EventHandler(this.Utilizadores_Load);
            this.Leave += new System.EventHandler(this.Utilizadores_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUtilizadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxDescricao;
        private System.Windows.Forms.TextBox TxNomeUtilizador;
        private System.Windows.Forms.Button BtEditar;
        private System.Windows.Forms.Button BtBloquear;
        private System.Windows.Forms.TextBox TxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView gridUtilizadores;
        private System.Windows.Forms.Button btUtilizadoresBloqueados;
        private System.Windows.Forms.Button btUtilizadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DataNascimento;
    }
}