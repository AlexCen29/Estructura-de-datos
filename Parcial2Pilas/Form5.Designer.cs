namespace Parcial2Pilas
{
    partial class Form5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            turno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            tipo = new DataGridViewTextBoxColumn();
            hora = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(19, 19);
            label1.Name = "label1";
            label1.Size = new Size(93, 17);
            label1.TabIndex = 0;
            label1.Text = "Datos de cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "No. Turno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 91);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Cliente";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(92, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(332, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Pago de servicio", "Depósito", "Retíro", "Compra de tiempo aire", "Consulta de saldo" });
            comboBox1.Location = new Point(91, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Text = "Movimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 211);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 6;
            label4.Text = "Frente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 240);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 7;
            label5.Text = "Final";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(110, 203);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(40, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(110, 232);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(40, 23);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(635, 22);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 10;
            button1.Text = "Agregar a la cola";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(635, 86);
            button2.Name = "button2";
            button2.Size = new Size(93, 38);
            button2.TabIndex = 11;
            button2.Text = "Atender en ventanilla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(635, 149);
            button3.Name = "button3";
            button3.Size = new Size(93, 38);
            button3.TabIndex = 12;
            button3.Text = "Salida del sistema";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { turno, nombre, tipo, hora });
            dataGridView1.Location = new Point(35, 278);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(693, 150);
            dataGridView1.TabIndex = 13;
            // 
            // turno
            // 
            turno.HeaderText = "No. Turno";
            turno.Name = "turno";
            turno.Width = 50;
            // 
            // nombre
            // 
            nombre.HeaderText = "Cliente";
            nombre.Name = "nombre";
            nombre.Width = 200;
            // 
            // tipo
            // 
            tipo.HeaderText = "Tipo movimiento";
            tipo.Name = "tipo";
            tipo.Width = 200;
            // 
            // hora
            // 
            hora.HeaderText = "Hora llegada";
            hora.Name = "hora";
            hora.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 167);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 47);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(55, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "1";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn turno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn tipo;
        private DataGridViewTextBoxColumn hora;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}