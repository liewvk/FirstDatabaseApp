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
            btnConnect = new Button();
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
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(72, 58);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(260, 39);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Database Connection Test";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(514, 55);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(116, 45);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(204, 146);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(228, 27);
            txtFullName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 153);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Full Name";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(204, 192);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(76, 28);
            cmbGender.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 200);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Gender";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(204, 242);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(177, 27);
            dtpDateOfBirth.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 247);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Date of Birth";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(204, 302);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(228, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 309);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(204, 347);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(346, 27);
            txtAddress.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 350);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 3;
            label5.Text = "Address";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
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
    }
}
