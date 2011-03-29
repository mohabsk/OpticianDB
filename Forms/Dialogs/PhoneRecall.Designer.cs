/*
 * Copyright (c) 2011 Geoffrey Prytherch
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this
 * software and associated documentation files (the "Software"), to deal in the Software
 * without restriction, including without limitation the rights to use, copy, modify, merge,
 * publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
 * to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
 * INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
 * PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
 * FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
 * OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE.
 */
namespace OpticianDB.Forms.Dialogs
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
            this.telNum_Label = new System.Windows.Forms.Label();
            this.noAnswer_Button = new System.Windows.Forms.Button();
            this.cal_Calendar = new System.Windows.Forms.MonthCalendar();
            this.removeRecall_Button = new System.Windows.Forms.Button();
            this.checkApmts_Button = new System.Windows.Forms.Button();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.name_Label = new System.Windows.Forms.Label();
            this.reason_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telNum_Label
            // 
            this.telNum_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.telNum_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.telNum_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telNum_Label.Location = new System.Drawing.Point(12, 9);
            this.telNum_Label.Name = "telNum_Label";
            this.telNum_Label.Size = new System.Drawing.Size(341, 57);
            this.telNum_Label.TabIndex = 0;
            this.telNum_Label.Text = "01234-567890";
            this.telNum_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noAnswer_Button
            // 
            this.noAnswer_Button.Location = new System.Drawing.Point(11, 173);
            this.noAnswer_Button.Name = "noAnswer_Button";
            this.noAnswer_Button.Size = new System.Drawing.Size(169, 23);
            this.noAnswer_Button.TabIndex = 1;
            this.noAnswer_Button.Text = "No Answer/Callback Tomorrow";
            this.noAnswer_Button.UseVisualStyleBackColor = true;
            // 
            // cal_Calendar
            // 
            this.cal_Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cal_Calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.cal_Calendar.Location = new System.Drawing.Point(69, 208);
            this.cal_Calendar.MaxSelectionCount = 1;
            this.cal_Calendar.Name = "cal_Calendar";
            this.cal_Calendar.TabIndex = 2;
            // 
            // removeRecall_Button
            // 
            this.removeRecall_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.removeRecall_Button.Location = new System.Drawing.Point(190, 173);
            this.removeRecall_Button.Name = "removeRecall_Button";
            this.removeRecall_Button.Size = new System.Drawing.Size(163, 23);
            this.removeRecall_Button.TabIndex = 3;
            this.removeRecall_Button.Text = "Remove Recall From Database";
            this.removeRecall_Button.UseVisualStyleBackColor = true;
            // 
            // checkApmts_Button
            // 
            this.checkApmts_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkApmts_Button.Location = new System.Drawing.Point(12, 384);
            this.checkApmts_Button.Name = "checkApmts_Button";
            this.checkApmts_Button.Size = new System.Drawing.Size(168, 23);
            this.checkApmts_Button.TabIndex = 4;
            this.checkApmts_Button.Text = "Check Appointments on Date";
            this.checkApmts_Button.UseVisualStyleBackColor = true;
            this.checkApmts_Button.Click += new System.EventHandler(this.checkApmts_Button_Click);
            // 
            // confirm_Button
            // 
            this.confirm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_Button.Location = new System.Drawing.Point(229, 384);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(124, 23);
            this.confirm_Button.TabIndex = 5;
            this.confirm_Button.Text = "Confirm Appointment";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.Confirm_ButtonClick);
            // 
            // name_Label
            // 
            this.name_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Label.Location = new System.Drawing.Point(11, 66);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(342, 52);
            this.name_Label.TabIndex = 6;
            this.name_Label.Text = "MR TEST USER";
            this.name_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reason_Label
            // 
            this.reason_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.reason_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reason_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason_Label.Location = new System.Drawing.Point(11, 118);
            this.reason_Label.Name = "reason_Label";
            this.reason_Label.Size = new System.Drawing.Size(342, 52);
            this.reason_Label.TabIndex = 7;
            this.reason_Label.Text = "BOOK APPOINTMENT";
            this.reason_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PhoneRecall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 415);
            this.Controls.Add(this.reason_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.confirm_Button);
            this.Controls.Add(this.checkApmts_Button);
            this.Controls.Add(this.removeRecall_Button);
            this.Controls.Add(this.cal_Calendar);
            this.Controls.Add(this.noAnswer_Button);
            this.Controls.Add(this.telNum_Label);
            this.Name = "PhoneRecall";
            this.Text = "Phone Recall";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Button confirm_Button;
        private System.Windows.Forms.Button checkApmts_Button;
        private System.Windows.Forms.Button removeRecall_Button;
        private System.Windows.Forms.MonthCalendar cal_Calendar;
        private System.Windows.Forms.Button noAnswer_Button;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label telNum_Label;
        private System.Windows.Forms.Label reason_Label;

        #endregion

    }
}