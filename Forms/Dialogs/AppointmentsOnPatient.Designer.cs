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
    partial class AppointmentsOnPatient
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.appointments_List = new System.Windows.Forms.ListBox();
            this.load_Button = new System.Windows.Forms.Button();
            this.edit_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startDate_Text = new System.Windows.Forms.TextBox();
            this.remarks_Text = new System.Windows.Forms.TextBox();
            this.endDate_Text = new System.Windows.Forms.TextBox();
            this.optician_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.appointments_List);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.load_Button);
            this.splitContainer1.Panel2.Controls.Add(this.edit_Button);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(292, 266);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // appointments_List
            // 
            this.appointments_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointments_List.FormattingEnabled = true;
            this.appointments_List.Location = new System.Drawing.Point(0, 0);
            this.appointments_List.Name = "appointments_List";
            this.appointments_List.Size = new System.Drawing.Size(97, 266);
            this.appointments_List.TabIndex = 0;
            this.appointments_List.SelectedIndexChanged += new System.EventHandler(this.Appointments_ListSelectedIndexChanged);
            // 
            // load_Button
            // 
            this.load_Button.Enabled = false;
            this.load_Button.Location = new System.Drawing.Point(3, 231);
            this.load_Button.Name = "load_Button";
            this.load_Button.Size = new System.Drawing.Size(75, 23);
            this.load_Button.TabIndex = 5;
            this.load_Button.Text = "Load";
            this.load_Button.UseVisualStyleBackColor = true;
            this.load_Button.Click += new System.EventHandler(this.Load_ButtonClick);
            // 
            // edit_Button
            // 
            this.edit_Button.Enabled = false;
            this.edit_Button.Location = new System.Drawing.Point(110, 231);
            this.edit_Button.Name = "edit_Button";
            this.edit_Button.Size = new System.Drawing.Size(75, 23);
            this.edit_Button.TabIndex = 4;
            this.edit_Button.Text = "Edit";
            this.edit_Button.UseVisualStyleBackColor = true;
            this.edit_Button.Click += new System.EventHandler(this.Edit_ButtonClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.startDate_Text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.remarks_Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.endDate_Text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.optician_Text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(186, 106);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // startDate_Text
            // 
            this.startDate_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDate_Text.Enabled = false;
            this.startDate_Text.Location = new System.Drawing.Point(58, 3);
            this.startDate_Text.Name = "startDate_Text";
            this.startDate_Text.Size = new System.Drawing.Size(125, 20);
            this.startDate_Text.TabIndex = 0;
            // 
            // remarks_Text
            // 
            this.remarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarks_Text.Enabled = false;
            this.remarks_Text.Location = new System.Drawing.Point(58, 55);
            this.remarks_Text.Name = "remarks_Text";
            this.remarks_Text.Size = new System.Drawing.Size(125, 20);
            this.remarks_Text.TabIndex = 2;
            // 
            // endDate_Text
            // 
            this.endDate_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDate_Text.Enabled = false;
            this.endDate_Text.Location = new System.Drawing.Point(58, 29);
            this.endDate_Text.Name = "endDate_Text";
            this.endDate_Text.Size = new System.Drawing.Size(125, 20);
            this.endDate_Text.TabIndex = 1;
            // 
            // optician_Text
            // 
            this.optician_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optician_Text.Enabled = false;
            this.optician_Text.Location = new System.Drawing.Point(58, 81);
            this.optician_Text.Name = "optician_Text";
            this.optician_Text.Size = new System.Drawing.Size(125, 20);
            this.optician_Text.TabIndex = 3;
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
            // AppointmentsOnPatient
            // 
            this.AcceptButton = this.load_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AppointmentsOnPatient";
            this.Text = "Patient Appointments";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox startDate_Text;
        private System.Windows.Forms.TextBox remarks_Text;
        private System.Windows.Forms.TextBox endDate_Text;
        private System.Windows.Forms.TextBox optician_Text;
        private System.Windows.Forms.Button edit_Button;
        private System.Windows.Forms.Button load_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox appointments_List;
        private System.Windows.Forms.SplitContainer splitContainer1;

        #endregion
    }
}