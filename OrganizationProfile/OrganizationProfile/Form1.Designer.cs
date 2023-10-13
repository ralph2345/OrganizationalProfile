namespace OrganizationProfile
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
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleInitial = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            label8 = new Label();
            datePickerBirthday = new DateTimePicker();
            label9 = new Label();
            txtContactNo = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(159, 67);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(171, 23);
            txtStudentNo.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(159, 131);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(159, 195);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(449, 134);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtMiddleInitial
            // 
            txtMiddleInitial.Location = new Point(675, 134);
            txtMiddleInitial.Name = "txtMiddleInitial";
            txtMiddleInitial.Size = new Size(100, 23);
            txtMiddleInitial.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(41, 67);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 8;
            label1.Text = "Student No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(41, 130);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 9;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(84, 195);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 10;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(370, 74);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 11;
            label4.Text = "Program:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(356, 134);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 12;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(379, 199);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 13;
            label6.Text = "Gender:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(640, 137);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 14;
            label7.Text = "MI:";
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Location = new Point(449, 71);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(175, 23);
            cbProgram.TabIndex = 15;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(449, 196);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(449, 261);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 18;
            label8.Text = "Contact No:";
            // 
            // datePickerBirthday
            // 
            datePickerBirthday.Location = new Point(159, 258);
            datePickerBirthday.Name = "datePickerBirthday";
            datePickerBirthday.Size = new Size(244, 23);
            datePickerBirthday.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(61, 261);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 20;
            label9.Text = "Birthday:";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(542, 258);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(175, 23);
            txtContactNo.TabIndex = 21;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(336, 308);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(137, 58);
            btnRegister.TabIndex = 22;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 401);
            Controls.Add(btnRegister);
            Controls.Add(txtContactNo);
            Controls.Add(label9);
            Controls.Add(datePickerBirthday);
            Controls.Add(label8);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMiddleInitial);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMiddleInitial;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private Label label8;
        private DateTimePicker datePickerBirthday;
        private Label label9;
        private TextBox txtContactNo;
        private Button btnRegister;
    }
}