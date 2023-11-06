namespace DemoApp
{
    partial class TicketView
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
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Location = new System.Drawing.Point(300, 435);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(250, 23);
            this.btnDeleteTicket.TabIndex = 19;
            this.btnDeleteTicket.Text = "DELETE TICKET";
            this.btnDeleteTicket.UseVisualStyleBackColor = true;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // TicketView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 465);
            this.Controls.Add(this.btnDeleteTicket);
            this.Name = "TicketView";
            this.Text = "TicketView";
            this.Controls.SetChildIndex(this.lblCreateticket, 0);
            this.Controls.SetChildIndex(this.textBoxDescription, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.comboBoxType, 0);
            this.Controls.SetChildIndex(this.comboBoxPriority, 0);
            this.Controls.SetChildIndex(this.comboBoxDeadline, 0);
            this.Controls.SetChildIndex(this.dateTimePickerTicket, 0);
            this.Controls.SetChildIndex(this.comboBoxUser, 0);
            this.Controls.SetChildIndex(this.btnDeleteTicket, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteTicket;
    }
}