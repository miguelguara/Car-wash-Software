namespace Software_LavaRapido
{
    partial class LoginForm
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
            this.UsuariologintextBox = new System.Windows.Forms.TextBox();
            this.SenhalogintextBox = new System.Windows.Forms.TextBox();
            this.Entrarbutton = new System.Windows.Forms.Button();
            this.Sairbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // UsuariologintextBox
            // 
            this.UsuariologintextBox.Location = new System.Drawing.Point(40, 73);
            this.UsuariologintextBox.Name = "UsuariologintextBox";
            this.UsuariologintextBox.Size = new System.Drawing.Size(351, 22);
            this.UsuariologintextBox.TabIndex = 2;
            // 
            // SenhalogintextBox
            // 
            this.SenhalogintextBox.Location = new System.Drawing.Point(40, 162);
            this.SenhalogintextBox.Name = "SenhalogintextBox";
            this.SenhalogintextBox.PasswordChar = '*';
            this.SenhalogintextBox.Size = new System.Drawing.Size(351, 22);
            this.SenhalogintextBox.TabIndex = 3;
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.Location = new System.Drawing.Point(245, 257);
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Size = new System.Drawing.Size(118, 43);
            this.Entrarbutton.TabIndex = 4;
            this.Entrarbutton.Text = "Entrar";
            this.Entrarbutton.UseVisualStyleBackColor = true;
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // Sairbutton
            // 
            this.Sairbutton.Location = new System.Drawing.Point(384, 257);
            this.Sairbutton.Name = "Sairbutton";
            this.Sairbutton.Size = new System.Drawing.Size(117, 43);
            this.Sairbutton.TabIndex = 5;
            this.Sairbutton.Text = "Sair";
            this.Sairbutton.UseVisualStyleBackColor = true;
            this.Sairbutton.Click += new System.EventHandler(this.Sairbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Software_LavaRapido.Properties.Resources.car_service__2_;
            this.pictureBox1.Location = new System.Drawing.Point(410, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 133);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 314);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sairbutton);
            this.Controls.Add(this.Entrarbutton);
            this.Controls.Add(this.SenhalogintextBox);
            this.Controls.Add(this.UsuariologintextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsuariologintextBox;
        private System.Windows.Forms.TextBox SenhalogintextBox;
        private System.Windows.Forms.Button Entrarbutton;
        private System.Windows.Forms.Button Sairbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}