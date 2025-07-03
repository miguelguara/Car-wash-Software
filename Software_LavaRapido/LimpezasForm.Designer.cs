namespace Software_LavaRapido
{
    partial class LimpezasForm
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
            this.AgendamentostextBox = new System.Windows.Forms.TextBox();
            this.Limpezasbutton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LimpezasdataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NovoAGEbutton = new System.Windows.Forms.Button();
            this.AlterarAgebutton = new System.Windows.Forms.Button();
            this.ExcluirAGEbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LimpezasdataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AgendamentostextBox);
            this.panel1.Controls.Add(this.Limpezasbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 74);
            this.panel1.TabIndex = 0;
            // 
            // AgendamentostextBox
            // 
            this.AgendamentostextBox.Location = new System.Drawing.Point(37, 26);
            this.AgendamentostextBox.Name = "AgendamentostextBox";
            this.AgendamentostextBox.Size = new System.Drawing.Size(273, 22);
            this.AgendamentostextBox.TabIndex = 1;
            // 
            // Limpezasbutton
            // 
            this.Limpezasbutton.Location = new System.Drawing.Point(340, 26);
            this.Limpezasbutton.Name = "Limpezasbutton";
            this.Limpezasbutton.Size = new System.Drawing.Size(90, 23);
            this.Limpezasbutton.TabIndex = 0;
            this.Limpezasbutton.Text = "Pesquisar";
            this.Limpezasbutton.UseVisualStyleBackColor = true;
            this.Limpezasbutton.Click += new System.EventHandler(this.Limpezasbutton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LimpezasdataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 467);
            this.panel2.TabIndex = 1;
            // 
            // LimpezasdataGridView
            // 
            this.LimpezasdataGridView.AllowUserToAddRows = false;
            this.LimpezasdataGridView.AllowUserToDeleteRows = false;
            this.LimpezasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LimpezasdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LimpezasdataGridView.Location = new System.Drawing.Point(0, 0);
            this.LimpezasdataGridView.Name = "LimpezasdataGridView";
            this.LimpezasdataGridView.ReadOnly = true;
            this.LimpezasdataGridView.RowHeadersWidth = 51;
            this.LimpezasdataGridView.RowTemplate.Height = 24;
            this.LimpezasdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LimpezasdataGridView.Size = new System.Drawing.Size(942, 467);
            this.LimpezasdataGridView.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 89);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.NovoAGEbutton);
            this.panel4.Controls.Add(this.AlterarAgebutton);
            this.panel4.Controls.Add(this.ExcluirAGEbutton);
            this.panel4.Location = new System.Drawing.Point(340, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(602, 89);
            this.panel4.TabIndex = 0;
            // 
            // NovoAGEbutton
            // 
            this.NovoAGEbutton.Location = new System.Drawing.Point(18, 26);
            this.NovoAGEbutton.Name = "NovoAGEbutton";
            this.NovoAGEbutton.Size = new System.Drawing.Size(191, 33);
            this.NovoAGEbutton.TabIndex = 2;
            this.NovoAGEbutton.Text = "Novo Agendamento";
            this.NovoAGEbutton.UseVisualStyleBackColor = true;
            this.NovoAGEbutton.Click += new System.EventHandler(this.NovoAGEbutton_Click);
            // 
            // AlterarAgebutton
            // 
            this.AlterarAgebutton.Enabled = false;
            this.AlterarAgebutton.Location = new System.Drawing.Point(238, 26);
            this.AlterarAgebutton.Name = "AlterarAgebutton";
            this.AlterarAgebutton.Size = new System.Drawing.Size(203, 33);
            this.AlterarAgebutton.TabIndex = 3;
            this.AlterarAgebutton.Text = "Alterar Agendamento";
            this.AlterarAgebutton.UseVisualStyleBackColor = true;
            this.AlterarAgebutton.Click += new System.EventHandler(this.AlterarAgebutton_Click);
            // 
            // ExcluirAGEbutton
            // 
            this.ExcluirAGEbutton.Location = new System.Drawing.Point(473, 26);
            this.ExcluirAGEbutton.Name = "ExcluirAGEbutton";
            this.ExcluirAGEbutton.Size = new System.Drawing.Size(93, 33);
            this.ExcluirAGEbutton.TabIndex = 4;
            this.ExcluirAGEbutton.Text = "Excluir ";
            this.ExcluirAGEbutton.UseVisualStyleBackColor = true;
            this.ExcluirAGEbutton.Click += new System.EventHandler(this.ExcluirAGEbutton_Click);
            // 
            // LimpezasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 541);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "LimpezasForm";
            this.Text = "LimpezasForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LimpezasdataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AgendamentostextBox;
        private System.Windows.Forms.Button Limpezasbutton;
        private System.Windows.Forms.DataGridView LimpezasdataGridView;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button NovoAGEbutton;
        private System.Windows.Forms.Button AlterarAgebutton;
        private System.Windows.Forms.Button ExcluirAGEbutton;
    }
}