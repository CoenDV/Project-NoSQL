namespace DemoApp
{
    partial class AddTicketForm
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
            this.lblCreateticket = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblReported = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxDeadline = new System.Windows.Forms.ComboBox();
            this.dateTimePickerTicket = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblCreateticket
            // 
            this.lblCreateticket.AutoSize = true;
            this.lblCreateticket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblCreateticket.Location = new System.Drawing.Point(180, 60);
            this.lblCreateticket.Name = "lblCreateticket";
            this.lblCreateticket.Size = new System.Drawing.Size(391, 38);
            this.lblCreateticket.TabIndex = 0;
            this.lblCreateticket.Text = "Create new incident ticket";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(184, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(102, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date/time reported: ";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(184, 148);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(86, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type of incident:";
            // 
            // lblReported
            // 
            this.lblReported.AutoSize = true;
            this.lblReported.Location = new System.Drawing.Point(184, 173);
            this.lblReported.Name = "lblReported";
            this.lblReported.Size = new System.Drawing.Size(91, 13);
            this.lblReported.TabIndex = 4;
            this.lblReported.Text = "Reported by user:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(184, 198);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(41, 13);
            this.lblPriority.TabIndex = 5;
            this.lblPriority.Text = "Priority:";
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(184, 223);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(99, 13);
            this.lblDeadline.TabIndex = 6;
            this.lblDeadline.Text = "Deadline/follow up:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(184, 248);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(300, 245);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 150);
            this.textBoxDescription.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(300, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(430, 399);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "SUBMIT TICKET";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(300, 145);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(250, 21);
            this.comboBoxType.TabIndex = 13;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(300, 170);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(250, 21);
            this.comboBoxUser.TabIndex = 14;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(300, 195);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(250, 21);
            this.comboBoxPriority.TabIndex = 15;
            // 
            // comboBoxDeadline
            // 
            this.comboBoxDeadline.FormattingEnabled = true;
            this.comboBoxDeadline.Location = new System.Drawing.Point(300, 220);
            this.comboBoxDeadline.Name = "comboBoxDeadline";
            this.comboBoxDeadline.Size = new System.Drawing.Size(250, 21);
            this.comboBoxDeadline.TabIndex = 16;
            // 
            // dateTimePickerTicket
            // 
            this.dateTimePickerTicket.Location = new System.Drawing.Point(300, 121);
            this.dateTimePickerTicket.Name = "dateTimePickerTicket";
            this.dateTimePickerTicket.Size = new System.Drawing.Size(250, 20);
            this.dateTimePickerTicket.TabIndex = 17;
            this.dateTimePickerTicket.Value = new System.DateTime(2023, 9, 24, 0, 0, 0, 0);
            // 
            // AddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dateTimePickerTicket);
            this.Controls.Add(this.comboBoxDeadline);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxUser);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblReported);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCreateticket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTicketForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblReported;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.DateTimePicker dateTimePickerTicket;
        protected System.Windows.Forms.ComboBox comboBoxType;
        protected System.Windows.Forms.ComboBox comboBoxUser;
        protected System.Windows.Forms.ComboBox comboBoxPriority;
        protected System.Windows.Forms.ComboBox comboBoxDeadline;
        protected System.Windows.Forms.TextBox textBoxDescription;
        protected System.Windows.Forms.Label lblCreateticket;
        protected System.Windows.Forms.Button btnSubmit;
    }
}