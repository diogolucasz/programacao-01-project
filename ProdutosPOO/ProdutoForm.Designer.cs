
namespace ProdutosPOO
{
    partial class ProdutoForm
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
            this.idLabel = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.precoLabel = new System.Windows.Forms.Label();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            this.stockUpDown = new System.Windows.Forms.NumericUpDown();
            this.gravarButton = new System.Windows.Forms.Button();
            this.eliminarButton = new System.Windows.Forms.Button();
            this.novoButton = new System.Windows.Forms.Button();
            this.sairButton = new System.Windows.Forms.Button();
            this.listaButton = new System.Windows.Forms.Button();
            this.dataRegistoLabel = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.navegaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaDeDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataRegistoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.erroStockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stockUpDown)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(86, 63);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(64, 13);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "ID Produto :";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.Location = new System.Drawing.Point(396, 157);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(35, 13);
            this.labelStock.TabIndex = 3;
            this.labelStock.Text = "Stock";
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Location = new System.Drawing.Point(86, 112);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(61, 13);
            this.descricaoLabel.TabIndex = 5;
            this.descricaoLabel.Text = "Descrição :";
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(86, 158);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(41, 13);
            this.precoLabel.TabIndex = 6;
            this.precoLabel.Text = "Preço :";
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Location = new System.Drawing.Point(86, 206);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(58, 13);
            this.categoriaLabel.TabIndex = 7;
            this.categoriaLabel.Text = "Categoria :";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(150, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(180, 20);
            this.idTextBox.TabIndex = 1;
            this.idTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.idTextBox_KeyUp);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(150, 109);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(522, 20);
            this.descricaoTextBox.TabIndex = 3;
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(150, 155);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(180, 20);
            this.precoTextBox.TabIndex = 4;
            // 
            // stockUpDown
            // 
            this.stockUpDown.Location = new System.Drawing.Point(492, 156);
            this.stockUpDown.Name = "stockUpDown";
            this.stockUpDown.Size = new System.Drawing.Size(180, 20);
            this.stockUpDown.TabIndex = 5;
            this.stockUpDown.ValueChanged += new System.EventHandler(this.stockUpDown_ValueChanged);
            // 
            // gravarButton
            // 
            this.gravarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(204)))), ((int)(((byte)(149)))));
            this.gravarButton.Location = new System.Drawing.Point(196, 332);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(101, 49);
            this.gravarButton.TabIndex = 9;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = false;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // eliminarButton
            // 
            this.eliminarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
            this.eliminarButton.Location = new System.Drawing.Point(303, 332);
            this.eliminarButton.Name = "eliminarButton";
            this.eliminarButton.Size = new System.Drawing.Size(101, 49);
            this.eliminarButton.TabIndex = 10;
            this.eliminarButton.Text = "Eliminar";
            this.eliminarButton.UseVisualStyleBackColor = false;
            this.eliminarButton.Click += new System.EventHandler(this.eliminarButton_Click);
            // 
            // novoButton
            // 
            this.novoButton.Location = new System.Drawing.Point(89, 332);
            this.novoButton.Name = "novoButton";
            this.novoButton.Size = new System.Drawing.Size(101, 49);
            this.novoButton.TabIndex = 8;
            this.novoButton.Text = "Novo";
            this.novoButton.UseVisualStyleBackColor = true;
            this.novoButton.Click += new System.EventHandler(this.novoButton_Click);
            // 
            // sairButton
            // 
            this.sairButton.Location = new System.Drawing.Point(571, 332);
            this.sairButton.Name = "sairButton";
            this.sairButton.Size = new System.Drawing.Size(101, 49);
            this.sairButton.TabIndex = 11;
            this.sairButton.Text = "Sair";
            this.sairButton.UseVisualStyleBackColor = true;
            this.sairButton.Click += new System.EventHandler(this.sairButton_Click);
            // 
            // listaButton
            // 
            this.listaButton.Location = new System.Drawing.Point(336, 60);
            this.listaButton.Name = "listaButton";
            this.listaButton.Size = new System.Drawing.Size(36, 20);
            this.listaButton.TabIndex = 2;
            this.listaButton.Text = "...";
            this.listaButton.UseVisualStyleBackColor = true;
            this.listaButton.Click += new System.EventHandler(this.listaButton_Click);
            // 
            // dataRegistoLabel
            // 
            this.dataRegistoLabel.AutoSize = true;
            this.dataRegistoLabel.Location = new System.Drawing.Point(396, 206);
            this.dataRegistoLabel.Name = "dataRegistoLabel";
            this.dataRegistoLabel.Size = new System.Drawing.Size(75, 13);
            this.dataRegistoLabel.TabIndex = 20;
            this.dataRegistoLabel.Text = "Data Registo :";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(150, 203);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(180, 21);
            this.categoriaComboBox.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navegaçãoToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(739, 24);
            this.menuStrip.TabIndex = 25;
            this.menuStrip.Text = "menuStrip";
            // 
            // navegaçãoToolStripMenuItem
            // 
            this.navegaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelaDeDadosToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.navegaçãoToolStripMenuItem.Name = "navegaçãoToolStripMenuItem";
            this.navegaçãoToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.navegaçãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.N)));
            this.navegaçãoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.navegaçãoToolStripMenuItem.Text = "Navegação";
            // 
            // tabelaDeDadosToolStripMenuItem
            // 
            this.tabelaDeDadosToolStripMenuItem.Name = "tabelaDeDadosToolStripMenuItem";
            this.tabelaDeDadosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tabelaDeDadosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.tabelaDeDadosToolStripMenuItem.Text = "Tabela de dados";
            this.tabelaDeDadosToolStripMenuItem.Click += new System.EventHandler(this.tabelaDeDadosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dataRegistoTextBox
            // 
            this.dataRegistoTextBox.Location = new System.Drawing.Point(492, 206);
            this.dataRegistoTextBox.Name = "dataRegistoTextBox";
            this.dataRegistoTextBox.ReadOnly = true;
            this.dataRegistoTextBox.Size = new System.Drawing.Size(180, 20);
            this.dataRegistoTextBox.TabIndex = 7;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // erroStockLabel
            // 
            this.erroStockLabel.AutoSize = true;
            this.erroStockLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.erroStockLabel.Location = new System.Drawing.Point(86, 264);
            this.erroStockLabel.Name = "erroStockLabel";
            this.erroStockLabel.Padding = new System.Windows.Forms.Padding(6);
            this.erroStockLabel.Size = new System.Drawing.Size(91, 25);
            this.erroStockLabel.TabIndex = 26;
            this.erroStockLabel.Text = "erroStockLabel";
            this.erroStockLabel.Visible = false;
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 419);
            this.Controls.Add(this.erroStockLabel);
            this.Controls.Add(this.dataRegistoTextBox);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.dataRegistoLabel);
            this.Controls.Add(this.listaButton);
            this.Controls.Add(this.sairButton);
            this.Controls.Add(this.novoButton);
            this.Controls.Add(this.eliminarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.stockUpDown);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProdutoForm";
            this.Text = "ProdutosPOO";
            ((System.ComponentModel.ISupportInitialize)(this.stockUpDown)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label descricaoLabel;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox precoTextBox;
        private System.Windows.Forms.NumericUpDown stockUpDown;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button eliminarButton;
        private System.Windows.Forms.Button novoButton;
        private System.Windows.Forms.Button sairButton;
        private System.Windows.Forms.Button listaButton;
        private System.Windows.Forms.Label dataRegistoLabel;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem navegaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaDeDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox dataRegistoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label erroStockLabel;
    }
}

