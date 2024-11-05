using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SkyCrew
{
    partial class Management
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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.groupOverviewStaff = new System.Windows.Forms.GroupBox();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.groupOverviewFlights = new System.Windows.Forms.GroupBox();
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.groupOverviewBookings = new System.Windows.Forms.GroupBox();
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.btnOpenPilotForm = new System.Windows.Forms.Button();
            this.btnOpenGroundCrewForm = new System.Windows.Forms.Button();
            this.btnOpenCustomerServiceForm = new System.Windows.Forms.Button();
            this.btnOpenAdminForm = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupOverviewStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.groupOverviewFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.groupOverviewBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            this.SuspendLayout();

            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(20, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(213, 28);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Management Overview";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Location = new System.Drawing.Point(25, 50);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 2);
            this.panelHeader.TabIndex = 1;

            // 
            // groupOverviewStaff
            // 
            this.groupOverviewStaff.Controls.Add(this.dataGridViewStaff);
            this.groupOverviewStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewStaff.Location = new System.Drawing.Point(25, 70);
            this.groupOverviewStaff.Name = "groupOverviewStaff";
            this.groupOverviewStaff.Size = new System.Drawing.Size(450, 200);
            this.groupOverviewStaff.TabIndex = 2;
            this.groupOverviewStaff.TabStop = false;
            this.groupOverviewStaff.Text = "Staff Overview";

            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(430, 160);
            this.dataGridViewStaff.TabIndex = 0;

            // 
            // groupOverviewFlights
            // 
            this.groupOverviewFlights.Controls.Add(this.dataGridViewFlights);
            this.groupOverviewFlights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewFlights.Location = new System.Drawing.Point(25, 280);
            this.groupOverviewFlights.Name = "groupOverviewFlights";
            this.groupOverviewFlights.Size = new System.Drawing.Size(450, 200);
            this.groupOverviewFlights.TabIndex = 3;
            this.groupOverviewFlights.TabStop = false;
            this.groupOverviewFlights.Text = "Flights Overview";

            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.Size = new System.Drawing.Size(430, 160);
            this.dataGridViewFlights.TabIndex = 0;

            // 
            // groupOverviewBookings
            // 
            this.groupOverviewBookings.Controls.Add(this.dataGridViewBookings);
            this.groupOverviewBookings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewBookings.Location = new System.Drawing.Point(500, 70);
            this.groupOverviewBookings.Name = "groupOverviewBookings";
            this.groupOverviewBookings.Size = new System.Drawing.Size(450, 410);
            this.groupOverviewBookings.TabIndex = 4;
            this.groupOverviewBookings.TabStop = false;
            this.groupOverviewBookings.Text = "Bookings Overview";

            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.Size = new System.Drawing.Size(430, 370);
            this.dataGridViewBookings.TabIndex = 0;

            // 
            // btnOpenPilotForm
            // 
            this.btnOpenPilotForm.Location = new System.Drawing.Point(25, 500);
            this.btnOpenPilotForm.Name = "btnOpenPilotForm";
            this.btnOpenPilotForm.Size = new System.Drawing.Size(100, 30);
            this.btnOpenPilotForm.TabIndex = 5;
            this.btnOpenPilotForm.Text = "Open Pilot Form";
            this.btnOpenPilotForm.UseVisualStyleBackColor = true;

            // 
            // btnOpenGroundCrewForm
            // 
            this.btnOpenGroundCrewForm.Location = new System.Drawing.Point(140, 500);
            this.btnOpenGroundCrewForm.Name = "btnOpenGroundCrewForm";
            this.btnOpenGroundCrewForm.Size = new System.Drawing.Size(130, 30);
            this.btnOpenGroundCrewForm.TabIndex = 6;
            this.btnOpenGroundCrewForm.Text = "Open Ground Crew";
            this.btnOpenGroundCrewForm.UseVisualStyleBackColor = true;

            // 
            // btnOpenCustomerServiceForm
            // 
            this.btnOpenCustomerServiceForm.Location = new System.Drawing.Point(290, 500);
            this.btnOpenCustomerServiceForm.Name = "btnOpenCustomerServiceForm";
            this.btnOpenCustomerServiceForm.Size = new System.Drawing.Size(140, 30);
            this.btnOpenCustomerServiceForm.TabIndex = 7;
            this.btnOpenCustomerServiceForm.Text = "Open Customer Service";
            this.btnOpenCustomerServiceForm.UseVisualStyleBackColor = true;

            // 
            // btnOpenAdminForm
            // 
            this.btnOpenAdminForm.Location = new System.Drawing.Point(450, 500);
            this.btnOpenAdminForm.Name = "btnOpenAdminForm";
            this.btnOpenAdminForm.Size = new System.Drawing.Size(100, 30);
            this.btnOpenAdminForm.TabIndex = 8;
            this.btnOpenAdminForm.Text = "Open Admin";
            this.btnOpenAdminForm.UseVisualStyleBackColor = true;

            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonExit.Location = new System.Drawing.Point(870, 10);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(36, 36);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = true;

            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.btnOpenAdminForm);
            this.Controls.Add(this.btnOpenCustomerServiceForm);
            this.Controls.Add(this.btnOpenGroundCrewForm);
            this.Controls.Add(this.btnOpenPilotForm);
            this.Controls.Add(this.groupOverviewBookings);
            this.Controls.Add(this.groupOverviewFlights);
            this.Controls.Add(this.groupOverviewStaff);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementForm";
            this.Text = "Management Overview";
            this.groupOverviewStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.groupOverviewFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.groupOverviewBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.GroupBox groupOverviewStaff;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.GroupBox groupOverviewFlights;
        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.GroupBox groupOverviewBookings;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.Button btnOpenPilotForm;
        private System.Windows.Forms.Button btnOpenGroundCrewForm;
        private System.Windows.Forms.Button btnOpenCustomerServiceForm;
        private System.Windows.Forms.Button btnOpenAdminForm;
        private System.Windows.Forms.Button buttonExit;
    }
}
