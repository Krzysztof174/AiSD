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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
