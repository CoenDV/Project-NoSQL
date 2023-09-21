namespace DemoApp
{
    partial class TicketOverviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketOverviewForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnIncidentManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblOverviewTickets = new System.Windows.Forms.Label();
            this.txtBoxFilter = new System.Windows.Forms.TextBox();
            this.btnCreateIncident = new System.Windows.Forms.Button();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(0, 80);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(215, 30);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnIncidentManagement
            // 
            this.btnIncidentManagement.Location = new System.Drawing.Point(215, 80);
            this.btnIncidentManagement.Name = "btnIncidentManagement";
            this.btnIncidentManagement.Size = new System.Drawing.Size(215, 30);
            this.btnIncidentManagement.TabIndex = 2;
            this.btnIncidentManagement.Text = "Incident Management";
            this.btnIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(430, 80);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(215, 30);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblTitle.Location = new System.Drawing.Point(497, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(135, 38);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "NoDesk";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblSubTitle.Location = new System.Drawing.Point(387, 47);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(245, 20);
            this.lblSubTitle.TabIndex = 5;
            this.lblSubTitle.Text = "Licensed to: The Garden Group";
            // 
            // lblOverviewTickets
            // 
            this.lblOverviewTickets.AutoSize = true;
            this.lblOverviewTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.lblOverviewTickets.Location = new System.Drawing.Point(20, 120);
            this.lblOverviewTickets.Name = "lblOverviewTickets";
            this.lblOverviewTickets.Size = new System.Drawing.Size(258, 38);
            this.lblOverviewTickets.TabIndex = 6;
            this.lblOverviewTickets.Text = "Overview tickets";
            // 
            // txtBoxFilter
            // 
            this.txtBoxFilter.AccessibleDescription = "";
            this.txtBoxFilter.Location = new System.Drawing.Point(127, 170);
            this.txtBoxFilter.Name = "txtBoxFilter";
            this.txtBoxFilter.Size = new System.Drawing.Size(150, 20);
            this.txtBoxFilter.TabIndex = 7;
            this.txtBoxFilter.Leave += new System.EventHandler(this.txtBoxFilter_Leave);
            // 
            // btnCreateIncident
            // 
            this.btnCreateIncident.Location = new System.Drawing.Point(470, 170);
            this.btnCreateIncident.Name = "btnCreateIncident";
            this.btnCreateIncident.Size = new System.Drawing.Size(150, 30);
            this.btnCreateIncident.TabIndex = 8;
            this.btnCreateIncident.Text = "CREATE INCIDENT";
            this.btnCreateIncident.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Email,
            this.User,
            this.Date,
            this.Status});
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(27, 210);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(593, 589);
            this.listViewResults.TabIndex = 9;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "Id";
            this.ID.Width = 63;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 200;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 100;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter by E-mail:";
            // 
            // TicketOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 811);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.btnCreateIncident);
            this.Controls.Add(this.txtBoxFilter);
            this.Controls.Add(this.lblOverviewTickets);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnIncidentManagement);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TicketOverviewForm";
            this.Text = "TicketOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnIncidentManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblOverviewTickets;
        private System.Windows.Forms.TextBox txtBoxFilter;
        private System.Windows.Forms.Button btnCreateIncident;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Label label1;
    }
}