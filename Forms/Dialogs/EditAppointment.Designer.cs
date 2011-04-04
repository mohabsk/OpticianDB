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
    partial class EditAppointment
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.remarks_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.start_DateTime = new System.Windows.Forms.DateTimePicker();
            this.end_DateTime = new System.Windows.Forms.DateTimePicker();
            this.optician_ComboBox = new System.Windows.Forms.ComboBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.remarks_Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.start_DateTime, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.end_DateTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.optician_ComboBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(237, 106);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // remarks_Text
            // 
            this.remarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarks_Text.Location = new System.Drawing.Point(58, 55);
            this.remarks_Text.Name = "remarks_Text";
            this.remarks_Text.Size = new System.Drawing.Size(176, 20);
            this.remarks_Text.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Remarks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Optician";
            // 
            // start_DateTime
            // 
            this.start_DateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.start_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_DateTime.Location = new System.Drawing.Point(58, 3);
            this.start_DateTime.Name = "start_DateTime";
            this.start_DateTime.Size = new System.Drawing.Size(176, 20);
            this.start_DateTime.TabIndex = 8;
            // 
            // end_DateTime
            // 
            this.end_DateTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.end_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.end_DateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_DateTime.Location = new System.Drawing.Point(58, 29);
            this.end_DateTime.Name = "end_DateTime";
            this.end_DateTime.Size = new System.Drawing.Size(176, 20);
            this.end_DateTime.TabIndex = 9;
            this.end_DateTime.Value = new System.DateTime(2011, 3, 29, 15, 31, 0, 0);
            // 
            // optician_ComboBox
            // 
            this.optician_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optician_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optician_ComboBox.FormattingEnabled = true;
            this.optician_ComboBox.Location = new System.Drawing.Point(58, 81);
            this.optician_ComboBox.Name = "optician_ComboBox";
            this.optician_ComboBox.Size = new System.Drawing.Size(176, 21);
            this.optician_ComboBox.TabIndex = 10;
            // 
            // save_Button
            // 
            this.save_Button.AutoSize = true;
            this.save_Button.Location = new System.Drawing.Point(12, 127);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(80, 23);
            this.save_Button.TabIndex = 5;
            this.save_Button.Text = "Save Record";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.Save_ButtonClick);
            // 
            // delete_Button
            // 
            this.delete_Button.AutoSize = true;
            this.delete_Button.Location = new System.Drawing.Point(163, 127);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(86, 23);
            this.delete_Button.TabIndex = 6;
            this.delete_Button.Text = "Delete Record";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.Delete_ButtonClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // EditAppointment
            // 
            this.AcceptButton = this.save_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 162);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditAppointment";
            this.Text = "Edit Appointment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ComboBox optician_ComboBox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker end_DateTime;
        private System.Windows.Forms.DateTimePicker start_DateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remarks_Text;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}