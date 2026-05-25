namespace Test
{
    partial class Form2
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
            sri_lankan_city = new Label();
            persons = new Label();
            nights = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            title = new Label();
            property_category = new Label();
            address = new Label();
            button1 = new Button();
            label4 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            colorDialog1 = new ColorDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sri_lankan_city
            // 
            sri_lankan_city.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sri_lankan_city.AutoSize = true;
            sri_lankan_city.Location = new Point(188, 23);
            sri_lankan_city.Margin = new Padding(4, 0, 4, 0);
            sri_lankan_city.Name = "sri_lankan_city";
            sri_lankan_city.Size = new Size(42, 23);
            sri_lankan_city.TabIndex = 0;
            sri_lankan_city.Text = "City";
            // 
            // persons
            // 
            persons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            persons.AutoSize = true;
            persons.Location = new Point(519, 23);
            persons.Margin = new Padding(4, 0, 4, 0);
            persons.Name = "persons";
            persons.Size = new Size(69, 23);
            persons.TabIndex = 1;
            persons.Text = "Persons";
            // 
            // nights
            // 
            nights.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nights.AutoSize = true;
            nights.Location = new Point(849, 23);
            nights.Margin = new Padding(4, 0, 4, 0);
            nights.Name = "nights";
            nights.Size = new Size(63, 23);
            nights.TabIndex = 2;
            nights.Text = "Nights";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(776, 23);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 23);
            label1.TabIndex = 5;
            label1.Text = "Nights : ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(436, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 23);
            label2.TabIndex = 4;
            label2.Text = "Persons :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(46, 23);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 3;
            label3.Text = "Sri Lankan City : ";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(36, 104);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(332, 104);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(292, 41);
            title.TabIndex = 7;
            title.Text = "Browns Beach Galle";
            title.Click += label4_Click;
            // 
            // property_category
            // 
            property_category.AutoSize = true;
            property_category.Font = new Font("Segoe UI Emoji", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            property_category.Location = new Point(339, 165);
            property_category.Margin = new Padding(4, 0, 4, 0);
            property_category.Name = "property_category";
            property_category.Size = new Size(166, 22);
            property_category.TabIndex = 8;
            property_category.Text = "Property Category";
            // 
            // address
            // 
            address.AutoSize = true;
            address.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            address.Location = new Point(339, 198);
            address.Margin = new Padding(4, 0, 4, 0);
            address.Name = "address";
            address.Size = new Size(115, 23);
            address.TabIndex = 9;
            address.Text = "📍 Buthpitiya";
            address.Click += address_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(776, 183);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(157, 51);
            button1.TabIndex = 10;
            button1.Text = "Book the hotel";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(787, 111);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(135, 31);
            label4.TabIndex = 11;
            label4.Text = "Rs. 100,000";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(27, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1130, 574);
            flowLayoutPanel1.TabIndex = 12;
            flowLayoutPanel1.WrapContents = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 681);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(address);
            Controls.Add(property_category);
            Controls.Add(title);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(nights);
            Controls.Add(persons);
            Controls.Add(sri_lankan_city);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sri_lankan_city;
        private Label persons;
        private Label nights;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label title;
        private Label property_category;
        private Label address;
        private Button button1;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private ColorDialog colorDialog1;
    }
}