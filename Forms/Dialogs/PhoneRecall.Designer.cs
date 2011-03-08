namespace OpticianDB
{
    partial class PhoneRecall
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.button1 = new System.Windows.Forms.Button();
        	this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(12, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(339, 57);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "01234-567890";
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(11, 173);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(169, 23);
        	this.button1.TabIndex = 1;
        	this.button1.Text = "No Answer/Callback Tomorrow";
        	this.button1.UseVisualStyleBackColor = true;
        	// 
        	// monthCalendar1
        	// 
        	this.monthCalendar1.Location = new System.Drawing.Point(85, 208);
        	this.monthCalendar1.Name = "monthCalendar1";
        	this.monthCalendar1.TabIndex = 2;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(187, 173);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(163, 23);
        	this.button2.TabIndex = 3;
        	this.button2.Text = "Remove Recall From Database";
        	this.button2.UseVisualStyleBackColor = true;
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(12, 374);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(168, 23);
        	this.button3.TabIndex = 4;
        	this.button3.Text = "Check Appointments on Date";
        	this.button3.UseVisualStyleBackColor = true;
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(226, 374);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(124, 23);
        	this.button4.TabIndex = 5;
        	this.button4.Text = "Confirm Appointment";
        	this.button4.UseVisualStyleBackColor = true;
        	// 
        	// label2
        	// 
        	this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(11, 66);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(338, 52);
        	this.label2.TabIndex = 6;
        	this.label2.Text = "MR TEST USER";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// label3
        	// 
        	this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(11, 118);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(338, 52);
        	this.label3.TabIndex = 7;
        	this.label3.Text = "BOOK APPOINTMENT";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        	// 
        	// PhoneRecall
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(365, 405);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.monthCalendar1);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.label1);
        	this.Name = "PhoneRecall";
        	this.Text = "Phone Recall";
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label3;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
    }
}