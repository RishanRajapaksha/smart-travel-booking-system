namespace Test
{
    partial class home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            reg_as_hotel_owner = new ToolStripMenuItem();
            reg_as_a_traveller = new ToolStripMenuItem();
            label3 = new Label();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe Fluent Icons", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(267, 103);
            label1.Name = "label1";
            label1.Size = new Size(332, 60);
            label1.TabIndex = 0;
            label1.Text = "Rishan Travels";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(84, 508);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "I want to travel to Kadawatha. I am traveling with my 2 kids. I will stay 2 nights.";
            textBox1.Size = new Size(666, 67);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Fluent Icons", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 163);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(437, 37);
            label2.TabIndex = 2;
            label2.Text = "Smart Travel Partner in Sri Lanka";
            // 
            // button1
            // 
            button1.Location = new Point(237, 589);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 3;
            button1.Text = "Find Best Matching Hotels";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(862, 74);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = "Login";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripDropDownButton1.BackColor = SystemColors.ControlLight;
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { reg_as_hotel_owner, reg_as_a_traveller });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Margin = new Padding(10, 20, 30, 10);
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(50, 20, 0, 0);
            toolStripDropDownButton1.Size = new Size(178, 44);
            toolStripDropDownButton1.Text = "Register / Login";
            // 
            // reg_as_hotel_owner
            // 
            reg_as_hotel_owner.Name = "reg_as_hotel_owner";
            reg_as_hotel_owner.Size = new Size(319, 26);
            reg_as_hotel_owner.Text = "Register / Login As A Hotel Owner";
            reg_as_hotel_owner.Click += reg_as_hotel_owner_Click;
            // 
            // reg_as_a_traveller
            // 
            reg_as_a_traveller.Name = "reg_as_a_traveller";
            reg_as_a_traveller.Size = new Size(319, 26);
            reg_as_a_traveller.Text = "Register / Login As A Traveller";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(261, 364);
            label3.Name = "label3";
            label3.Size = new Size(310, 120);
            label3.TabIndex = 6;
            label3.Text = "Just Tell Us, \r\n\r\nWhere You Wanna Go?  📍\r\nHow Many People Will join you? 👥\r\nHow many night will you stay? 🌙\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 652);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "home_page";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Home Page";
            Load += Form1_Load;
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
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem reg_as_hotel_owner;
        private ToolStripMenuItem reg_as_a_traveller;
        private Label label3;
    }
}
