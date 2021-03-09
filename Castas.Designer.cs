namespace Vinhao_Aplicacao
{
    partial class Castas
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.txNomeCasta = new System.Windows.Forms.TextBox();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gridCastas = new System.Windows.Forms.DataGridView();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Lime;
            this.btAdicionar.Location = new System.Drawing.Point(513, 405);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(86, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // txNomeCasta
            // 
            this.txNomeCasta.Location = new System.Drawing.Point(513, 145);
            this.txNomeCasta.Name = "txNomeCasta";
            this.txNomeCasta.Size = new System.Drawing.Size(307, 22);
            this.txNomeCasta.TabIndex = 1;
            this.txNomeCasta.Text = "Nome da Casta";
            this.txNomeCasta.Click += new System.EventHandler(this.TxNomeCasta_Click);
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(513, 190);
            this.txDescricao.Multiline = true;
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(307, 190);
            this.txDescricao.TabIndex = 3;
            this.txDescricao.Text = "Região, Produtor, etc...";
            this.txDescricao.Click += new System.EventHandler(this.TxDescricao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(432, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(397, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 44);
            this.label4.TabIndex = 7;
            this.label4.Text = "Castas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(322, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(231, 50);
            this.label13.TabIndex = 29;
            this.label13.Text = "                   ";
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditar.Location = new System.Drawing.Point(605, 405);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(86, 23);
            this.btEditar.TabIndex = 30;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Vinhao_Aplicacao.Properties.Resources.CastasIcon_removebg_preview;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(331, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picVinhao_Click);
            // 
            // gridCastas
            // 
            this.gridCastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCastas.EnableHeadersVisualStyles = false;
            this.gridCastas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridCastas.Location = new System.Drawing.Point(12, 93);
            this.gridCastas.Name = "gridCastas";
            this.gridCastas.RowHeadersWidth = 51;
            this.gridCastas.RowTemplate.Height = 24;
            this.gridCastas.Size = new System.Drawing.Size(389, 352);
            this.gridCastas.TabIndex = 32;
            this.gridCastas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCastas_CellClick);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(697, 405);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 55;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Castas
            // 
            this.AcceptButton = this.btAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources.Castas;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(867, 468);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.gridCastas);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.txNomeCasta);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label13);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Castas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Castas";
            this.Load += new System.EventHandler(this.Castas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCastas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.TextBox txNomeCasta;
        private System.Windows.Forms.TextBox txDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView gridCastas;
        private System.Windows.Forms.Button btEliminar;
    }
}