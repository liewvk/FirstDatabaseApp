namespace FirstDatabaseApp
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
            btnSave = new Button();
            txtFullName = new TextBox();
            label1 = new Label();
            cmbGender = new ComboBox();
            label2 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            txtPhoneNumber = new TextBox();
            label4 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            btnUpdate = new Button();
            txtStudentID = new TextBox();
            label6 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(111, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(195, 34);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(228, 27);
            txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(195, 129);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(76, 28);
            cmbGender.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 132);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Gender";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(195, 175);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(177, 27);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 180);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(195, 219);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(228, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 226);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(195, 264);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(346, 27);
            txtAddress.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 267);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 3;
            label5.Text = "Address";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(285, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 47);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(195, 76);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(165, 27);
            txtStudentID.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(97, 83);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 3;
            label6.Text = "Student ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(488, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 43);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtStudentID);
            Controls.Add(btnUpdate);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private TextBox txtFullName;
        private Label label1;
        private ComboBox cmbGender;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private TextBox txtPhoneNumber;
        private Label label4;
        private TextBox txtAddress;
        private Label label5;
        private Button btnUpdate;
        private TextBox txtStudentID;
        private Label label6;
        private Button btnDelete;
    }
}
