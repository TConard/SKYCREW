using System.Drawing;
using System.Drawing.Drawing2D;

namespace SkyCrew
{
    partial class GroundCrew
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight AA123"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight BB456"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight CC789"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Flight DD125"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupUpcomingShifts = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonViewDetails1 = new System.Windows.Forms.Button();
            this.buttonViewDetails2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonViewDetails3 = new System.Windows.Forms.Button();
            this.groupQuickActions = new System.Windows.Forms.GroupBox();
            this.buttonAcceptShift = new System.Windows.Forms.Button();
            this.buttonCancelShift = new System.Windows.Forms.Button();
            this.groupNotifications = new System.Windows.Forms.GroupBox();
            this.labelNotification1 = new System.Windows.Forms.Label();
            this.labelNotification2 = new System.Windows.Forms.Label();
            this.groupShiftTrends = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupUpcomingShifts.SuspendLayout();
            this.groupQuickActions.SuspendLayout();
            this.groupNotifications.SuspendLayout();
            this.groupShiftTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);

            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(19, 60);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(213, 28);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome back, John!";
            // 
            // groupUpcomingShifts
            // 
            this.groupUpcomingShifts.BackColor = System.Drawing.Color.White;
            this.groupUpcomingShifts.Controls.Add(this.listView1);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails1);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails2);
            this.groupUpcomingShifts.Controls.Add(this.button1);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails3);
            this.groupUpcomingShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupUpcomingShifts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupUpcomingShifts.Location = new System.Drawing.Point(22, 89);
            this.groupUpcomingShifts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupUpcomingShifts.Name = "groupUpcomingShifts";
            this.groupUpcomingShifts.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupUpcomingShifts.Size = new System.Drawing.Size(316, 258);
            this.groupUpcomingShifts.TabIndex = 1;
            this.groupUpcomingShifts.TabStop = false;
            this.groupUpcomingShifts.Text = "Upcoming Shifts";
            this.groupUpcomingShifts.Enter += new System.EventHandler(this.groupUpcomingShifts_Enter);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listView1.Location = new System.Drawing.Point(14, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(203, 204);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // buttonViewDetails1
            // 
            this.buttonViewDetails1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails1.Location = new System.Drawing.Point(221, 45);
            this.buttonViewDetails1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonViewDetails1.Name = "buttonViewDetails1";
            this.buttonViewDetails1.Size = new System.Drawing.Size(75, 25);
            this.buttonViewDetails1.TabIndex = 2;
            this.buttonViewDetails1.Text = "Details";
            this.buttonViewDetails1.UseVisualStyleBackColor = true;
            // 
            // buttonViewDetails2
            // 
            this.buttonViewDetails2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails2.Location = new System.Drawing.Point(221, 76);
            this.buttonViewDetails2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonViewDetails2.Name = "buttonViewDetails2";
            this.buttonViewDetails2.Size = new System.Drawing.Size(75, 25);
            this.buttonViewDetails2.TabIndex = 3;
            this.buttonViewDetails2.Text = "Details";
            this.buttonViewDetails2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(221, 107);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonViewDetails3
            // 
            this.buttonViewDetails3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails3.Location = new System.Drawing.Point(221, 138);
            this.buttonViewDetails3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonViewDetails3.Name = "buttonViewDetails3";
            this.buttonViewDetails3.Size = new System.Drawing.Size(75, 25);
            this.buttonViewDetails3.TabIndex = 4;
            this.buttonViewDetails3.Text = "Details";
            this.buttonViewDetails3.UseVisualStyleBackColor = true;
            // 
            // groupQuickActions
            // 
            this.groupQuickActions.BackColor = System.Drawing.Color.White;
            this.groupQuickActions.Controls.Add(this.buttonAcceptShift);
            this.groupQuickActions.Controls.Add(this.buttonCancelShift);
            this.groupQuickActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupQuickActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupQuickActions.Location = new System.Drawing.Point(361, 89);
            this.groupQuickActions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupQuickActions.Name = "groupQuickActions";
            this.groupQuickActions.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupQuickActions.Size = new System.Drawing.Size(328, 258);
            this.groupQuickActions.TabIndex = 2;
            this.groupQuickActions.TabStop = false;
            this.groupQuickActions.Text = "Quick Actions";
            // 
            // buttonAcceptShift
            // 
            this.buttonAcceptShift.BackColor = System.Drawing.Color.White;
            this.buttonAcceptShift.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.buttonAcceptShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.buttonAcceptShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptShift.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonAcceptShift.Location = new System.Drawing.Point(15, 45);
            this.buttonAcceptShift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonAcceptShift.Name = "buttonAcceptShift";
            this.buttonAcceptShift.Padding = new System.Windows.Forms.Padding(4);
            this.buttonAcceptShift.Size = new System.Drawing.Size(161, 65);
            this.buttonAcceptShift.TabIndex = 3;
            this.buttonAcceptShift.Text = "Accept Shift";
            this.buttonAcceptShift.UseVisualStyleBackColor = false;
            // 
            // buttonCancelShift
            // 
            this.buttonCancelShift.BackColor = System.Drawing.Color.White;
            this.buttonCancelShift.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonCancelShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelShift.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCancelShift.Location = new System.Drawing.Point(15, 149);
            this.buttonCancelShift.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonCancelShift.Name = "buttonCancelShift";
            this.buttonCancelShift.Padding = new System.Windows.Forms.Padding(4);
            this.buttonCancelShift.Size = new System.Drawing.Size(161, 65);
            this.buttonCancelShift.TabIndex = 4;
            this.buttonCancelShift.Text = "Cancel Shift";
            this.buttonCancelShift.UseVisualStyleBackColor = false;
            // 
            // groupNotifications
            // 
            this.groupNotifications.BackColor = System.Drawing.Color.White;
            this.groupNotifications.Controls.Add(this.labelNotification1);
            this.groupNotifications.Controls.Add(this.labelNotification2);
            this.groupNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupNotifications.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupNotifications.Location = new System.Drawing.Point(361, 362);
            this.groupNotifications.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupNotifications.Name = "groupNotifications";
            this.groupNotifications.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupNotifications.Size = new System.Drawing.Size(328, 170);
            this.groupNotifications.TabIndex = 3;
            this.groupNotifications.TabStop = false;
            this.groupNotifications.Text = "Notifications";
            // 
            // labelNotification1
            // 
            this.labelNotification1.AutoSize = true;
            this.labelNotification1.Location = new System.Drawing.Point(15, 25);
            this.labelNotification1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotification1.Name = "labelNotification1";
            this.labelNotification1.Size = new System.Drawing.Size(136, 19);
            this.labelNotification1.TabIndex = 1;
            this.labelNotification1.Text = "New shift available";
            // 
            // labelNotification2
            // 
            this.labelNotification2.AutoSize = true;
            this.labelNotification2.Location = new System.Drawing.Point(15, 49);
            this.labelNotification2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNotification2.Name = "labelNotification2";
            this.labelNotification2.Size = new System.Drawing.Size(161, 19);
            this.labelNotification2.TabIndex = 2;
            this.labelNotification2.Text = "Schedule change for ...";
            // 
            // groupShiftTrends
            // 
            this.groupShiftTrends.BackColor = System.Drawing.Color.White;
            this.groupShiftTrends.Controls.Add(this.chart1);
            this.groupShiftTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupShiftTrends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupShiftTrends.Location = new System.Drawing.Point(22, 362);
            this.groupShiftTrends.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupShiftTrends.Name = "groupShiftTrends";
            this.groupShiftTrends.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupShiftTrends.Size = new System.Drawing.Size(316, 170);
            this.groupShiftTrends.TabIndex = 4;
            this.groupShiftTrends.TabStop = false;
            this.groupShiftTrends.Text = "Shift Availability Trends";
            this.groupShiftTrends.Enter += new System.EventHandler(this.groupShiftTrends_Enter);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(14, 28);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(293, 132);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "SkyCrew";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(22, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 1);
            this.panel1.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(825, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // GroundCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(873, 561);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupShiftTrends);
            this.Controls.Add(this.groupNotifications);
            this.Controls.Add(this.groupQuickActions);
            this.Controls.Add(this.groupUpcomingShifts);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GroundCrew";
            this.groupUpcomingShifts.ResumeLayout(false);
            this.groupQuickActions.ResumeLayout(false);
            this.groupNotifications.ResumeLayout(false);
            this.groupNotifications.PerformLayout();
            this.groupShiftTrends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupUpcomingShifts;
        private System.Windows.Forms.Button buttonViewDetails1;
        private System.Windows.Forms.Button buttonViewDetails2;
        private System.Windows.Forms.Button buttonViewDetails3;
        private System.Windows.Forms.GroupBox groupQuickActions;
        private System.Windows.Forms.Button buttonAcceptShift;
        private System.Windows.Forms.Button buttonCancelShift;
        private System.Windows.Forms.GroupBox groupNotifications;
        private System.Windows.Forms.Label labelNotification1;
        private System.Windows.Forms.Label labelNotification2;
        private System.Windows.Forms.GroupBox groupShiftTrends;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonExit;
    }
}
