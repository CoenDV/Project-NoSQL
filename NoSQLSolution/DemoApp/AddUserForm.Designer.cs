namespace DemoApp
{
    partial class AddUserForm
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
            this.cbLocationBranch = new System.Windows.Forms.ComboBox();
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtboxLastName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblReported = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreateticket = new System.Windows.Forms.Label();
            this.txtboxFirstName = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.chkSendPassword = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbLocationBranch
            // 
            this.cbLocationBranch.FormattingEnabled = true;
            this.cbLocationBranch.Location = new System.Drawing.Point(292, 219);
            this.cbLocationBranch.Name = "cbLocationBranch";
            this.cbLocationBranch.Size = new System.Drawing.Size(250, 21);
            this.cbLocationBranch.TabIndex = 33;
            // 
            // cbUserType
            // 
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Location = new System.Drawing.Point(292, 144);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(250, 21);
            this.cbUserType.TabIndex = 30;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(422, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "ADD USER";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtboxLastName
            // 
            this.txtboxLastName.Location = new System.Drawing.Point(292, 119);
            this.txtboxLastName.Name = "txtboxLastName";
            this.txtboxLastName.Size = new System.Drawing.Size(250, 20);
            this.txtboxLastName.TabIndex = 25;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(176, 247);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Send password?";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(176, 222);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(89, 13);
            this.lblDeadline.TabIndex = 23;
            this.lblDeadline.Text = "Location/branch:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(176, 197);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(79, 13);
            this.lblPriority.TabIndex = 22;
            this.lblPriority.Text = "Phone number:";
            // 
            // lblReported
            // 
            this.lblReported.AutoSize = true;
            this.lblReported.Location = new System.Drawing.Point(176, 172);
            this.lblReported.Name = "lblReported";
            this.lblReported.Size = new System.Drawing.Size(78, 13);
            this.lblReported.TabIndex = 21;
            this.lblReported.Text = "E-mail address:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(176, 147);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(69, 13);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type of user:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(176, 122);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 13);
            this.lblSubject.TabIndex = 19;
            this.lblSubject.Text = "Last name:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(176, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 13);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "First name:";
            // 
            // lblCreateticket
            // 
            this.lblCreateticket.AutoSize = true;
            this.lblCreateticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblCreateticket.Location = new System.Drawing.Point(172, 32);
            this.lblCreateticket.Name = "lblCreateticket";
            this.lblCreateticket.Size = new System.Drawing.Size(257, 38);
            this.lblCreateticket.TabIndex = 17;
            this.lblCreateticket.Text = "Create new user";
            // 
            // txtboxFirstName
            // 
            this.txtboxFirstName.Location = new System.Drawing.Point(292, 94);
            this.txtboxFirstName.Name = "txtboxFirstName";
            this.txtboxFirstName.Size = new System.Drawing.Size(250, 20);
            this.txtboxFirstName.TabIndex = 34;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(292, 169);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(250, 20);
            this.txtboxEmail.TabIndex = 35;
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(292, 194);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(250, 20);
            this.txtboxPhoneNumber.TabIndex = 36;
            // 
            // chkSendPassword
            // 
            this.chkSendPassword.Checked = true;
            this.chkSendPassword.Location = new System.Drawing.Point(292, 246);
            this.chkSendPassword.Name = "chkSendPassword";
            this.chkSendPassword.Size = new System.Drawing.Size(250, 30);
            this.chkSendPassword.TabIndex = 37;
            this.chkSendPassword.TabStop = true;
            this.chkSendPassword.Text = "yes, a password e-mail will be sent to the user";
            this.chkSendPassword.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.chkSendPassword);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxFirstName);
            this.Controls.Add(this.cbLocationBranch);
            this.Controls.Add(this.cbUserType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtboxLastName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblReported);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCreateticket);
            this.Name = "AddUserForm";
            this.Text = "AddUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocationBranch;
        private System.Windows.Forms.ComboBox cbUserType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtboxLastName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblReported;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreateticket;
        private System.Windows.Forms.TextBox txtboxFirstName;
        private System.Windows.Forms.TextBox txtboxEmail;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.RadioButton chkSendPassword;
    }
}