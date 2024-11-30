using System;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Pilot : Form
    {
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.headerLine = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlUpcomingFlights = new System.Windows.Forms.Panel();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.lblUpcomingFlights = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.pnlUpcomingFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.pnlQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(29, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(173, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "LNB Airlines";
            // 
            // headerLine
            // 
            this.headerLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerLine.Location = new System.Drawing.Point(25, 45);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(450, 2);
            this.headerLine.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(29, 71);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(213, 28);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome back, John!";
            // 
            // pnlUpcomingFlights
            // 
            this.pnlUpcomingFlights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcomingFlights.Controls.Add(this.dataGridViewFlights);
            this.pnlUpcomingFlights.Controls.Add(this.lblUpcomingFlights);
            this.pnlUpcomingFlights.Location = new System.Drawing.Point(34, 112);
            this.pnlUpcomingFlights.Name = "pnlUpcomingFlights";
            this.pnlUpcomingFlights.Size = new System.Drawing.Size(460, 437);
            this.pnlUpcomingFlights.TabIndex = 4;
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(-1, -1);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 62;
            this.dataGridViewFlights.Size = new System.Drawing.Size(460, 437);
            this.dataGridViewFlights.TabIndex = 1;
            // 
            // lblUpcomingFlights
            // 
            this.lblUpcomingFlights.AutoSize = true;
            this.lblUpcomingFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingFlights.Location = new System.Drawing.Point(5, 5);
            this.lblUpcomingFlights.Name = "lblUpcomingFlights";
            this.lblUpcomingFlights.Size = new System.Drawing.Size(0, 17);
            this.lblUpcomingFlights.TabIndex = 0;
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickActions.Controls.Add(this.btnRequestLeave);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(524, 377);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(312, 172);
            this.pnlQuickActions.TabIndex = 5;
            // 
            // btnRequestLeave
            // 
            this.btnRequestLeave.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRequestLeave.Location = new System.Drawing.Point(8, 37);
            this.btnRequestLeave.Name = "btnRequestLeave";
            this.btnRequestLeave.Size = new System.Drawing.Size(140, 40);
            this.btnRequestLeave.TabIndex = 0;
            this.btnRequestLeave.Text = "Request Leave";
            this.btnRequestLeave.UseVisualStyleBackColor = true;
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
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUserName.Location = new System.Drawing.Point(747, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 17);
            this.lblUserName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(36, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 10;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(825, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(524, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // Pilot
            // 
            this.ClientSize = new System.Drawing.Size(873, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlUpcomingFlights);
            this.Controls.Add(this.pnlQuickActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilot";
            this.Text = "SkyCrew - Pilot Dashboard";
            this.pnlUpcomingFlights.ResumeLayout(false);
            this.pnlUpcomingFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlUpcomingFlights;
        private System.Windows.Forms.DataGridView dataGridViewFlights;  // DataGridView for upcoming flights
        private System.Windows.Forms.Label lblUpcomingFlights;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.Label lblQuickActions;
        private Panel panel1;
        private Button buttonExit;
        private MonthCalendar monthCalendar1;
    }
}
