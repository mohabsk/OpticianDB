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
namespace OpticianDB.Forms
{
	partial class PatientList
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.patient_List = new System.Windows.Forms.ListBox();
			this.search_Button = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.telNum_Text = new System.Windows.Forms.TextBox();
			this.address_Text = new System.Windows.Forms.TextBox();
			this.nhsNumber_Text = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.name_Text = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.email_Text = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.conditions_List = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.recallMethod_Text = new System.Windows.Forms.TextBox();
			this.dateOfBirth_Text = new System.Windows.Forms.TextBox();
			this.load_Button = new System.Windows.Forms.Button();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
			this.splitContainer1.Panel2.Controls.Add(this.load_Button);
			this.splitContainer1.Size = new System.Drawing.Size(357, 314);
			this.splitContainer1.SplitterDistance = 103;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.patient_List, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.search_Button, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(103, 314);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// patient_List
			// 
			this.patient_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.patient_List.FormattingEnabled = true;
			this.patient_List.Location = new System.Drawing.Point(3, 3);
			this.patient_List.Name = "patient_List";
			this.patient_List.Size = new System.Drawing.Size(97, 277);
			this.patient_List.TabIndex = 0;
			this.patient_List.SelectedIndexChanged += new System.EventHandler(this.Patient_ListSelectedIndexChanged);
			// 
			// search_Button
			// 
			this.search_Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.search_Button.Location = new System.Drawing.Point(3, 288);
			this.search_Button.Name = "search_Button";
			this.search_Button.Size = new System.Drawing.Size(97, 23);
			this.search_Button.TabIndex = 1;
			this.search_Button.Text = "Search";
			this.search_Button.UseVisualStyleBackColor = true;
			this.search_Button.Click += new System.EventHandler(this.Search_ButtonClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.telNum_Text, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.address_Text, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.nhsNumber_Text, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.name_Text, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.email_Text, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.conditions_List, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.recallMethod_Text, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.dateOfBirth_Text, 1, 5);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 288);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 156);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Conditions";
			// 
			// telNum_Text
			// 
			this.telNum_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.telNum_Text.Enabled = false;
			this.telNum_Text.Location = new System.Drawing.Point(79, 81);
			this.telNum_Text.Name = "telNum_Text";
			this.telNum_Text.Size = new System.Drawing.Size(168, 20);
			this.telNum_Text.TabIndex = 7;
			// 
			// address_Text
			// 
			this.address_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.address_Text.Enabled = false;
			this.address_Text.Location = new System.Drawing.Point(79, 55);
			this.address_Text.Name = "address_Text";
			this.address_Text.Size = new System.Drawing.Size(168, 20);
			this.address_Text.TabIndex = 6;
			// 
			// nhsNumber_Text
			// 
			this.nhsNumber_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nhsNumber_Text.Enabled = false;
			this.nhsNumber_Text.Location = new System.Drawing.Point(79, 29);
			this.nhsNumber_Text.Name = "nhsNumber_Text";
			this.nhsNumber_Text.Size = new System.Drawing.Size(168, 20);
			this.nhsNumber_Text.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 26);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "NHS Number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Address";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Phone";
			// 
			// name_Text
			// 
			this.name_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.name_Text.Enabled = false;
			this.name_Text.Location = new System.Drawing.Point(79, 3);
			this.name_Text.Name = "name_Text";
			this.name_Text.Size = new System.Drawing.Size(168, 20);
			this.name_Text.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 104);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Email";
			// 
			// email_Text
			// 
			this.email_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.email_Text.Enabled = false;
			this.email_Text.Location = new System.Drawing.Point(79, 107);
			this.email_Text.Name = "email_Text";
			this.email_Text.Size = new System.Drawing.Size(168, 20);
			this.email_Text.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 130);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(66, 13);
			this.label7.TabIndex = 3;
			this.label7.Text = "Date of Birth";
			// 
			// conditions_List
			// 
			this.conditions_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.conditions_List.FormattingEnabled = true;
			this.conditions_List.Location = new System.Drawing.Point(79, 159);
			this.conditions_List.Name = "conditions_List";
			this.conditions_List.Size = new System.Drawing.Size(168, 95);
			this.conditions_List.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 257);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Rcl Method";
			// 
			// recallMethod_Text
			// 
			this.recallMethod_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recallMethod_Text.Enabled = false;
			this.recallMethod_Text.Location = new System.Drawing.Point(79, 260);
			this.recallMethod_Text.Name = "recallMethod_Text";
			this.recallMethod_Text.Size = new System.Drawing.Size(168, 20);
			this.recallMethod_Text.TabIndex = 15;
			// 
			// dateOfBirth_Text
			// 
			this.dateOfBirth_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateOfBirth_Text.Enabled = false;
			this.dateOfBirth_Text.Location = new System.Drawing.Point(79, 133);
			this.dateOfBirth_Text.Name = "dateOfBirth_Text";
			this.dateOfBirth_Text.Size = new System.Drawing.Size(168, 20);
			this.dateOfBirth_Text.TabIndex = 16;
			// 
			// load_Button
			// 
			this.load_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.load_Button.Enabled = false;
			this.load_Button.Location = new System.Drawing.Point(172, 288);
			this.load_Button.Name = "load_Button";
			this.load_Button.Size = new System.Drawing.Size(75, 23);
			this.load_Button.TabIndex = 0;
			this.load_Button.Text = "Load";
			this.load_Button.UseVisualStyleBackColor = true;
			this.load_Button.Click += new System.EventHandler(this.Load_ButtonClick);
			// 
			// PatientList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(357, 314);
			this.Controls.Add(this.splitContainer1);
			this.Name = "PatientList";
			this.Text = "Patients";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button load_Button;
		private System.Windows.Forms.Button search_Button;
		private System.Windows.Forms.TextBox name_Text;
		private System.Windows.Forms.ListBox patient_List;
		private System.Windows.Forms.ListBox conditions_List;
		private System.Windows.Forms.TextBox recallMethod_Text;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox email_Text;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nhsNumber_Text;
		private System.Windows.Forms.TextBox address_Text;
		private System.Windows.Forms.TextBox telNum_Text;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox dateOfBirth_Text;
		
	}
}
