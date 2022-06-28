namespace PNR_Contact_Tracing_Project
{
    partial class Form2
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
            this.lblDateSort = new System.Windows.Forms.Label();
            this.btnDateSort = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Readline = new System.Windows.Forms.Button();
            this.lblReadline = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDateSort
            // 
            this.lblDateSort.AutoSize = true;
            this.lblDateSort.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateSort.Location = new System.Drawing.Point(226, 178);
            this.lblDateSort.Name = "lblDateSort";
            this.lblDateSort.Size = new System.Drawing.Size(208, 17);
            this.lblDateSort.TabIndex = 7;
            this.lblDateSort.Text = "Shows the readline sorted by date";
            // 
            // btnDateSort
            // 
            this.btnDateSort.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDateSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateSort.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDateSort.Location = new System.Drawing.Point(226, 236);
            this.btnDateSort.Name = "btnDateSort";
            this.btnDateSort.Size = new System.Drawing.Size(318, 73);
            this.btnDateSort.TabIndex = 6;
            this.btnDateSort.Text = "Date Sort";
            this.btnDateSort.UseVisualStyleBackColor = false;
            this.btnDateSort.Click += new System.EventHandler(this.btnSortedDate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(226, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(318, 73);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // Readline
            // 
            this.Readline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Readline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Readline.Font = new System.Drawing.Font("Microsoft PhagsPa", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Readline.Location = new System.Drawing.Point(226, 92);
            this.Readline.Name = "Readline";
            this.Readline.Size = new System.Drawing.Size(315, 71);
            this.Readline.TabIndex = 10;
            this.Readline.Text = "Readline";
            this.Readline.UseVisualStyleBackColor = false;
            this.Readline.Click += new System.EventHandler(this.Readline_Click);
            // 
            // lblReadline
            // 
            this.lblReadline.AutoSize = true;
            this.lblReadline.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReadline.Location = new System.Drawing.Point(226, 72);
            this.lblReadline.Name = "lblReadline";
            this.lblReadline.Size = new System.Drawing.Size(245, 17);
            this.lblReadline.TabIndex = 11;
            this.lblReadline.Text = "Shows all of the data of the respondents";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(226, 198);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(318, 29);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblReadline);
            this.Controls.Add(this.Readline);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDateSort);
            this.Controls.Add(this.btnDateSort);
            this.Name = "Form2";
            this.Text = "Features";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblDateSort;
        private Button btnDateSort;
        private Button button3;
        private Button Readline;
        private Button btnExit;
        private Label lblReadline;
        private DateTimePicker dateTimePicker1;
    }
}