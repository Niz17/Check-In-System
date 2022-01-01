
namespace ISCform
{
    partial class trackvisit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeeVisitsButton = new System.Windows.Forms.Button();
            this.StudentVisitsButton = new System.Windows.Forms.Button();
            this.OtherVisitsButton = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.otherDetails = new System.Windows.Forms.Label();
            this.stats = new System.Windows.Forms.Label();
            this.employeeStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeeVisitsButton
            // 
            this.EmployeeVisitsButton.Location = new System.Drawing.Point(452, 200);
            this.EmployeeVisitsButton.Margin = new System.Windows.Forms.Padding(4);
            this.EmployeeVisitsButton.Name = "EmployeeVisitsButton";
            this.EmployeeVisitsButton.Size = new System.Drawing.Size(180, 28);
            this.EmployeeVisitsButton.TabIndex = 0;
            this.EmployeeVisitsButton.Text = "Export Employee Visits";
            this.EmployeeVisitsButton.UseVisualStyleBackColor = true;
            this.EmployeeVisitsButton.Click += new System.EventHandler(this.EmployeeVisitsButton_Click);
            // 
            // StudentVisitsButton
            // 
            this.StudentVisitsButton.Location = new System.Drawing.Point(452, 76);
            this.StudentVisitsButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentVisitsButton.Name = "StudentVisitsButton";
            this.StudentVisitsButton.Size = new System.Drawing.Size(180, 28);
            this.StudentVisitsButton.TabIndex = 0;
            this.StudentVisitsButton.Text = "Export Student Visits";
            this.StudentVisitsButton.UseVisualStyleBackColor = true;
            this.StudentVisitsButton.Click += new System.EventHandler(this.StudentVisitsButton_Click);
            // 
            // OtherVisitsButton
            // 
            this.OtherVisitsButton.Location = new System.Drawing.Point(452, 314);
            this.OtherVisitsButton.Margin = new System.Windows.Forms.Padding(4);
            this.OtherVisitsButton.Name = "OtherVisitsButton";
            this.OtherVisitsButton.Size = new System.Drawing.Size(180, 28);
            this.OtherVisitsButton.TabIndex = 0;
            this.OtherVisitsButton.Text = "Export Other Visits";
            this.OtherVisitsButton.UseVisualStyleBackColor = true;
            this.OtherVisitsButton.Click += new System.EventHandler(this.OtherVisitsButton_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(277, 502);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 16);
            this.message.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Student Visits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // otherDetails
            // 
            this.otherDetails.AutoSize = true;
            this.otherDetails.Location = new System.Drawing.Point(462, 356);
            this.otherDetails.Name = "otherDetails";
            this.otherDetails.Size = new System.Drawing.Size(44, 16);
            this.otherDetails.TabIndex = 3;
            this.otherDetails.Text = "label2";
            // 
            // stats
            // 
            this.stats.AutoSize = true;
            this.stats.Location = new System.Drawing.Point(122, 145);
            this.stats.Name = "stats";
            this.stats.Size = new System.Drawing.Size(44, 16);
            this.stats.TabIndex = 4;
            this.stats.Text = "label2";
            // 
            // employeeStats
            // 
            this.employeeStats.AutoSize = true;
            this.employeeStats.Location = new System.Drawing.Point(465, 236);
            this.employeeStats.Name = "employeeStats";
            this.employeeStats.Size = new System.Drawing.Size(44, 16);
            this.employeeStats.TabIndex = 5;
            this.employeeStats.Text = "label2";
            // 
            // trackvisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.employeeStats);
            this.Controls.Add(this.stats);
            this.Controls.Add(this.otherDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.OtherVisitsButton);
            this.Controls.Add(this.StudentVisitsButton);
            this.Controls.Add(this.EmployeeVisitsButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "trackvisit";
            this.Text = "trackvisit";
            this.Load += new System.EventHandler(this.trackvisit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EmployeeVisitsButton; 
        private System.Windows.Forms.Button StudentVisitsButton;
        private System.Windows.Forms.Button OtherVisitsButton;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label otherDetails;
        private System.Windows.Forms.Label stats;
        private System.Windows.Forms.Label employeeStats;
    }
}