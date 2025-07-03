namespace Software_LavaRapido
{
    partial class CadastrarUsuarioForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.SenhatextBox = new System.Windows.Forms.TextBox();
            this.Salvarbutton = new System.Windows.Forms.Button();
            this.Fecharbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Defina seu login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Defina sua Senha:";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(33, 70);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(409, 22);
            this.UserNametextBox.TabIndex = 2;
            // 
            // SenhatextBox
            // 
            this.SenhatextBox.Location = new System.Drawing.Point(33, 149);
            this.SenhatextBox.Name = "SenhatextBox";
            this.SenhatextBox.Size = new System.Drawing.Size(406, 22);
            this.SenhatextBox.TabIndex = 3;
            // 
            // Salvarbutton
            // 
            this.Salvarbutton.Location = new System.Drawing.Point(344, 219);
            this.Salvarbutton.Name = "Salvarbutton";
            this.Salvarbutton.Size = new System.Drawing.Size(111, 33);
            this.Salvarbutton.TabIndex = 4;
            this.Salvarbutton.Text = "Salvar";
            this.Salvarbutton.UseVisualStyleBackColor = true;
            this.Salvarbutton.Click += new System.EventHandler(this.Salvarbutton_Click);
            // 
            // Fecharbutton
            // 
            this.Fecharbutton.Location = new System.Drawing.Point(497, 219);
            this.Fecharbutton.Name = "Fecharbutton";
            this.Fecharbutton.Size = new System.Drawing.Size(103, 33);
            this.Fecharbutton.TabIndex = 5;
            this.Fecharbutton.Text = "Fechar";
            this.Fecharbutton.UseVisualStyleBackColor = true;
            this.Fecharbutton.Click += new System.EventHandler(this.Fecharbutton_Click);
            // 
            // CadastrarUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 279);
            this.Controls.Add(this.Fecharbutton);
            this.Controls.Add(this.Salvarbutton);
            this.Controls.Add(this.SenhatextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarUsuarioForm";
            this.Text = "CadastrarUsuarioForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox SenhatextBox;
        private System.Windows.Forms.Button Salvarbutton;
        private System.Windows.Forms.Button Fecharbutton;
    }
}