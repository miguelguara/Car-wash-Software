namespace Software_LavaRapido
{
    partial class ClientesForm
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
            this.Paneltop = new System.Windows.Forms.Panel();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.ClientetextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.Excluirbutton = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.PanelMeio = new System.Windows.Forms.Panel();
            this.ClientedataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Paneltop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelMeio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paneltop
            // 
            this.Paneltop.Controls.Add(this.PesquisarButton);
            this.Paneltop.Controls.Add(this.ClientetextBox);
            this.Paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Paneltop.Location = new System.Drawing.Point(0, 0);
            this.Paneltop.Name = "Paneltop";
            this.Paneltop.Size = new System.Drawing.Size(1196, 56);
            this.Paneltop.TabIndex = 0;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Location = new System.Drawing.Point(345, 22);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(94, 23);
            this.PesquisarButton.TabIndex = 1;
            this.PesquisarButton.Text = "Pesquisar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click);
            // 
            // ClientetextBox
            // 
            this.ClientetextBox.Location = new System.Drawing.Point(12, 22);
            this.ClientetextBox.Name = "ClientetextBox";
            this.ClientetextBox.Size = new System.Drawing.Size(314, 22);
            this.ClientetextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1196, 64);
            this.panel1.TabIndex = 1;
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Enabled = false;
            this.buttonAlterar.Location = new System.Drawing.Point(364, 19);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(152, 33);
            this.buttonAlterar.TabIndex = 2;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // Excluirbutton
            // 
            this.Excluirbutton.Location = new System.Drawing.Point(205, 19);
            this.Excluirbutton.Name = "Excluirbutton";
            this.Excluirbutton.Size = new System.Drawing.Size(153, 33);
            this.Excluirbutton.TabIndex = 1;
            this.Excluirbutton.Text = "Excluir";
            this.Excluirbutton.UseVisualStyleBackColor = true;
            this.Excluirbutton.Click += new System.EventHandler(this.Excluirbutton_Click);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(13, 19);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(163, 33);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // PanelMeio
            // 
            this.PanelMeio.Controls.Add(this.ClientedataGridView);
            this.PanelMeio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMeio.Location = new System.Drawing.Point(0, 56);
            this.PanelMeio.Name = "PanelMeio";
            this.PanelMeio.Size = new System.Drawing.Size(1196, 454);
            this.PanelMeio.TabIndex = 2;
            // 
            // ClientedataGridView
            // 
            this.ClientedataGridView.AllowUserToAddRows = false;
            this.ClientedataGridView.AllowUserToDeleteRows = false;
            this.ClientedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientedataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientedataGridView.Name = "ClientedataGridView";
            this.ClientedataGridView.ReadOnly = true;
            this.ClientedataGridView.RowHeadersWidth = 51;
            this.ClientedataGridView.RowTemplate.Height = 24;
            this.ClientedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientedataGridView.Size = new System.Drawing.Size(1196, 454);
            this.ClientedataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNovo);
            this.panel2.Controls.Add(this.buttonAlterar);
            this.panel2.Controls.Add(this.Excluirbutton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(653, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 64);
            this.panel2.TabIndex = 3;
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 574);
            this.Controls.Add(this.PanelMeio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Paneltop);
            this.Name = "ClientesForm";
            this.Text = "ClientesForm";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.Paneltop.ResumeLayout(false);
            this.Paneltop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelMeio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientedataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Paneltop;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.TextBox ClientetextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelMeio;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button Excluirbutton;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.DataGridView ClientedataGridView;
        private System.Windows.Forms.Panel panel2;
    }
}