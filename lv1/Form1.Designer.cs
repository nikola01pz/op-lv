namespace WinFormsApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(534, 79);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Button 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(534, 166);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Button 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 170);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(353, 232);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 4;
            label3.Click += label3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(308, 307);
            button3.Name = "button3";
            button3.Size = new Size(145, 23);
            button3.TabIndex = 5;
            button3.Text = "Calculate root quadratic equation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 316);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 275);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 308);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 337);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 257);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 10;
            label5.Text = "Enter a, b, c";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(534, 283);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Root1:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(594, 283);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(82, 278);
            label9.Name = "label9";
            label9.Size = new Size(16, 15);
            label9.TabIndex = 14;
            label9.Text = "a:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(81, 311);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 15;
            label10.Text = "b:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(81, 340);
            label11.Name = "label11";
            label11.Size = new Size(16, 15);
            label11.TabIndex = 16;
            label11.Text = "c:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(594, 316);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(534, 316);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 18;
            label13.Text = "Root2:";
            label13.Click += label13_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "LV1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}