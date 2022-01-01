
namespace ISCform
{
    partial class homepage
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
            this.checkInButton = new System.Windows.Forms.Button();
            this.viewClubsButton = new System.Windows.Forms.Button();
            this.viewEventsButton = new System.Windows.Forms.Button();
            this.trackVisitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkInButton
            // 
            this.checkInButton.AccessibleName = "CheckInButton";
            this.checkInButton.AllowDrop = true;
            this.checkInButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkInButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInButton.Location = new System.Drawing.Point(381, 143);
            this.checkInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(235, 28);
            this.checkInButton.TabIndex = 0;
            this.checkInButton.Text = "Check In";
            this.checkInButton.UseVisualStyleBackColor = false;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // viewClubsButton
            // 
            this.viewClubsButton.Location = new System.Drawing.Point(381, 247);
            this.viewClubsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewClubsButton.Name = "viewClubsButton";
            this.viewClubsButton.Size = new System.Drawing.Size(235, 28);
            this.viewClubsButton.TabIndex = 0;
            this.viewClubsButton.Text = "View Clubs";
            this.viewClubsButton.UseVisualStyleBackColor = true;
            // 
            // viewEventsButton
            // 
            this.viewEventsButton.Location = new System.Drawing.Point(381, 345);
            this.viewEventsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewEventsButton.Name = "viewEventsButton";
            this.viewEventsButton.Size = new System.Drawing.Size(235, 28);
            this.viewEventsButton.TabIndex = 0;
            this.viewEventsButton.Text = "View Events";
            this.viewEventsButton.UseVisualStyleBackColor = true;
            this.viewEventsButton.Click += new System.EventHandler(this.viewEventsButton_Click);
            // 
            // trackVisitButton
            // 
            this.trackVisitButton.AccessibleName = "trackVisitButton";
            this.trackVisitButton.AllowDrop = true;
            this.trackVisitButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.trackVisitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.trackVisitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackVisitButton.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackVisitButton.Location = new System.Drawing.Point(381, 438);
            this.trackVisitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackVisitButton.Name = "trackVisitButton";
            this.trackVisitButton.Size = new System.Drawing.Size(235, 28);
            this.trackVisitButton.TabIndex = 0;
            this.trackVisitButton.Text = "Track Visits";
            this.trackVisitButton.UseVisualStyleBackColor = true;
            this.trackVisitButton.Click += new System.EventHandler(this.trackVisitButton_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.trackVisitButton);
            this.Controls.Add(this.viewEventsButton);
            this.Controls.Add(this.viewClubsButton);
            this.Controls.Add(this.checkInButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "homepage";
            this.Text = "homepage";
            this.Load += new System.EventHandler(this.homepage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button viewClubsButton;
        private System.Windows.Forms.Button viewEventsButton;
        private System.Windows.Forms.Button trackVisitButton;
    }
}