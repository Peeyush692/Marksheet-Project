namespace Marksheet_Project
{
    partial class AdminDashboard
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
            this.welcometext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roll = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcometext
            // 
            this.welcometext.AutoSize = true;
            this.welcometext.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcometext.Location = new System.Drawing.Point(261, 57);
            this.welcometext.Name = "welcometext";
            this.welcometext.Size = new System.Drawing.Size(267, 38);
            this.welcometext.TabIndex = 0;
            this.welcometext.Text = "Welcome Admin";
            this.welcometext.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Student Roll Number";
            // 
            // roll
            // 
            this.roll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roll.Location = new System.Drawing.Point(268, 209);
            this.roll.Name = "roll";
            this.roll.Size = new System.Drawing.Size(100, 41);
            this.roll.TabIndex = 2;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchbtn.Location = new System.Drawing.Point(401, 211);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(138, 39);
            this.searchbtn.TabIndex = 3;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.roll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcometext);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcometext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roll;
        private System.Windows.Forms.Button searchbtn;
    }
}