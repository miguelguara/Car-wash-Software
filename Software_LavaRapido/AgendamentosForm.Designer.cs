namespace Software_LavaRapido
{
    partial class AgendamentosForm
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
            this.DIAdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HORAdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ModelocomboBox = new System.Windows.Forms.ComboBox();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ValornumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ValornumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DIAdateTimePicker
            // 
            this.DIAdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DIAdateTimePicker.Location = new System.Drawing.Point(351, 99);
            this.DIAdateTimePicker.Name = "DIAdateTimePicker";
            this.DIAdateTimePicker.Size = new System.Drawing.Size(115, 22);
            this.DIAdateTimePicker.TabIndex = 0;
            // 
            // HORAdateTimePicker
            // 
            this.HORAdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HORAdateTimePicker.Location = new System.Drawing.Point(351, 196);
            this.HORAdateTimePicker.Name = "HORAdateTimePicker";
            this.HORAdateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.HORAdateTimePicker.TabIndex = 1;
            // 
            // ModelocomboBox
            // 
            this.ModelocomboBox.FormattingEnabled = true;
            this.ModelocomboBox.Location = new System.Drawing.Point(54, 104);
            this.ModelocomboBox.Name = "ModelocomboBox";
            this.ModelocomboBox.Size = new System.Drawing.Size(245, 24);
            this.ModelocomboBox.TabIndex = 2;
            this.ModelocomboBox.SelectedIndexChanged += new System.EventHandler(this.ModelocomboBox_SelectedIndexChanged);
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(54, 197);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(245, 24);
            this.ClientecomboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Placa do Veiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dia da Limpeza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Horario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(658, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ValornumericUpDown
            // 
            this.ValornumericUpDown.DecimalPlaces = 2;
            this.ValornumericUpDown.Location = new System.Drawing.Point(515, 97);
            this.ValornumericUpDown.Name = "ValornumericUpDown";
            this.ValornumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.ValornumericUpDown.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(513, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor da Limpeza:";
            // 
            // AgendamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 303);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValornumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.ModelocomboBox);
            this.Controls.Add(this.HORAdateTimePicker);
            this.Controls.Add(this.DIAdateTimePicker);
            this.Name = "AgendamentosForm";
            this.Text = "AgendamentosForm";
            ((System.ComponentModel.ISupportInitialize)(this.ValornumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DIAdateTimePicker;
        private System.Windows.Forms.DateTimePicker HORAdateTimePicker;
        private System.Windows.Forms.ComboBox ModelocomboBox;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown ValornumericUpDown;
        private System.Windows.Forms.Label label5;
    }
}