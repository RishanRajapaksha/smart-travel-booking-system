namespace Test
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(230, 53);
            label1.Name = "label1";
            label1.Size = new Size(332, 60);
            label1.TabIndex = 0;
            label1.Text = "Rishan Travels";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(151, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Describe Where You Wanna Go?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(169, 113);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(437, 37);
            label2.TabIndex = 2;
            label2.Text = "Smart Travel Partner in Sri Lanka";
            // 
            // button1
            // 
            button1.Location = new Point(230, 265);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 3;
            button1.Text = "Find Best Matching Hotels";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
    }
}
