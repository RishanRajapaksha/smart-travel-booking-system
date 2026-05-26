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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            hiToolStripMenuItem = new ToolStripMenuItem();
            registToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 117);
            label1.Name = "label1";
            label1.Size = new Size(332, 60);
            label1.TabIndex = 0;
            label1.Text = "Rishan Travels";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(82, 246);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(666, 67);
            textBox1.TabIndex = 1;
            textBox1.Text = "I want to travel to Kadawatha. I am traveling with my 2 kids.this variables. I will stay 2 nights.";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 177);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(437, 37);
            label2.TabIndex = 2;
            label2.Text = "Smart Travel Partner in Sri Lanka";
            // 
            // button1
            // 
            button1.Location = new Point(237, 329);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 3;
            button1.Text = "Find Best Matching Hotels";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(649, 419);
            button2.Name = "button2";
            button2.Size = new Size(161, 29);
            button2.TabIndex = 4;
            button2.Text = "Register Your Hotel";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(858, 74);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "Login";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButton1.BackColor = SystemColors.ControlLight;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { hiToolStripMenuItem, registToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Margin = new Padding(10, 20, 30, 10);
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(50, 20, 0, 0);
            toolStripDropDownButton1.Size = new Size(178, 44);
            toolStripDropDownButton1.Text = "Register / Login";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // hiToolStripMenuItem
            // 
            hiToolStripMenuItem.Name = "hiToolStripMenuItem";
            hiToolStripMenuItem.Size = new Size(268, 26);
            hiToolStripMenuItem.Text = "Register As A Hotel Owner";
            // 
            // registToolStripMenuItem
            // 
            registToolStripMenuItem.Name = "registToolStripMenuItem";
            registToolStripMenuItem.Size = new Size(268, 26);
            registToolStripMenuItem.Text = "Register As A Traveller";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 474);
            Controls.Add(toolStrip1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Button button1;
        private Button button2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem hiToolStripMenuItem;
        private ToolStripMenuItem registToolStripMenuItem;
    }
}
