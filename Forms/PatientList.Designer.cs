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
			this.Patient_List = new System.Windows.Forms.ListBox();
			this.Search_Button = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.conditions_List = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.Load_Button = new System.Windows.Forms.Button();
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
			this.splitContainer1.Panel2.Controls.Add(this.Load_Button);
			this.splitContainer1.Size = new System.Drawing.Size(357, 314);
			this.splitContainer1.SplitterDistance = 103;
			this.splitContainer1.TabIndex = 0;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.Patient_List, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Search_Button, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(103, 314);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// Patient_List
			// 
			this.Patient_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Patient_List.FormattingEnabled = true;
			this.Patient_List.Location = new System.Drawing.Point(3, 3);
			this.Patient_List.Name = "Patient_List";
			this.Patient_List.Size = new System.Drawing.Size(97, 277);
			this.Patient_List.TabIndex = 0;
			this.Patient_List.SelectedIndexChanged += new System.EventHandler(this.Patient_ListSelectedIndexChanged);
			// 
			// Search_Button
			// 
			this.Search_Button.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Search_Button.Location = new System.Drawing.Point(3, 288);
			this.Search_Button.Name = "Search_Button";
			this.Search_Button.Size = new System.Drawing.Size(97, 23);
			this.Search_Button.TabIndex = 1;
			this.Search_Button.Text = "Search";
			this.Search_Button.UseVisualStyleBackColor = true;
			this.Search_Button.Click += new System.EventHandler(this.Search_ButtonClick);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.conditions_List, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.textBox7, 1, 5);
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
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(79, 81);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(168, 20);
			this.textBox4.TabIndex = 7;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(79, 55);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 20);
			this.textBox3.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(79, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(168, 20);
			this.textBox2.TabIndex = 5;
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
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(79, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(168, 20);
			this.textBox1.TabIndex = 4;
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
			// textBox5
			// 
			this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox5.Enabled = false;
			this.textBox5.Location = new System.Drawing.Point(79, 107);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(168, 20);
			this.textBox5.TabIndex = 12;
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
			// textBox6
			// 
			this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox6.Enabled = false;
			this.textBox6.Location = new System.Drawing.Point(79, 260);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(168, 20);
			this.textBox6.TabIndex = 15;
			// 
			// textBox7
			// 
			this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox7.Enabled = false;
			this.textBox7.Location = new System.Drawing.Point(79, 133);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(168, 20);
			this.textBox7.TabIndex = 16;
			// 
			// Load_Button
			// 
			this.Load_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Load_Button.Enabled = false;
			this.Load_Button.Location = new System.Drawing.Point(172, 288);
			this.Load_Button.Name = "Load_Button";
			this.Load_Button.Size = new System.Drawing.Size(75, 23);
			this.Load_Button.TabIndex = 0;
			this.Load_Button.Text = "Load";
			this.Load_Button.UseVisualStyleBackColor = true;
			this.Load_Button.Click += new System.EventHandler(this.Load_ButtonClick);
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
		private System.Windows.Forms.ListBox conditions_List;
		private System.Windows.Forms.ListBox Patient_List;
		private System.Windows.Forms.Button Search_Button;
		private System.Windows.Forms.Button Load_Button;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox7;
		
	}
}
