namespace Software_LavaRapido
{
    partial class VeiculosForm
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
            this.PesquisarVeiculobutton = new System.Windows.Forms.Button();
            this.VeiculostextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VeiculosdataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Novobutton = new System.Windows.Forms.Button();
            this.Alterarbutton = new System.Windows.Forms.Button();
            this.Excluirbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosdataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PesquisarVeiculobutton);
            this.panel1.Controls.Add(this.VeiculostextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 71);
            this.panel1.TabIndex = 0;
            // 
            // PesquisarVeiculobutton
            // 
            this.PesquisarVeiculobutton.Location = new System.Drawing.Point(415, 26);
            this.PesquisarVeiculobutton.Name = "PesquisarVeiculobutton";
            this.PesquisarVeiculobutton.Size = new System.Drawing.Size(95, 23);
            this.PesquisarVeiculobutton.TabIndex = 1;
            this.PesquisarVeiculobutton.Text = "Pesquisar";
            this.PesquisarVeiculobutton.UseVisualStyleBackColor = true;
            this.PesquisarVeiculobutton.Click += new System.EventHandler(this.Pesquisarbutton_Click);
            // 
            // VeiculostextBox
            // 
            this.VeiculostextBox.Location = new System.Drawing.Point(13, 27);
            this.VeiculostextBox.Name = "VeiculostextBox";
            this.VeiculostextBox.Size = new System.Drawing.Size(386, 22);
            this.VeiculostextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VeiculosdataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 498);
            this.panel2.TabIndex = 1;
            // 
            // VeiculosdataGridView
            // 
            this.VeiculosdataGridView.AllowUserToAddRows = false;
            this.VeiculosdataGridView.AllowUserToDeleteRows = false;
            this.VeiculosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VeiculosdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VeiculosdataGridView.Location = new System.Drawing.Point(0, 0);
            this.VeiculosdataGridView.Name = "VeiculosdataGridView";
            this.VeiculosdataGridView.ReadOnly = true;
            this.VeiculosdataGridView.RowHeadersWidth = 51;
            this.VeiculosdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VeiculosdataGridView.Size = new System.Drawing.Size(1060, 498);
            this.VeiculosdataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 496);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 73);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Novobutton);
            this.panel4.Controls.Add(this.Alterarbutton);
            this.panel4.Controls.Add(this.Excluirbutton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(496, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(564, 73);
            this.panel4.TabIndex = 0;
            // 
            // Novobutton
            // 
            this.Novobutton.Location = new System.Drawing.Point(176, 27);
            this.Novobutton.Name = "Novobutton";
            this.Novobutton.Size = new System.Drawing.Size(95, 23);
            this.Novobutton.TabIndex = 2;
            this.Novobutton.Text = "Novo";
            this.Novobutton.UseVisualStyleBackColor = true;
            this.Novobutton.Click += new System.EventHandler(this.Novobutton_Click);
            // 
            // Alterarbutton
            // 
            this.Alterarbutton.Enabled = false;
            this.Alterarbutton.Location = new System.Drawing.Point(317, 27);
            this.Alterarbutton.Name = "Alterarbutton";
            this.Alterarbutton.Size = new System.Drawing.Size(95, 23);
            this.Alterarbutton.TabIndex = 3;
            this.Alterarbutton.Text = "Alterar";
            this.Alterarbutton.UseVisualStyleBackColor = true;
            this.Alterarbutton.Click += new System.EventHandler(this.Alterarbutton_Click);
            // 
            // Excluirbutton
            // 
            this.Excluirbutton.Location = new System.Drawing.Point(447, 27);
            this.Excluirbutton.Name = "Excluirbutton";
            this.Excluirbutton.Size = new System.Drawing.Size(95, 23);
            this.Excluirbutton.TabIndex = 4;
            this.Excluirbutton.Text = "Excluir";
            this.Excluirbutton.UseVisualStyleBackColor = true;
            // 
            // VeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 569);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VeiculosForm";
            this.Text = "VeiculosForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculosdataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PesquisarVeiculobutton;
        private System.Windows.Forms.TextBox VeiculostextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView VeiculosdataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Novobutton;
        private System.Windows.Forms.Button Alterarbutton;
        private System.Windows.Forms.Button Excluirbutton;
    }
}