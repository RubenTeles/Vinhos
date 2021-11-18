namespace Vinhao_Aplicacao
{
    partial class Regioes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeRegiao = new System.Windows.Forms.TextBox();
            this.gridRegioes = new System.Windows.Forms.DataGridView();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegioes)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Vinhao_Aplicacao.Properties.Resources._128017211_252368046316241_1101982571927459056_n;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(274, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(340, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 44);
            this.label4.TabIndex = 36;
            this.label4.Text = "Regiões";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(242, 50);
            this.label13.TabIndex = 39;
            this.label13.Text = "                    ";
            // 
            // txtNomeRegiao
            // 
            this.txtNomeRegiao.Location = new System.Drawing.Point(502, 236);
            this.txtNomeRegiao.Name = "txtNomeRegiao";
            this.txtNomeRegiao.Size = new System.Drawing.Size(178, 22);
            this.txtNomeRegiao.TabIndex = 42;
            this.txtNomeRegiao.Text = "Escreva uma nova Região";
            this.txtNomeRegiao.Click += new System.EventHandler(this.txtNomeRegiao_Click);
            // 
            // gridRegioes
            // 
            this.gridRegioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegioes.EnableHeadersVisualStyles = false;
            this.gridRegioes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridRegioes.Location = new System.Drawing.Point(12, 114);
            this.gridRegioes.Name = "gridRegioes";
            this.gridRegioes.RowHeadersWidth = 51;
            this.gridRegioes.RowTemplate.Height = 24;
            this.gridRegioes.Size = new System.Drawing.Size(389, 306);
            this.gridRegioes.TabIndex = 43;
            this.gridRegioes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegioes_CellClick);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditar.Location = new System.Drawing.Point(542, 285);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(86, 23);
            this.btEditar.TabIndex = 45;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Lime;
            this.btAdicionar.Location = new System.Drawing.Point(450, 285);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(86, 23);
            this.btAdicionar.TabIndex = 44;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(634, 285);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 56;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Regioes
            // 
            this.AcceptButton = this.btAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources._123991851_859844078112013_2340023643782309359_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gridRegioes);
            this.Controls.Add(this.txtNomeRegiao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Regioes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Regioes";
            this.Load += new System.EventHandler(this.Regioes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegioes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeRegiao;
        private System.Windows.Forms.DataGridView gridRegioes;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btEliminar;
    }
}