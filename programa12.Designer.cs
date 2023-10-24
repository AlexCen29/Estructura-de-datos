namespace Parcial2Pilas
{
    partial class programa12
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            listBox2 = new ListBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 36);
            button1.Name = "button1";
            button1.Size = new Size(458, 151);
            button1.TabIndex = 0;
            button1.Text = "Entrada de automoviles";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 207);
            button2.Name = "button2";
            button2.Size = new Size(458, 151);
            button2.TabIndex = 1;
            button2.Text = "Salida de automoviles";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(485, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(600, 384);
            listBox1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(36, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 381);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(166, 313);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Cyan;
            button4.Location = new Point(40, 313);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "agregar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(30, 62);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 27);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(30, 136);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(217, 27);
            textBox4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 104);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 1;
            label3.Text = "Placa:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 31);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 0;
            label4.Text = "Nombre: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(39, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 381);
            panel1.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 128, 128);
            button5.Location = new Point(65, 122);
            button5.Name = "button5";
            button5.Size = new Size(159, 81);
            button5.TabIndex = 5;
            button5.Text = "SALIDA AUTOMOVIL";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Maroon;
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(108, 309);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 4;
            button6.Text = "Regresar";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(791, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(485, 4);
            button7.Name = "button7";
            button7.Size = new Size(169, 29);
            button7.TabIndex = 7;
            button7.Text = "CARROS EN COLA";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(660, 4);
            button8.Name = "button8";
            button8.Size = new Size(206, 29);
            button8.TabIndex = 8;
            button8.Text = "HISTORIAL DE CARROS";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(485, 54);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(600, 384);
            listBox2.TabIndex = 9;
            // 
            // programa12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 450);
            Controls.Add(listBox2);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "programa12";
            Text = "programa12";
            Load += programa12_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Panel panel2;
        private Button button4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Button button3;
        private Panel panel1;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button7;
        private Button button8;
        private ListBox listBox2;
    }
}