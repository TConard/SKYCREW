using System;
using System.Windows.Forms;

namespace SkyCrew
{
    public partial class Pilot : Form
    {

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem29 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight AA123"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem30 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight BB456"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem31 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight CC789"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem32 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight DD125"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblHeader = new System.Windows.Forms.Label();
            this.headerLine = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlUpcomingFlights = new System.Windows.Forms.Panel();
            this.lblUpcomingFlights = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.btnRequestLeave = new System.Windows.Forms.Button();
            this.lblQuickActions = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.pnlTrends = new System.Windows.Forms.Panel();
            this.lblTrends = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelNotification2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pnlUpcomingFlights.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlNotifications.SuspendLayout();
            this.pnlTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblHeader.Location = new System.Drawing.Point(29, 11);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(127, 37);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "SkyCrew";
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
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
            this.lblWelcome.Size = new System.Drawing.Size(212, 28);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome back, Pilot!";
            // 
            // pnlUpcomingFlights
            // 
            this.pnlUpcomingFlights.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpcomingFlights.Controls.Add(this.listView1);
            this.pnlUpcomingFlights.Controls.Add(this.lblUpcomingFlights);
            this.pnlUpcomingFlights.Location = new System.Drawing.Point(34, 112);
            this.pnlUpcomingFlights.Name = "pnlUpcomingFlights";
            this.pnlUpcomingFlights.Size = new System.Drawing.Size(283, 192);
            this.pnlUpcomingFlights.TabIndex = 4;
            // 
            // lblUpcomingFlights
            // 
            this.lblUpcomingFlights.AutoSize = true;
            this.lblUpcomingFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingFlights.Location = new System.Drawing.Point(5, 5);
            this.lblUpcomingFlights.Name = "lblUpcomingFlights";
            this.lblUpcomingFlights.Size = new System.Drawing.Size(132, 17);
            this.lblUpcomingFlights.TabIndex = 0;
            this.lblUpcomingFlights.Text = "Upcoming Flights";
            // 
            // pnlQuickActions
            // 
            this.pnlQuickActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuickActions.Controls.Add(this.btnRequestLeave);
            this.pnlQuickActions.Controls.Add(this.lblQuickActions);
            this.pnlQuickActions.Location = new System.Drawing.Point(403, 112);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(283, 192);
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
            // pnlNotifications
            // 
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.labelNotification2);
            this.pnlNotifications.Controls.Add(this.lblNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(34, 343);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(283, 191);
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
            // pnlTrends
            // 
            this.pnlTrends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrends.Controls.Add(this.chart1);
            this.pnlTrends.Controls.Add(this.lblTrends);
            this.pnlTrends.Location = new System.Drawing.Point(403, 343);
            this.pnlTrends.Name = "pnlTrends";
            this.pnlTrends.Size = new System.Drawing.Size(283, 191);
            this.pnlTrends.TabIndex = 7;
            // 
            // lblTrends
            // 
            this.lblTrends.AutoSize = true;
            this.lblTrends.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTrends.Location = new System.Drawing.Point(5, 5);
            this.lblTrends.Name = "lblTrends";
            this.lblTrends.Size = new System.Drawing.Size(180, 17);
            this.lblTrends.TabIndex = 0;
            this.lblTrends.Text = "Shift Availability Trends";
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
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem29,
            listViewItem30,
            listViewItem31,
            listViewItem32});
            this.listView1.Location = new System.Drawing.Point(8, 37);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(260, 138);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(8, 33);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(263, 143);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // labelNotification2
            // 
            this.labelNotification2.AutoSize = true;
            this.labelNotification2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelNotification2.Location = new System.Drawing.Point(5, 33);
            this.labelNotification2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotification2.Name = "labelNotification2";
            this.labelNotification2.Size = new System.Drawing.Size(161, 19);
            this.labelNotification2.TabIndex = 3;
            this.labelNotification2.Text = "Schedule change for ...";
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
            // 
            // Pilot
            // 
            this.ClientSize = new System.Drawing.Size(873, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlUpcomingFlights);
            this.Controls.Add(this.pnlQuickActions);
            this.Controls.Add(this.pnlNotifications);
            this.Controls.Add(this.pnlTrends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pilot";
            this.Text = "SkyCrew - Pilot Dashboard";
            this.pnlUpcomingFlights.ResumeLayout(false);
            this.pnlUpcomingFlights.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            this.pnlTrends.ResumeLayout(false);
            this.pnlTrends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlUpcomingFlights;
        private System.Windows.Forms.Label lblUpcomingFlights;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Button btnRequestLeave;
        private System.Windows.Forms.Label lblQuickActions;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.Panel pnlTrends;
        private System.Windows.Forms.Label lblTrends;
        private Panel panel1;
        private ListView listView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label labelNotification2;
        private Button buttonExit;
    }
}
