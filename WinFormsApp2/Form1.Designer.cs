namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            button6 = new Button();
            button7 = new Button();
            textBox3 = new TextBox();
            label2 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            button12 = new Button();
            button13 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(318, 359);
            button1.Name = "button1";
            button1.Size = new Size(131, 40);
            button1.TabIndex = 0;
            button1.Text = "Mege Sort\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(44, 359);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 2;
            button2.Text = "Bubble Sort\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(181, 359);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 3;
            button3.Text = "Insert Sort\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 35);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(518, 32);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(210, 35);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(551, 117);
            button4.Name = "button4";
            button4.Size = new Size(131, 40);
            button4.TabIndex = 5;
            button4.Text = "Generuj";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(84, 117);
            button5.Name = "button5";
            button5.Size = new Size(131, 40);
            button5.TabIndex = 6;
            button5.Text = "Konwertuj";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(684, 35);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 266);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 8;
            label1.Text = "Czas sortowania:";
            label1.Click += label1_Click;
            // 
            // button6
            // 
            button6.Location = new Point(455, 359);
            button6.Name = "button6";
            button6.Size = new Size(131, 40);
            button6.TabIndex = 9;
            button6.Text = "Quick Sort";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(592, 359);
            button7.Name = "button7";
            button7.Size = new Size(151, 40);
            button7.TabIndex = 10;
            button7.Text = "Counting Sort";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(952, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(409, 35);
            textBox3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1130, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 30);
            label2.TabIndex = 12;
            label2.Text = "lista";
            // 
            // button8
            // 
            button8.Location = new Point(919, 183);
            button8.Name = "button8";
            button8.Size = new Size(208, 40);
            button8.TabIndex = 13;
            button8.Text = "dodaj pierwszy";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(919, 266);
            button9.Name = "button9";
            button9.Size = new Size(208, 40);
            button9.TabIndex = 14;
            button9.Text = "dodaj ostatni";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(1215, 183);
            button10.Name = "button10";
            button10.Size = new Size(191, 40);
            button10.TabIndex = 15;
            button10.Text = "usun pierwszy";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(1215, 266);
            button11.Name = "button11";
            button11.Size = new Size(191, 40);
            button11.TabIndex = 16;
            button11.Text = "usun ostatni";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(930, 373);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(175, 35);
            textBox4.TabIndex = 17;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(979, 331);
            label3.Name = "label3";
            label3.Size = new Size(71, 30);
            label3.TabIndex = 18;
            label3.Text = "Liczba";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(952, 577);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(409, 35);
            textBox5.TabIndex = 19;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1107, 529);
            label4.Name = "label4";
            label4.Size = new Size(123, 30);
            label4.TabIndex = 20;
            label4.Text = "lista drzewo";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1130, 647);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 21;
            label5.Text = "Liczba";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1082, 691);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(175, 35);
            textBox6.TabIndex = 22;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button12
            // 
            button12.Location = new Point(996, 763);
            button12.Name = "button12";
            button12.Size = new Size(131, 40);
            button12.TabIndex = 23;
            button12.Text = "dodaj";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(1215, 763);
            button13.Name = "button13";
            button13.Size = new Size(131, 40);
            button13.TabIndex = 24;
            button13.Text = "usun";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1494, 971);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private Button button4;
        private Button button5;
        public TextBox textBox2;
        private Label label1;
        private Button button6;
        private Button button7;
        private TextBox textBox3;
        private Label label2;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
        private Button button12;
        private Button button13;
    }
}
