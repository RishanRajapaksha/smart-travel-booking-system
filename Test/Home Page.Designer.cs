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
            textBox1 = new TextBox();
            button1 = new Button();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            reg_as_hotel_owner = new ToolStripMenuItem();
            reg_as_a_traveller = new ToolStripMenuItem();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(255, 255, 192);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(133, 335);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Example: I want to travel to Kadawatha. I am traveling with my 2 kids. I will stay 2 nights.";
            textBox1.Size = new Size(666, 67);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(324, 463);
            button1.Name = "button1";
            button1.Size = new Size(329, 39);
            button1.TabIndex = 3;
            button1.Text = "Find Best Matching Hotels";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientInactiveCaption;
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
            toolStripDropDownButton1.BackColor = SystemColors.Highlight;
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
            label3.Anchor = AnchorStyles.None;
            label3.BackColor = Color.Linen;
            label3.Font = new Font("Segoe UI Variable Text Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(235, 171);
            label3.Name = "label3";
            label3.Size = new Size(439, 120);
            label3.TabIndex = 6;
            label3.Text = "Just Tell Us, \r\n\r\nWhere You Wanna Go?  📍\r\nHow Many People Will join you? 👥\r\nHow many night will you stay? 🌙\r\n";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.DarkGray;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Enabled = false;
            pictureBox1.Location = new Point(0, -33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(976, 687);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // home_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 652);
            Controls.Add(label3);
            Controls.Add(toolStrip1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "home_page";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Home Page";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem reg_as_hotel_owner;
        private ToolStripMenuItem reg_as_a_traveller;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
