namespace TryCatch
{
    partial class frmConformation
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblStudentNo = new Label();
            lblName = new Label();
            lblProgram = new Label();
            lblAge = new Label();
            lblBirthday = new Label();
            lblGender = new Label();
            lblContactNo = new Label();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(57, 104);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(56, 156);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 2;
            label3.Text = "Program:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(57, 206);
            label4.Name = "label4";
            label4.Size = new Size(40, 21);
            label4.TabIndex = 3;
            label4.Text = "Age:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 260);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 4;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(57, 313);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 5;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(57, 373);
            label7.Name = "label7";
            label7.Size = new Size(98, 21);
            label7.TabIndex = 6;
            label7.Text = "Contact No.: ";
            // 
            // lblStudentNo
            // 
            lblStudentNo.AutoSize = true;
            lblStudentNo.Location = new Point(239, 51);
            lblStudentNo.Name = "lblStudentNo";
            lblStudentNo.Size = new Size(43, 17);
            lblStudentNo.TabIndex = 7;
            lblStudentNo.Text = "label8";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(239, 107);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 17);
            lblName.TabIndex = 8;
            lblName.Text = "label9";
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Location = new Point(239, 159);
            lblProgram.Name = "lblProgram";
            lblProgram.Size = new Size(50, 17);
            lblProgram.TabIndex = 9;
            lblProgram.Text = "label10";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(239, 210);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(50, 17);
            lblAge.TabIndex = 10;
            lblAge.Text = "label11";
            // 
            // lblBirthday
            // 
            lblBirthday.AutoSize = true;
            lblBirthday.Location = new Point(239, 264);
            lblBirthday.Name = "lblBirthday";
            lblBirthday.Size = new Size(50, 17);
            lblBirthday.TabIndex = 11;
            lblBirthday.Text = "label12";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(239, 317);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(50, 17);
            lblGender.TabIndex = 12;
            lblGender.Text = "label13";
            // 
            // lblContactNo
            // 
            lblContactNo.AutoSize = true;
            lblContactNo.Location = new Point(239, 377);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(50, 17);
            lblContactNo.TabIndex = 13;
            lblContactNo.Text = "label14";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(173, 429);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 42);
            btnSubmit.TabIndex = 14;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // frmConformation
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 497);
            Controls.Add(btnSubmit);
            Controls.Add(lblContactNo);
            Controls.Add(lblGender);
            Controls.Add(lblBirthday);
            Controls.Add(lblAge);
            Controls.Add(lblProgram);
            Controls.Add(lblName);
            Controls.Add(lblStudentNo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmConformation";
            Text = "frmConformation";
            Load += frmConformation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblStudentNo;
        private Label lblName;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBirthday;
        private Label lblGender;
        private Label lblContactNo;
        private Button btnSubmit;
    }
}