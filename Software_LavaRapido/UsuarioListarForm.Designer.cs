namespace Software_LavaRapido
{
    partial class UsuarioListarForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PesquisarUsuariobutton = new System.Windows.Forms.Button();
            this.NovoUsuariobutton = new System.Windows.Forms.Button();
            this.Alterarbutton = new System.Windows.Forms.Button();
            this.ExcluirButtons = new System.Windows.Forms.Button();
            this.UsuariodataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PesquisarUsuariobutton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1051, 73);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.UsuariodataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1051, 484);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 460);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1051, 97);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NovoUsuariobutton);
            this.panel4.Controls.Add(this.Alterarbutton);
            this.panel4.Controls.Add(this.ExcluirButtons);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(478, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 97);
            this.panel4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 22);
            this.textBox1.TabIndex = 0;
            // 
            // PesquisarUsuariobutton
            // 
            this.PesquisarUsuariobutton.Location = new System.Drawing.Point(407, 31);
            this.PesquisarUsuariobutton.Name = "PesquisarUsuariobutton";
            this.PesquisarUsuariobutton.Size = new System.Drawing.Size(91, 23);
            this.PesquisarUsuariobutton.TabIndex = 1;
            this.PesquisarUsuariobutton.Text = "Pesquisar";
            this.PesquisarUsuariobutton.UseVisualStyleBackColor = true;
            this.PesquisarUsuariobutton.Click += new System.EventHandler(this.PesquisarUsuariobutton_Click);
            // 
            // NovoUsuariobutton
            // 
            this.NovoUsuariobutton.Location = new System.Drawing.Point(96, 30);
            this.NovoUsuariobutton.Name = "NovoUsuariobutton";
            this.NovoUsuariobutton.Size = new System.Drawing.Size(121, 37);
            this.NovoUsuariobutton.TabIndex = 2;
            this.NovoUsuariobutton.Text = "Novo";
            this.NovoUsuariobutton.UseVisualStyleBackColor = true;
            this.NovoUsuariobutton.Click += new System.EventHandler(this.NovoUsuariobutton_Click);
            // 
            // Alterarbutton
            // 
            this.Alterarbutton.Location = new System.Drawing.Point(249, 30);
            this.Alterarbutton.Name = "Alterarbutton";
            this.Alterarbutton.Size = new System.Drawing.Size(112, 37);
            this.Alterarbutton.TabIndex = 3;
            this.Alterarbutton.Text = "Alterar";
            this.Alterarbutton.UseVisualStyleBackColor = true;
            this.Alterarbutton.Click += new System.EventHandler(this.Alterarbutton_Click);
            // 
            // ExcluirButtons
            // 
            this.ExcluirButtons.Location = new System.Drawing.Point(376, 30);
            this.ExcluirButtons.Name = "ExcluirButtons";
            this.ExcluirButtons.Size = new System.Drawing.Size(140, 37);
            this.ExcluirButtons.TabIndex = 4;
            this.ExcluirButtons.Text = "Excluir";
            this.ExcluirButtons.UseVisualStyleBackColor = true;
            this.ExcluirButtons.Click += new System.EventHandler(this.ExcluirButtons_Click);
            // 
            // UsuariodataGridView
            // 
            this.UsuariodataGridView.AllowUserToAddRows = false;
            this.UsuariodataGridView.AllowUserToDeleteRows = false;
            this.UsuariodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariodataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuariodataGridView.Location = new System.Drawing.Point(0, 0);
            this.UsuariodataGridView.Name = "UsuariodataGridView";
            this.UsuariodataGridView.ReadOnly = true;
            this.UsuariodataGridView.RowHeadersWidth = 51;
            this.UsuariodataGridView.RowTemplate.Height = 24;
            this.UsuariodataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsuariodataGridView.Size = new System.Drawing.Size(1051, 484);
            this.UsuariodataGridView.TabIndex = 0;
            // 
            // UsuarioListarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 557);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsuarioListarForm";
            this.Text = "UsuarioListarForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariodataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PesquisarUsuariobutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button NovoUsuariobutton;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Button ExcluirButtons;
        private System.Windows.Forms.DataGridView UsuariodataGridView;
    }
}