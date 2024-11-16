using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupUpcomingShifts = new System.Windows.Forms.GroupBox();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.groupQuickActions.SuspendLayout();
            this.groupNotifications.SuspendLayout();
            this.groupShiftTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(28, 92);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(315, 41);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome back, John!";
            // 
            // groupUpcomingShifts
            // 
            this.groupUpcomingShifts.BackColor = System.Drawing.Color.White;
            this.groupUpcomingShifts.Controls.Add(this.dataGridViewShifts);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails1);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails2);
            this.groupUpcomingShifts.Controls.Add(this.button1);
            this.groupUpcomingShifts.Controls.Add(this.buttonViewDetails3);
            this.groupUpcomingShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupUpcomingShifts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupUpcomingShifts.Location = new System.Drawing.Point(33, 137);
            this.groupUpcomingShifts.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupUpcomingShifts.Name = "groupUpcomingShifts";
            this.groupUpcomingShifts.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.groupUpcomingShifts.Size = new System.Drawing.Size(474, 397);
            this.groupUpcomingShifts.TabIndex = 1;
            this.groupUpcomingShifts.TabStop = false;
            this.groupUpcomingShifts.Text = "Upcoming Shifts";
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(21, 49);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.Size = new System.Drawing.Size(335, 312);
            this.dataGridViewShifts.TabIndex = 5;
            // 
            // buttonViewDetails1
            // 
            this.buttonViewDetails1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails1.Location = new System.Drawing.Point(362, 49);
            this.buttonViewDetails1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonViewDetails1.Name = "buttonViewDetails1";
            this.buttonViewDetails1.Size = new System.Drawing.Size(112, 38);
            this.buttonViewDetails1.TabIndex = 2;
            this.buttonViewDetails1.Text = "Details";
            this.buttonViewDetails1.UseVisualStyleBackColor = true;
            // 
            // buttonViewDetails2
            // 
            this.buttonViewDetails2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails2.Location = new System.Drawing.Point(362, 100);
            this.buttonViewDetails2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonViewDetails2.Name = "buttonViewDetails2";
            this.buttonViewDetails2.Size = new System.Drawing.Size(112, 38);
            this.buttonViewDetails2.TabIndex = 3;
            this.buttonViewDetails2.Text = "Details";
            this.buttonViewDetails2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(362, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonViewDetails3
            // 
            this.buttonViewDetails3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewDetails3.Location = new System.Drawing.Point(362, 196);
            this.buttonViewDetails3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonViewDetails3.Name = "buttonViewDetails3";
            this.buttonViewDetails3.Size = new System.Drawing.Size(112, 38);
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
            this.groupQuickActions.Location = new System.Drawing.Point(542, 137);
            this.groupQuickActions.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupQuickActions.Name = "groupQuickActions";
            this.groupQuickActions.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.groupQuickActions.Size = new System.Drawing.Size(492, 397);
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
            this.buttonAcceptShift.Location = new System.Drawing.Point(22, 69);
            this.buttonAcceptShift.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAcceptShift.Name = "buttonAcceptShift";
            this.buttonAcceptShift.Padding = new System.Windows.Forms.Padding(6);
            this.buttonAcceptShift.Size = new System.Drawing.Size(242, 100);
            this.buttonAcceptShift.TabIndex = 3;
            this.buttonAcceptShift.Text = "Accept Shift";
            this.buttonAcceptShift.UseVisualStyleBackColor = false;
            this.buttonAcceptShift.Click += new System.EventHandler(this.buttonAcceptShift_Click);
            // 
            // buttonCancelShift
            // 
            this.buttonCancelShift.BackColor = System.Drawing.Color.White;
            this.buttonCancelShift.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.buttonCancelShift.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonCancelShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelShift.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonCancelShift.Location = new System.Drawing.Point(22, 229);
            this.buttonCancelShift.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCancelShift.Name = "buttonCancelShift";
            this.buttonCancelShift.Padding = new System.Windows.Forms.Padding(6);
            this.buttonCancelShift.Size = new System.Drawing.Size(242, 100);
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
            this.groupNotifications.Location = new System.Drawing.Point(542, 557);
            this.groupNotifications.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupNotifications.Name = "groupNotifications";
            this.groupNotifications.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.groupNotifications.Size = new System.Drawing.Size(492, 262);
            this.groupNotifications.TabIndex = 3;
            this.groupNotifications.TabStop = false;
            this.groupNotifications.Text = "Notifications";
            // 
            // labelNotification1
            // 
            this.labelNotification1.AutoSize = true;
            this.labelNotification1.Location = new System.Drawing.Point(22, 38);
            this.labelNotification1.Name = "labelNotification1";
            this.labelNotification1.Size = new System.Drawing.Size(195, 28);
            this.labelNotification1.TabIndex = 1;
            this.labelNotification1.Text = "New shift available";
            // 
            // labelNotification2
            // 
            this.labelNotification2.AutoSize = true;
            this.labelNotification2.Location = new System.Drawing.Point(22, 75);
            this.labelNotification2.Name = "labelNotification2";
            this.labelNotification2.Size = new System.Drawing.Size(226, 28);
            this.labelNotification2.TabIndex = 2;
            this.labelNotification2.Text = "Schedule change for ...";
            // 
            // groupShiftTrends
            // 
            this.groupShiftTrends.BackColor = System.Drawing.Color.White;
            this.groupShiftTrends.Controls.Add(this.chart1);
            this.groupShiftTrends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupShiftTrends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupShiftTrends.Location = new System.Drawing.Point(33, 557);
            this.groupShiftTrends.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupShiftTrends.Name = "groupShiftTrends";
            this.groupShiftTrends.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.groupShiftTrends.Size = new System.Drawing.Size(474, 262);
            this.groupShiftTrends.TabIndex = 4;
            this.groupShiftTrends.TabStop = false;
            this.groupShiftTrends.Text = "Shift Availability Trends";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(21, 43);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(440, 203);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(26, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "SkyCrew";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(33, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 2);
            this.panel1.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(1238, 8);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(54, 55);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // GroundCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1310, 863);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupShiftTrends);
            this.Controls.Add(this.groupNotifications);
            this.Controls.Add(this.groupQuickActions);
            this.Controls.Add(this.groupUpcomingShifts);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "GroundCrew";
            this.groupUpcomingShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewShifts;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}
