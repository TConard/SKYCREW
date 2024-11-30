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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupOverviewStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.groupOverviewFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.groupOverviewBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(18, 10);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(173, 37);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "LNB Airlines";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Navy;
            this.panelHeader.Location = new System.Drawing.Point(25, 50);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(880, 2);
            this.panelHeader.TabIndex = 1;
            // 
            // groupOverviewStaff
            // 
            this.groupOverviewStaff.Controls.Add(this.dataGridViewStaff);
            this.groupOverviewStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewStaff.Location = new System.Drawing.Point(25, 110);
            this.groupOverviewStaff.Name = "groupOverviewStaff";
            this.groupOverviewStaff.Size = new System.Drawing.Size(450, 200);
            this.groupOverviewStaff.TabIndex = 2;
            this.groupOverviewStaff.TabStop = false;
            this.groupOverviewStaff.Text = "Staff Overview";
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.RowHeadersWidth = 62;
            this.dataGridViewStaff.Size = new System.Drawing.Size(430, 160);
            this.dataGridViewStaff.TabIndex = 0;
            // 
            // groupOverviewFlights
            // 
            this.groupOverviewFlights.Controls.Add(this.dataGridViewFlights);
            this.groupOverviewFlights.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewFlights.Location = new System.Drawing.Point(25, 307);
            this.groupOverviewFlights.Name = "groupOverviewFlights";
            this.groupOverviewFlights.Size = new System.Drawing.Size(450, 200);
            this.groupOverviewFlights.TabIndex = 3;
            this.groupOverviewFlights.TabStop = false;
            this.groupOverviewFlights.Text = "Flights Overview";
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.RowHeadersWidth = 62;
            this.dataGridViewFlights.Size = new System.Drawing.Size(430, 160);
            this.dataGridViewFlights.TabIndex = 0;
            // 
            // groupOverviewBookings
            // 
            this.groupOverviewBookings.Controls.Add(this.dataGridViewBookings);
            this.groupOverviewBookings.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupOverviewBookings.Location = new System.Drawing.Point(500, 110);
            this.groupOverviewBookings.Name = "groupOverviewBookings";
            this.groupOverviewBookings.Size = new System.Drawing.Size(425, 370);
            this.groupOverviewBookings.TabIndex = 4;
            this.groupOverviewBookings.TabStop = false;
            this.groupOverviewBookings.Text = "Bookings Overview";
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            this.dataGridViewBookings.RowHeadersWidth = 62;
            this.dataGridViewBookings.Size = new System.Drawing.Size(419, 340);
            this.dataGridViewBookings.TabIndex = 0;
            // 
            // btnOpenPilotForm
            // 
            this.btnOpenPilotForm.Location = new System.Drawing.Point(25, 513);
            this.btnOpenPilotForm.Name = "btnOpenPilotForm";
            this.btnOpenPilotForm.Size = new System.Drawing.Size(100, 30);
            this.btnOpenPilotForm.TabIndex = 5;
            this.btnOpenPilotForm.Text = "Open Pilot Form";
            this.btnOpenPilotForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenGroundCrewForm
            // 
            this.btnOpenGroundCrewForm.Location = new System.Drawing.Point(140, 513);
            this.btnOpenGroundCrewForm.Name = "btnOpenGroundCrewForm";
            this.btnOpenGroundCrewForm.Size = new System.Drawing.Size(130, 30);
            this.btnOpenGroundCrewForm.TabIndex = 6;
            this.btnOpenGroundCrewForm.Text = "Open Ground Crew";
            this.btnOpenGroundCrewForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenCustomerServiceForm
            // 
            this.btnOpenCustomerServiceForm.Location = new System.Drawing.Point(288, 513);
            this.btnOpenCustomerServiceForm.Name = "btnOpenCustomerServiceForm";
            this.btnOpenCustomerServiceForm.Size = new System.Drawing.Size(140, 30);
            this.btnOpenCustomerServiceForm.TabIndex = 7;
            this.btnOpenCustomerServiceForm.Text = "Open Customer Service";
            this.btnOpenCustomerServiceForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenAdminForm
            // 
            this.btnOpenAdminForm.Location = new System.Drawing.Point(444, 513);
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
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::SkyCrew.Properties.Resources.Screenshot_2024_11_21_134806;
            this.pictureBox1.Location = new System.Drawing.Point(881, 486);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "Welcome back, Jake!";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
            this.Name = "Management";
            this.Text = "Management Overview";
            this.groupOverviewStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.groupOverviewFlights.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.groupOverviewBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}
