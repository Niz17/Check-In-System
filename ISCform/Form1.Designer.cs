
namespace ISCform
{
    partial class CheckIn
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bottomMessage = new System.Windows.Forms.Label();
            this.studentCheckBox = new System.Windows.Forms.CheckBox();
            this.purposeLabel = new System.Windows.Forms.Label();
            this.purposeTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AccessibleName = "SignIn";
            this.button1.AllowDrop = true;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(247, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // label1
            // 
            this.label1.AccessibleName = "WelcomeLabel";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(36, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the International Student Center.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AcceptsReturn = true;
            this.emailTextBox.AccessibleName = "emailText";
            this.emailTextBox.Location = new System.Drawing.Point(247, 183);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(379, 22);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AccessibleName = "name";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.AccessibleName = "Idtext";
            this.textBox2.Location = new System.Drawing.Point(247, 140);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(379, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AccessibleName = "id";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "ID";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.AcceptsReturn = true;
            this.textBox3.AccessibleName = "nameText";
            this.textBox3.Location = new System.Drawing.Point(247, 269);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(379, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // bottomMessage
            // 
            this.bottomMessage.AutoSize = true;
            this.bottomMessage.Location = new System.Drawing.Point(354, 368);
            this.bottomMessage.Name = "bottomMessage";
            this.bottomMessage.Size = new System.Drawing.Size(10, 16);
            this.bottomMessage.TabIndex = 4;
            this.bottomMessage.Text = " ";
            this.bottomMessage.Click += new System.EventHandler(this.label5_Click);
            // 
            // studentCheckBox
            // 
            this.studentCheckBox.AutoSize = true;
            this.studentCheckBox.Location = new System.Drawing.Point(133, 311);
            this.studentCheckBox.Name = "studentCheckBox";
            this.studentCheckBox.Size = new System.Drawing.Size(107, 20);
            this.studentCheckBox.TabIndex = 5;
            this.studentCheckBox.Text = "Not a student";
            this.studentCheckBox.UseVisualStyleBackColor = true;
            this.studentCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // purposeLabel
            // 
            this.purposeLabel.AutoSize = true;
            this.purposeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purposeLabel.Location = new System.Drawing.Point(131, 220);
            this.purposeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.purposeLabel.Name = "purposeLabel";
            this.purposeLabel.Size = new System.Drawing.Size(92, 25);
            this.purposeLabel.TabIndex = 6;
            this.purposeLabel.Text = "Purpose";
            // 
            // purposeTextbox
            // 
            this.purposeTextbox.AcceptsReturn = true;
            this.purposeTextbox.AccessibleName = "emailText";
            this.purposeTextbox.Location = new System.Drawing.Point(247, 224);
            this.purposeTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.purposeTextbox.Name = "purposeTextbox";
            this.purposeTextbox.Size = new System.Drawing.Size(379, 22);
            this.purposeTextbox.TabIndex = 7;
            this.purposeTextbox.TextChanged += new System.EventHandler(this.purposeTextbox_TextChanged);
            // 
            // CheckIn
            // 
            this.AccessibleName = "btn_Signin";
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 434);
            this.Controls.Add(this.purposeTextbox);
            this.Controls.Add(this.purposeLabel);
            this.Controls.Add(this.studentCheckBox);
            this.Controls.Add(this.bottomMessage);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CheckIn";
            this.Text = "ISC Sign In ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label bottomMessage;
        private System.Windows.Forms.CheckBox studentCheckBox;
        private System.Windows.Forms.Label purposeLabel;
        private System.Windows.Forms.TextBox purposeTextbox;
    }
}

