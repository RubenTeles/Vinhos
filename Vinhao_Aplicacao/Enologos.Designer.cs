namespace Vinhao_Aplicacao
{
    partial class Enologos
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
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.gridEnologos = new System.Windows.Forms.DataGridView();
            this.txtNomeEnologo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridEnologos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btEditar.Location = new System.Drawing.Point(571, 286);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(86, 23);
            this.btEditar.TabIndex = 53;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.Lime;
            this.btAdicionar.Location = new System.Drawing.Point(479, 286);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(86, 23);
            this.btAdicionar.TabIndex = 52;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // gridEnologos
            // 
            this.gridEnologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEnologos.EnableHeadersVisualStyles = false;
            this.gridEnologos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gridEnologos.Location = new System.Drawing.Point(41, 119);
            this.gridEnologos.Name = "gridEnologos";
            this.gridEnologos.RowHeadersWidth = 51;
            this.gridEnologos.RowTemplate.Height = 24;
            this.gridEnologos.Size = new System.Drawing.Size(389, 306);
            this.gridEnologos.TabIndex = 51;
            this.gridEnologos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEnologos_CellClick);
            // 
            // txtNomeEnologo
            // 
            this.txtNomeEnologo.Location = new System.Drawing.Point(531, 241);
            this.txtNomeEnologo.Name = "txtNomeEnologo";
            this.txtNomeEnologo.Size = new System.Drawing.Size(178, 22);
            this.txtNomeEnologo.TabIndex = 50;
            this.txtNomeEnologo.Text = "Escreva um novo Enologo";
            this.txtNomeEnologo.Click += new System.EventHandler(this.txtNomeEnologo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(394, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 44);
            this.label4.TabIndex = 47;
            this.label4.Text = "Enologos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Nome:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(319, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 50);
            this.label13.TabIndex = 49;
            this.label13.Text = "                      ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Vinhao_Aplicacao.Properties.Resources.enologo;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(328, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(663, 286);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 56;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // Enologos
            // 
            this.AcceptButton = this.btAdicionar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources.enologo_fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.gridEnologos);
            this.Controls.Add(this.txtNomeEnologo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Enologos";
            this.Text = "Enologo";
            this.Load += new System.EventHandler(this.Enologos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEnologos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridView gridEnologos;
        private System.Windows.Forms.TextBox txtNomeEnologo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btEliminar;
    }
}