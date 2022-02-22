
namespace ProdutosPOO
{
    partial class ProdutoInicialForm
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
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.listaButton = new System.Windows.Forms.Button();
            this.manutencaoButton = new System.Windows.Forms.Button();
            this.sobreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPictureBox.Image = global::ProdutosPOO.Properties.Resources.newlogo;
            this.logoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(362, 104);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 13;
            this.logoPictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(86, 119);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(191, 20);
            this.label.TabIndex = 14;
            this.label.Text = "POO: Gestão de Stock";
            // 
            // listaButton
            // 
            this.listaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.listaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.listaButton.Location = new System.Drawing.Point(40, 184);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(280, 47);
            this.listaButton.TabIndex = 1;
            this.listaButton.Text = "Tabela de Produtos";
            this.listaButton.UseVisualStyleBackColor = false;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // manutencaoButton
            // 
            this.manutencaoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.manutencaoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manutencaoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.manutencaoButton.Location = new System.Drawing.Point(40, 274);
            this.manutencaoButton.Name = "manutencaoButton";
            this.manutencaoButton.Size = new System.Drawing.Size(280, 47);
            this.manutencaoButton.TabIndex = 2;
            this.manutencaoButton.Text = "Manutenção da Tabela";
            this.manutencaoButton.UseVisualStyleBackColor = false;
            this.manutencaoButton.Click += new System.EventHandler(this.manutencaoButton_Click);
            // 
            // sobreButton
            // 
            this.sobreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.sobreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sobreButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sobreButton.Location = new System.Drawing.Point(40, 363);
            this.sobreButton.Name = "sobreButton";
            this.sobreButton.Size = new System.Drawing.Size(280, 47);
            this.sobreButton.TabIndex = 3;
            this.sobreButton.Text = "Sobre";
            this.sobreButton.UseVisualStyleBackColor = false;
            this.sobreButton.Click += new System.EventHandler(this.sobreButton_Click);
            // 
            // ProdutoInicialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(362, 461);
            this.Controls.Add(this.sobreButton);
            this.Controls.Add(this.manutencaoButton);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "ProdutoInicialForm";
            this.Text = "ProdutoInicialForm";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.Button manutencaoButton;
        private System.Windows.Forms.Button sobreButton;
    }
}