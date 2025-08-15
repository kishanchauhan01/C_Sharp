namespace WinFormsApp23
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
            name = new TextBox();
            name_label = new Label();
            pswd_label = new Label();
            password = new TextBox();
            branch_label = new Label();
            branch = new ComboBox();
            gender_label = new Label();
            male = new RadioButton();
            female = new RadioButton();
            register = new Button();
            city = new ListBox();
            city_label = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(240, 57);
            name.Name = "name";
            name.Size = new Size(154, 27);
            name.TabIndex = 0;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(153, 64);
            name_label.Name = "name_label";
            name_label.Size = new Size(49, 20);
            name_label.TabIndex = 1;
            name_label.Text = "Name";
            // 
            // pswd_label
            // 
            pswd_label.AutoSize = true;
            pswd_label.Location = new Point(153, 109);
            pswd_label.Name = "pswd_label";
            pswd_label.Size = new Size(70, 20);
            pswd_label.TabIndex = 2;
            pswd_label.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(240, 106);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(154, 27);
            password.TabIndex = 3;
            // 
            // branch_label
            // 
            branch_label.AutoSize = true;
            branch_label.Location = new Point(153, 168);
            branch_label.Name = "branch_label";
            branch_label.Size = new Size(54, 20);
            branch_label.TabIndex = 4;
            branch_label.Text = "Branch";
            // 
            // branch
            // 
            branch.FormattingEnabled = true;
            branch.Items.AddRange(new object[] { "B.Tech CE", "B.Tech IT", "B.Tech ME", "BCA", "MCA" });
            branch.Location = new Point(240, 160);
            branch.Name = "branch";
            branch.Size = new Size(154, 28);
            branch.TabIndex = 5;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Location = new Point(163, 336);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(57, 20);
            gender_label.TabIndex = 6;
            gender_label.Text = "Gender";
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(257, 332);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 7;
            male.TabStop = true;
            male.Text = "male";
            male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(332, 332);
            female.Name = "female";
            female.Size = new Size(76, 24);
            female.TabIndex = 8;
            female.TabStop = true;
            female.Text = "female";
            female.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            register.BackColor = SystemColors.ActiveCaption;
            register.Location = new Point(163, 371);
            register.Name = "register";
            register.Size = new Size(235, 49);
            register.TabIndex = 9;
            register.Text = "Register";
            register.UseVisualStyleBackColor = false;
            // 
            // city
            // 
            city.FormattingEnabled = true;
            city.Items.AddRange(new object[] { "", "Rajkot", "Surat", "New York", "London" });
            city.Location = new Point(240, 208);
            city.Name = "city";
            city.Size = new Size(154, 104);
            city.TabIndex = 10;
            // 
            // city_label
            // 
            city_label.AutoSize = true;
            city_label.Location = new Point(153, 208);
            city_label.Name = "city_label";
            city_label.Size = new Size(34, 20);
            city_label.TabIndex = 11;
            city_label.Text = "City";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(city_label);
            Controls.Add(city);
            Controls.Add(register);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(gender_label);
            Controls.Add(branch);
            Controls.Add(branch_label);
            Controls.Add(password);
            Controls.Add(pswd_label);
            Controls.Add(name_label);
            Controls.Add(name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private Label name_label;
        private Label pswd_label;
        private TextBox password;
        private Label branch_label;
        private ComboBox branch;
        private Label gender_label;
        private RadioButton male;
        private RadioButton female;
        private Button register;
        private ListBox city;
        private Label city_label;
    }
}
