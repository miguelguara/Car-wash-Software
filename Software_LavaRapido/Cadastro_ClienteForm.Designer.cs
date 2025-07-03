namespace Software_LavaRapido
{
    partial class Cadastro_ClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NometextBox = new System.Windows.Forms.TextBox();
            this.CPFtextBox = new System.Windows.Forms.TextBox();
            this.EnderecotextBox = new System.Windows.Forms.TextBox();
            this.Salvarbutton = new System.Windows.Forms.Button();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Endereco";
            // 
            // NometextBox
            // 
            this.NometextBox.Location = new System.Drawing.Point(12, 37);
            this.NometextBox.Name = "NometextBox";
            this.NometextBox.Size = new System.Drawing.Size(547, 22);
            this.NometextBox.TabIndex = 4;
            // 
            // CPFtextBox
            // 
            this.CPFtextBox.Location = new System.Drawing.Point(9, 97);
            this.CPFtextBox.Name = "CPFtextBox";
            this.CPFtextBox.Size = new System.Drawing.Size(550, 22);
            this.CPFtextBox.TabIndex = 5;
            // 
            // EnderecotextBox
            // 
            this.EnderecotextBox.Location = new System.Drawing.Point(12, 161);
            this.EnderecotextBox.Name = "EnderecotextBox";
            this.EnderecotextBox.Size = new System.Drawing.Size(547, 22);
            this.EnderecotextBox.TabIndex = 6;
            // 
            // Salvarbutton
            // 
            this.Salvarbutton.Location = new System.Drawing.Point(452, 211);
            this.Salvarbutton.Name = "Salvarbutton";
            this.Salvarbutton.Size = new System.Drawing.Size(107, 36);
            this.Salvarbutton.TabIndex = 7;
            this.Salvarbutton.Text = "Salvar";
            this.Salvarbutton.UseVisualStyleBackColor = true;
            this.Salvarbutton.Click += new System.EventHandler(this.Salvarbutton_Click);
            // 
            // Fecharbutton
            // 
            this.Fecharbutton.Location = new System.Drawing.Point(589, 211);
            this.Fecharbutton.Name = "Fecharbutton";
            this.Fecharbutton.Size = new System.Drawing.Size(108, 36);
            this.Fecharbutton.TabIndex = 8;
            this.Fecharbutton.Text = "Fechar";
            this.Fecharbutton.UseVisualStyleBackColor = true;
            this.Fecharbutton.Click += new System.EventHandler(this.Fecharbutton_Click);
            // 
            // Cadastro_ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 270);
            this.Controls.Add(this.Fecharbutton);
            this.Controls.Add(this.Salvarbutton);
            this.Controls.Add(this.EnderecotextBox);
            this.Controls.Add(this.CPFtextBox);
            this.Controls.Add(this.NometextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_ClienteForm";
            this.Text = "Cadastro_ClienteForm";
            this.Load += new System.EventHandler(this.Cadastro_ClienteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NometextBox;
        private System.Windows.Forms.TextBox CPFtextBox;
        private System.Windows.Forms.TextBox EnderecotextBox;
        private System.Windows.Forms.Button Salvarbutton;
        private System.Windows.Forms.Button Fecharbutton;
    }
}