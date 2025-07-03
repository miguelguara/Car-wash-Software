namespace Software_LavaRapido
{
    partial class CadastroVeiculoForm
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
            this.PlacatextBox = new System.Windows.Forms.TextBox();
            this.ModelotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Salvarbutton = new System.Windows.Forms.Button();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // PlacatextBox
            // 
            this.PlacatextBox.Location = new System.Drawing.Point(15, 51);
            this.PlacatextBox.Name = "PlacatextBox";
            this.PlacatextBox.Size = new System.Drawing.Size(532, 22);
            this.PlacatextBox.TabIndex = 1;
            // 
            // ModelotextBox
            // 
            this.ModelotextBox.Location = new System.Drawing.Point(15, 125);
            this.ModelotextBox.Name = "ModelotextBox";
            this.ModelotextBox.Size = new System.Drawing.Size(532, 22);
            this.ModelotextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo do Carro:";
            // 
            // Salvarbutton
            // 
            this.Salvarbutton.Location = new System.Drawing.Point(409, 178);
            this.Salvarbutton.Name = "Salvarbutton";
            this.Salvarbutton.Size = new System.Drawing.Size(138, 33);
            this.Salvarbutton.TabIndex = 4;
            this.Salvarbutton.Text = "Salvar";
            this.Salvarbutton.UseVisualStyleBackColor = true;
            this.Salvarbutton.Click += new System.EventHandler(this.Salvarbutton_Click);
            // 
            // Fecharbutton
            // 
            this.Fecharbutton.Location = new System.Drawing.Point(553, 178);
            this.Fecharbutton.Name = "Fecharbutton";
            this.Fecharbutton.Size = new System.Drawing.Size(140, 33);
            this.Fecharbutton.TabIndex = 5;
            this.Fecharbutton.Text = "Fechar";
            this.Fecharbutton.UseVisualStyleBackColor = true;
            this.Fecharbutton.Click += new System.EventHandler(this.Fecharbutton_Click);
            // 
            // CadastroVeiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 223);
            this.Controls.Add(this.Fecharbutton);
            this.Controls.Add(this.Salvarbutton);
            this.Controls.Add(this.ModelotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlacatextBox);
            this.Controls.Add(this.label1);
            this.Name = "CadastroVeiculoForm";
            this.Text = "VEICULO";
            this.Load += new System.EventHandler(this.VeiculoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PlacatextBox;
        private System.Windows.Forms.TextBox ModelotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Salvarbutton;
        private System.Windows.Forms.Button Fecharbutton;
    }
}