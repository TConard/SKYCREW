using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace SkyCrew
{
    partial class Admin
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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.headerLine = new System.Windows.Forms.Panel();
            this.pnlDataAnalytics = new System.Windows.Forms.Panel();
            this.lblDataAnalytics = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.pnlTrends = new System.Windows.Forms.Panel();
            this.chartTrends = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTrends = new System.Windows.Forms.Label();
            this.pnlNotifications = new System.Windows.Forms.Panel();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.listBoxNotifications = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();

            this.pnlDataAnalytics.SuspendLayout();
            this.pnlTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).BeginInit();
            this.pnlNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();

            // 
            // headerLine
            // 
            this.headerLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerLine.Location = new System.Drawing.Point(25, 50);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(800, 2);
            this.headerLine.TabIndex = 1;
            this.headerLine.BackColor = Color.Navy;

            // 
            // pnlDataAnalytics
            // 
            this.pnlDataAnalytics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataAnalytics.Controls.Add(this.lblDataAnalytics);
            this.pnlDataAnalytics.Controls.Add(this.btnGenerateReport);
            this.pnlDataAnalytics.Controls.Add(this.comboBoxReportType);
            this.pnlDataAnalytics.Location = new System.Drawing.Point(29, 124);
            this.pnlDataAnalytics.Name = "pnlDataAnalytics";
            this.pnlDataAnalytics.Size = new System.Drawing.Size(400, 150);
            this.pnlDataAnalytics.TabIndex = 2;
            this.pnlDataAnalytics.BackColor = Color.WhiteSmoke;

            // 
            // lblDataAnalytics
            // 
            this.lblDataAnalytics.AutoSize = true;
            this.lblDataAnalytics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDataAnalytics.Location = new System.Drawing.Point(10, 10);
            this.lblDataAnalytics.Name = "lblDataAnalytics";
            this.lblDataAnalytics.Size = new System.Drawing.Size(120, 21);
            this.lblDataAnalytics.TabIndex = 0;
            this.lblDataAnalytics.Text = "Data Analytics";
            this.lblDataAnalytics.ForeColor = Color.Navy;

            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(10, 90);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.BackColor = Color.Navy;
            this.btnGenerateReport.ForeColor = Color.White;
            this.btnGenerateReport.FlatStyle = FlatStyle.Flat;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);

            // 
            // comboBoxReportType
            // 
            this.comboBoxReportType.FormattingEnabled = true;
            this.comboBoxReportType.Items.AddRange(new object[] {
            "Flight Report",
            "Staff Report",
            "Bookings Report"});
            this.comboBoxReportType.Location = new System.Drawing.Point(10, 50);
            this.comboBoxReportType.Name = "comboBoxReportType";
            this.comboBoxReportType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxReportType.TabIndex = 10;

            // 
            // pnlTrends
            // 
            this.pnlTrends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrends.Controls.Add(this.chartTrends);
            this.pnlTrends.Controls.Add(this.lblTrends);
            this.pnlTrends.Location = new System.Drawing.Point(29, 290);
            this.pnlTrends.Name = "pnlTrends";
            this.pnlTrends.Size = new System.Drawing.Size(400, 250);
            this.pnlTrends.TabIndex = 3;
            this.pnlTrends.BackColor = Color.WhiteSmoke;

            // 
            // chartTrends
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTrends.ChartAreas.Add(chartArea1);
            this.chartTrends.Location = new System.Drawing.Point(10, 40);
            this.chartTrends.Name = "chartTrends";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Column;
            series1.Name = "Series1";
            this.chartTrends.Series.Add(series1);
            this.chartTrends.Size = new System.Drawing.Size(375, 200);
            this.chartTrends.TabIndex = 0;

            // 
            // lblTrends
            // 
            this.lblTrends.AutoSize = true;
            this.lblTrends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTrends.Location = new System.Drawing.Point(10, 10);
            this.lblTrends.Name = "lblTrends";
            this.lblTrends.Size = new System.Drawing.Size(120, 21);
            this.lblTrends.TabIndex = 1;
            this.lblTrends.Text = "Staffing Trends";
            this.lblTrends.ForeColor = Color.Navy;

            // 
            // pnlNotifications
            // 
            this.pnlNotifications.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotifications.Controls.Add(this.lblNotifications);
            this.pnlNotifications.Controls.Add(this.listBoxNotifications);
            this.pnlNotifications.Location = new System.Drawing.Point(450, 124);
            this.pnlNotifications.Name = "pnlNotifications";
            this.pnlNotifications.Size = new System.Drawing.Size(350, 300);
            this.pnlNotifications.TabIndex = 4;
            this.pnlNotifications.BackColor = Color.WhiteSmoke;

            // 
            // lblNotifications
            // 
            this.lblNotifications.AutoSize = true;
            this.lblNotifications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotifications.Location = new System.Drawing.Point(10, 10);
            this.lblNotifications.Name = "lblNotifications";
            this.lblNotifications.Size = new System.Drawing.Size(110, 21);
            this.lblNotifications.TabIndex = 0;
            this.lblNotifications.Text = "Notifications";
            this.lblNotifications.ForeColor = Color.Navy;

            // 
            // listBoxNotifications
            // 
            this.listBoxNotifications.FormattingEnabled = true;
            this.listBoxNotifications.ItemHeight = 20;
            this.listBoxNotifications.Location = new System.Drawing.Point(10, 40);
            this.listBoxNotifications.Name = "listBoxNotifications";
            this.listBoxNotifications.Size = new System.Drawing.Size(325, 244);
            this.listBoxNotifications.TabIndex = 1;

            // 
            // panel1
            // 
            this.panel1.BackColor = Color.Navy;
            this.panel1.Location = new System.Drawing.Point(25, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
            this.panel1.TabIndex = 5;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = Color.Navy;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "SkyCrew";

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = Color.Navy;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome back, Admin!";

            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = Color.DarkRed;
            this.buttonExit.Location = new System.Drawing.Point(825, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new EventHandler(this.buttonExit_Click);

            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.Location = new System.Drawing.Point(29, 550);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(770, 200);
            this.dataGridViewReport.TabIndex = 9;
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 
            // Admin
            // 
            this.ClientSize = new System.Drawing.Size(873, 780);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerLine);
            this.Controls.Add(this.pnlDataAnalytics);
            this.Controls.Add(this.pnlTrends);
            this.Controls.Add(this.pnlNotifications);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "SkyCrew - Admin Dashboard";
            this.pnlDataAnalytics.ResumeLayout(false);
            this.pnlDataAnalytics.PerformLayout();
            this.pnlTrends.ResumeLayout(false);
            this.pnlTrends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrends)).EndInit();
            this.pnlNotifications.ResumeLayout(false);
            this.pnlNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel headerLine;
        private System.Windows.Forms.Panel pnlDataAnalytics;
        private System.Windows.Forms.Label lblDataAnalytics;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxReportType;
        private System.Windows.Forms.Panel pnlTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrends;
        private System.Windows.Forms.Label lblTrends;
        private System.Windows.Forms.Panel pnlNotifications;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.ListBox listBoxNotifications;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button buttonExit;
        private DataGridView dataGridViewReport;
    }
}
