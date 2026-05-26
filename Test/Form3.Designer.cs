namespace Test
{
    partial class Form3
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 18);
            label1.Name = "label1";
            label1.Size = new Size(314, 31);
            label1.TabIndex = 0;
            label1.Text = "Register Your Hotel With Us";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(694, 28);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(34, 95);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 2;
            label2.Text = "Hotel Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(34, 187);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(34, 214);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(694, 61);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Apartment", "Resort", "Guest House", "Luxury" });
            comboBox1.Location = new Point(34, 345);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(694, 28);
            comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(34, 318);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Hotel Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(34, 415);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 8;
            label6.Text = "Address (CIty)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(34, 506);
            label5.Name = "label5";
            label5.Size = new Size(132, 20);
            label5.TabIndex = 10;
            label5.Text = "Hotel Image (URL)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(34, 533);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(694, 27);
            textBox4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(34, 612);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 12;
            label7.Text = "Price Per Person";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(66, 639);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(276, 27);
            textBox5.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(40, 642);
            label8.Name = "label8";
            label8.Size = new Size(27, 20);
            label8.TabIndex = 13;
            label8.Text = "Rs.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(395, 642);
            label9.Name = "label9";
            label9.Size = new Size(27, 20);
            label9.TabIndex = 16;
            label9.Text = "Rs.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(389, 612);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 15;
            label10.Text = "Additional Guest Charge";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(421, 639);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(307, 27);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(47, 707);
            button1.Name = "button1";
            button1.Size = new Size(666, 39);
            button1.TabIndex = 17;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(34, 442);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(694, 28);
            comboBox2.TabIndex = 18;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 782);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(textBox6);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label4;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private Button button1;
        private ComboBox comboBox2;
    }
}