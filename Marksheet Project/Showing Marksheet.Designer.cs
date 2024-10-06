namespace Marksheet_Project
{
    partial class Showing_Marksheet
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
            this.stdname2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblpercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stdname2
            // 
            this.stdname2.AutoSize = true;
            this.stdname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdname2.Location = new System.Drawing.Point(255, 22);
            this.stdname2.Name = "stdname2";
            this.stdname2.Size = new System.Drawing.Size(284, 29);
            this.stdname2.TabIndex = 1;
            this.stdname2.Text = "SHOWING MARKSHEET";
            this.stdname2.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(507, 312);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveChanges.Location = new System.Drawing.Point(126, 412);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(169, 45);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(339, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Location = new System.Drawing.Point(156, 357);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(77, 16);
            this.lblpercentage.TabIndex = 5;
            this.lblpercentage.Text = "Percentage";
            // 
            // Showing_Marksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.lblpercentage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stdname2);
            this.Name = "Showing_Marksheet";
            this.Text = "Showing_Marksheet";
            this.Load += new System.EventHandler(this.Showing_Marksheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label stdname2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblpercentage;
    }
}