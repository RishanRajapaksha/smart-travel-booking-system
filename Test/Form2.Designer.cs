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
            SuspendLayout();
            // 
            // sri_lankan_city
            // 
            sri_lankan_city.AutoSize = true;
            sri_lankan_city.Location = new Point(150, 20);
            sri_lankan_city.Name = "sri_lankan_city";
            sri_lankan_city.Size = new Size(34, 20);
            sri_lankan_city.TabIndex = 0;
            sri_lankan_city.Text = "City";
            // 
            // persons
            // 
            persons.AutoSize = true;
            persons.Location = new Point(415, 20);
            persons.Name = "persons";
            persons.Size = new Size(58, 20);
            persons.TabIndex = 1;
            persons.Text = "Persons";
            // 
            // nights
            // 
            nights.AutoSize = true;
            nights.Location = new Point(679, 20);
            nights.Name = "nights";
            nights.Size = new Size(52, 20);
            nights.TabIndex = 2;
            nights.Text = "Nights";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 20);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Nights : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(349, 20);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Persons :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 20);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Sri Lankan City : ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(nights);
            Controls.Add(persons);
            Controls.Add(sri_lankan_city);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
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
    }
}