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
            this.labelWelcome = new System.Windows.Forms.Label();
            this.groupUpcomingShifts = new System.Windows.Forms.GroupBox();
            this.dataGridViewShifts = new System.Windows.Forms.DataGridView();
            this.groupQuickActions = new System.Windows.Forms.GroupBox();
            this.buttonAcceptShift = new System.Windows.Forms.Button();
            this.buttonCancelShift = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupUpcomingShifts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).BeginInit();
            this.groupQuickActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.labelWelcome.ForeColor = System.Drawing.Color.Navy;
            this.labelWelcome.Location = new System.Drawing.Point(19, 60);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(211, 28);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome back, Jane!";
            // 
            // groupUpcomingShifts
            // 
            this.groupUpcomingShifts.BackColor = System.Drawing.Color.White;
            this.groupUpcomingShifts.Controls.Add(this.dataGridViewShifts);
            this.groupUpcomingShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupUpcomingShifts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupUpcomingShifts.Location = new System.Drawing.Point(22, 89);
            this.groupUpcomingShifts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupUpcomingShifts.Name = "groupUpcomingShifts";
            this.groupUpcomingShifts.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupUpcomingShifts.Size = new System.Drawing.Size(507, 443);
            this.groupUpcomingShifts.TabIndex = 1;
            this.groupUpcomingShifts.TabStop = false;
            this.groupUpcomingShifts.Text = "Upcoming Shifts";
            // 
            // dataGridViewShifts
            // 
            this.dataGridViewShifts.AllowUserToAddRows = false;
            this.dataGridViewShifts.AllowUserToDeleteRows = false;
            this.dataGridViewShifts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewShifts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShifts.Location = new System.Drawing.Point(9, 27);
            this.dataGridViewShifts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewShifts.Name = "dataGridViewShifts";
            this.dataGridViewShifts.ReadOnly = true;
            this.dataGridViewShifts.RowHeadersWidth = 62;
            this.dataGridViewShifts.Size = new System.Drawing.Size(489, 406);
            this.dataGridViewShifts.TabIndex = 5;
            // 
            // groupQuickActions
            // 
            this.groupQuickActions.BackColor = System.Drawing.Color.White;
            this.groupQuickActions.Controls.Add(this.buttonAcceptShift);
            this.groupQuickActions.Controls.Add(this.buttonCancelShift);
            this.groupQuickActions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupQuickActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupQuickActions.Location = new System.Drawing.Point(533, 89);
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
            this.buttonAcceptShift.Click += new System.EventHandler(this.buttonAcceptShift_Click);
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
            this.buttonCancelShift.Text = "Drop Shift";
            this.buttonCancelShift.UseVisualStyleBackColor = false;
            this.buttonCancelShift.Click += new System.EventHandler(this.buttonCancelShift_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(17, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "LNB Airlines";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(22, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 2);
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
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(533, 359);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // GroundCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(873, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupQuickActions);
            this.Controls.Add(this.groupUpcomingShifts);
            this.Controls.Add(this.labelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GroundCrew";
            this.groupUpcomingShifts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShifts)).EndInit();
            this.groupQuickActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.GroupBox groupUpcomingShifts;
        private System.Windows.Forms.DataGridView dataGridViewShifts;
        private System.Windows.Forms.GroupBox groupQuickActions;
        private System.Windows.Forms.Button buttonAcceptShift;
        private System.Windows.Forms.Button buttonCancelShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExit;
        private MonthCalendar monthCalendar1;
    }
}
