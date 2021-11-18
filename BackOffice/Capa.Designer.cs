namespace Vinhao_Aplicacao
{
    partial class Capa
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
            this.labelRealizado = new System.Windows.Forms.Label();
            this.picSeta = new System.Windows.Forms.PictureBox();
            this.picVinhao = new System.Windows.Forms.PictureBox();
            this.picClick = new System.Windows.Forms.PictureBox();
            this.btSeta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVinhao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClick)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRealizado
            // 
            this.labelRealizado.AutoSize = true;
            this.labelRealizado.BackColor = System.Drawing.Color.Transparent;
            this.labelRealizado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelRealizado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRealizado.Location = new System.Drawing.Point(159, 602);
            this.labelRealizado.Name = "labelRealizado";
            this.labelRealizado.Size = new System.Drawing.Size(279, 25);
            this.labelRealizado.TabIndex = 7;
            this.labelRealizado.Text = "Realizado por: Ruben Teles";
            this.labelRealizado.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picSeta
            // 
            this.picSeta.BackColor = System.Drawing.Color.Transparent;
            this.picSeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSeta.Image = global::Vinhao_Aplicacao.Properties.Resources.istockphoto_1091691460_170667a_removebg_preview;
            this.picSeta.Location = new System.Drawing.Point(461, 781);
            this.picSeta.Name = "picSeta";
            this.picSeta.Size = new System.Drawing.Size(88, 82);
            this.picSeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSeta.TabIndex = 8;
            this.picSeta.TabStop = false;
            this.picSeta.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picVinhao
            // 
            this.picVinhao.BackColor = System.Drawing.Color.Transparent;
            this.picVinhao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVinhao.Image = global::Vinhao_Aplicacao.Properties.Resources.LogoVinhao;
            this.picVinhao.Location = new System.Drawing.Point(128, 292);
            this.picVinhao.Name = "picVinhao";
            this.picVinhao.Size = new System.Drawing.Size(341, 307);
            this.picVinhao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVinhao.TabIndex = 6;
            this.picVinhao.TabStop = false;
            this.picVinhao.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picClick
            // 
            this.picClick.BackColor = System.Drawing.Color.Transparent;
            this.picClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClick.Location = new System.Drawing.Point(-3, -7);
            this.picClick.Name = "picClick";
            this.picClick.Size = new System.Drawing.Size(589, 907);
            this.picClick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClick.TabIndex = 9;
            this.picClick.TabStop = false;
            this.picClick.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btSeta
            // 
            this.btSeta.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources.istockphoto_1091691460_170667a_removebg_preview;
            this.btSeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSeta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btSeta.Location = new System.Drawing.Point(485, 804);
            this.btSeta.Name = "btSeta";
            this.btSeta.Size = new System.Drawing.Size(41, 40);
            this.btSeta.TabIndex = 10;
            this.btSeta.Text = "button1";
            this.btSeta.UseVisualStyleBackColor = true;
            this.btSeta.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Capa
            // 
            this.AcceptButton = this.btSeta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = global::Vinhao_Aplicacao.Properties.Resources.CapaLivro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 893);
            this.Controls.Add(this.picSeta);
            this.Controls.Add(this.btSeta);
            this.Controls.Add(this.labelRealizado);
            this.Controls.Add(this.picVinhao);
            this.Controls.Add(this.picClick);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Capa";
            this.Text = "Capa";
            this.Load += new System.EventHandler(this.Capa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVinhao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSeta;
        private System.Windows.Forms.Label labelRealizado;
        private System.Windows.Forms.PictureBox picVinhao;
        private System.Windows.Forms.PictureBox picClick;
        private System.Windows.Forms.Button btSeta;
    }
}