using System;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class CustomerService : Form
    {

        private void InitializeComponent()
        {
            this.headerLine = new System.Windows.Forms.Panel();
            this.pnlAvailableShifts = new System.Windows.Forms.Panel();
            this.lblAvailableShifts = new System.Windows.Forms.Label();
            this.btnShiftDetails1 = new System.Windows.Forms.Button();
            this.btnShiftDetails2 = new System.Windows.Forms.Button();
            this.btnShiftDetails3 = new System.Windows.Forms.Button();
            this.btnShiftDetails4 = new System.Windows.Forms.Button();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnSignUpForShift = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.pnlShiftStats = new System.Windows.Forms.Panel();
            this.lblShiftStats = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pnlAvailableShifts.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.pnlShiftStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLine
            // 
            this.headerLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerLine.Location = new System.Drawing.Point(25, 45);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(450, 2);
            this.headerLine.TabIndex = 1;
            // 
            // pnlAvailableShifts
            // 
            this.pnlAvailableShifts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAvailableShifts.Controls.Add(this.lblAvailableShifts);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails1);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails2);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails3);
            this.pnlAvailableShifts.Controls.Add(this.btnShiftDetails4);
            this.pnlAvailableShifts.Location = new System.Drawing.Point(59, 100);
            this.pnlAvailableShifts.Name = "pnlAvailableShifts";
            this.pnlAvailableShifts.Size = new System.Drawing.Size(265, 177);
            this.pnlAvailableShifts.TabIndex = 4;
            // 
            // lblAvailableShifts
            // 
            this.lblAvailableShifts.AutoSize = true;
            this.lblAvailableShifts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblAvailableShifts.Location = new System.Drawing.Point(5, 5);
            this.lblAvailableShifts.Name = "lblAvailableShifts";
            this.lblAvailableShifts.Size = new System.Drawing.Size(120, 17);
            this.lblAvailableShifts.TabIndex = 0;
            this.lblAvailableShifts.Text = "Available Shifts";
            // 
            // btnShiftDetails1
            // 
            this.btnShiftDetails1.Location = new System.Drawing.Point(10, 30);
            this.btnShiftDetails1.Name = "btnShiftDetails1";
            this.btnShiftDetails1.Size = new System.Drawing.Size(75, 23);
            this.btnShiftDetails1.TabIndex = 1;
            this.btnShiftDetails1.Text = "Details";
            // 
            // btnShiftDetails2
            // 
            this.btnShiftDetails2.Location = new System.Drawing.Point(10, 60);
            this.btnShiftDetails2.Name = "btnShiftDetails2";
            this.btnShiftDetails2.Size = new System.Drawing.Size(75, 23);
            this.btnShiftDetails2.TabIndex = 2;
            this.btnShiftDetails2.Text = "Details";
            // 
            // btnShiftDetails3
            // 
            this.btnShiftDetails3.Location = new System.Drawing.Point(10, 90);
            this.btnShiftDetails3.Name = "btnShiftDetails3";
            this.btnShiftDetails3.Size = new System.Drawing.Size(75, 23);
            this.btnShiftDetails3.TabIndex = 3;
            this.btnShiftDetails3.Text = "Details";
            // 
            // btnShiftDetails4
            // 
            this.btnShiftDetails4.Location = new System.Drawing.Point(10, 120);
            this.btnShiftDetails4.Name = "btnShiftDetails4";
            this.btnShiftDetails4.Size = new System.Drawing.Size(75, 23);
            this.btnShiftDetails4.TabIndex = 4;
            this.btnShiftDetails4.Text = "Details";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickActions.Controls.Add(this.btnSignUpForShift);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(402, 100);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(262, 177);
            this.pnlQuickActions.TabIndex = 5;
            // 
            // btnSignUpForShift
            // 
            this.btnSignUpForShift.BackColor = System.Drawing.Color.LightGreen;
            this.btnSignUpForShift.Location = new System.Drawing.Point(30, 60);
            this.btnSignUpForShift.Name = "btnSignUpForShift";
            this.btnSignUpForShift.Size = new System.Drawing.Size(140, 40);
            this.btnSignUpForShift.TabIndex = 0;
            this.btnSignUpForShift.Text = "Sign Up for Shift";
            this.btnSignUpForShift.UseVisualStyleBackColor = true;
            // 
            // lblQuickActions
            // 
            this.lblQuickActions.AutoSize = true;
            this.lblQuickActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuickActions.Location = new System.Drawing.Point(5, 5);
            this.lblQuickActions.Name = "lblQuickActions";
            this.lblQuickActions.Size = new System.Drawing.Size(107, 17);
            this.lblQuickActions.TabIndex = 1;
            this.lblQuickActions.Text = "Quick Actions";
            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.lblNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(59, 296);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(265, 179);
            this.pnlNotifications.TabIndex = 6;
            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotifications.Location = new System.Drawing.Point(5, 5);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(98, 17);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications";
            // 
            // pnlShiftStats
            // 
            this.pnlShiftStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlShiftStats.Controls.Add(this.lblShiftStats);
            this.pnlShiftStats.Location = new System.Drawing.Point(402, 296);
            this.pnlShiftStats.Name = "pnlShiftStats";
            this.pnlShiftStats.Size = new System.Drawing.Size(262, 179);
            this.pnlShiftStats.TabIndex = 7;
            // 
            // lblShiftStats
            // 
            this.lblShiftStats.AutoSize = true;
            this.lblShiftStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblShiftStats.Location = new System.Drawing.Point(5, 5);
            this.lblShiftStats.Name = "lblShiftStats";
            this.lblShiftStats.Size = new System.Drawing.Size(112, 17);
            this.lblShiftStats.TabIndex = 0;
            this.lblShiftStats.Text = "Shift Statistics";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(25, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(18, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "LNB Airlines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcome back, Agent!";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(819, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // CustomerService
            // 
            this.ClientSize = new System.Drawing.Size(857, 522);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.pnlAvailableShifts);
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlShiftStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerService";
            this.Text = "SkyCrew - Customer Service Dashboard";
            this.pnlAvailableShifts.ResumeLayout(false);
            this.pnlAvailableShifts.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.pnlShiftStats.ResumeLayout(false);
            this.pnlShiftStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Panel pnlAvailableShifts;
        private System.Windows.Forms.Label lblAvailableShifts;
        private System.Windows.Forms.Button btnShiftDetails1;
        private System.Windows.Forms.Button btnShiftDetails2;
        private System.Windows.Forms.Button btnShiftDetails3;
        private System.Windows.Forms.Button btnShiftDetails4;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnSignUpForShift;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Panel pnlShiftStats;
        private System.Windows.Forms.Label lblShiftStats;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button buttonExit;
    }
}
