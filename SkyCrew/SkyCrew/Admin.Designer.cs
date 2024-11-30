using System;
using System.Windows.Forms;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.headerLine = new System.Windows.Forms.Panel();
            this.pnlDataAnalytics = new System.Windows.Forms.Panel();
            this.lblDataAnalytics = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxReportType = new System.Windows.Forms.ComboBox();
            this.pnlTrends = new System.Windows.Forms.Panel();
            this.chartReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTrends = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlDataAnalytics.SuspendLayout();
            this.pnlTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLine
            // 
            this.headerLine.BackColor = System.Drawing.Color.Navy;
            this.headerLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.headerLine.Location = new System.Drawing.Point(25, 50);
            this.headerLine.Name = "headerLine";
            this.headerLine.Size = new System.Drawing.Size(800, 2);
            this.headerLine.TabIndex = 1;
            // 
            // pnlDataAnalytics
            // 
            this.pnlDataAnalytics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDataAnalytics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataAnalytics.Controls.Add(this.lblDataAnalytics);
            this.pnlDataAnalytics.Controls.Add(this.btnGenerateReport);
            this.pnlDataAnalytics.Controls.Add(this.comboBoxReportType);
            this.pnlDataAnalytics.Location = new System.Drawing.Point(29, 124);
            this.pnlDataAnalytics.Name = "pnlDataAnalytics";
            this.pnlDataAnalytics.Size = new System.Drawing.Size(800, 150);
            this.pnlDataAnalytics.TabIndex = 2;
            // 
            // lblDataAnalytics
            // 
            this.lblDataAnalytics.AutoSize = true;
            this.lblDataAnalytics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDataAnalytics.ForeColor = System.Drawing.Color.Navy;
            this.lblDataAnalytics.Location = new System.Drawing.Point(10, 10);
            this.lblDataAnalytics.Name = "lblDataAnalytics";
            this.lblDataAnalytics.Size = new System.Drawing.Size(120, 21);
            this.lblDataAnalytics.TabIndex = 0;
            this.lblDataAnalytics.Text = "Data Analytics";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Navy;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(10, 90);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateReport.TabIndex = 1;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
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
            this.pnlTrends.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTrends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTrends.Controls.Add(this.chartReport);
            this.pnlTrends.Controls.Add(this.lblTrends);
            this.pnlTrends.Location = new System.Drawing.Point(29, 290);
            this.pnlTrends.Name = "pnlTrends";
            this.pnlTrends.Size = new System.Drawing.Size(800, 300);
            this.pnlTrends.TabIndex = 3;
            // 
            // chartReport
            // 
            chartArea5.Name = "Default";
            this.chartReport.ChartAreas.Add(chartArea5);
            this.chartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "MainLegend";
            this.chartReport.Legends.Add(legend5);
            this.chartReport.Location = new System.Drawing.Point(0, 0);
            this.chartReport.Name = "chartReport";
            this.chartReport.Size = new System.Drawing.Size(798, 298);
            this.chartReport.TabIndex = 2;
            this.chartReport.Text = "chartReport";
            // 
            // lblTrends
            // 
            this.lblTrends.AutoSize = true;
            this.lblTrends.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTrends.ForeColor = System.Drawing.Color.Navy;
            this.lblTrends.Location = new System.Drawing.Point(10, 10);
            this.lblTrends.Name = "lblTrends";
            this.lblTrends.Size = new System.Drawing.Size(125, 21);
            this.lblTrends.TabIndex = 1;
            this.lblTrends.Text = "Data Visualizer";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewReport.ColumnHeadersHeight = 34;
            this.dataGridViewReport.Location = new System.Drawing.Point(29, 600);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.RowHeadersWidth = 62;
            this.dataGridViewReport.Size = new System.Drawing.Size(800, 200);
            this.dataGridViewReport.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "LNB Airlines";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Location = new System.Drawing.Point(13, 51);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 2);
            this.panelHeader.TabIndex = 11;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(823, 9);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(37, 37);
            this.buttonExit.TabIndex = 12;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(27, 93);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(220, 28);
            this.lblWelcome.TabIndex = 13;
            this.lblWelcome.Text = "Welcome back, Emily!";
            // 
            // Admin
            // 
            this.ClientSize = new System.Drawing.Size(873, 820);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewReport);
            this.Controls.Add(this.pnlDataAnalytics);
            this.Controls.Add(this.pnlTrends);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.Text = "Admin Dashboard";
            this.pnlDataAnalytics.ResumeLayout(false);
            this.pnlDataAnalytics.PerformLayout();
            this.pnlTrends.ResumeLayout(false);
            this.pnlTrends.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartReport)).EndInit();
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
        private System.Windows.Forms.Label lblTrends;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReport;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private Label label1;
        private Panel panelHeader;
        private Button buttonExit;
        private Label lblWelcome;
    }
}
