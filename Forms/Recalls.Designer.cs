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
	partial class Recalls
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.endDate_DateTime = new System.Windows.Forms.DateTimePicker();
			this.startDate_DateTime = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.startDate_CheckBox = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.endDate_CheckBox = new System.Windows.Forms.CheckBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.recalls_List = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 200);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.endDate_DateTime, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.startDate_DateTime, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 54);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// endDate_DateTime
			// 
			this.endDate_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.endDate_DateTime.Location = new System.Drawing.Point(83, 30);
			this.endDate_DateTime.Name = "endDate_DateTime";
			this.endDate_DateTime.Size = new System.Drawing.Size(203, 20);
			this.endDate_DateTime.TabIndex = 3;
			this.endDate_DateTime.Value = new System.DateTime(2011, 3, 17, 0, 0, 0, 0);
			this.endDate_DateTime.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
			// 
			// startDate_DateTime
			// 
			this.startDate_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startDate_DateTime.Enabled = false;
			this.startDate_DateTime.Location = new System.Drawing.Point(83, 3);
			this.startDate_DateTime.Name = "startDate_DateTime";
			this.startDate_DateTime.Size = new System.Drawing.Size(203, 20);
			this.startDate_DateTime.TabIndex = 2;
			this.startDate_DateTime.Value = new System.DateTime(2011, 3, 17, 0, 0, 0, 0);
			this.startDate_DateTime.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.startDate_CheckBox);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(80, 27);
			this.panel1.TabIndex = 4;
			// 
			// startDate_CheckBox
			// 
			this.startDate_CheckBox.AutoSize = true;
			this.startDate_CheckBox.Location = new System.Drawing.Point(3, 6);
			this.startDate_CheckBox.Name = "startDate_CheckBox";
			this.startDate_CheckBox.Size = new System.Drawing.Size(74, 17);
			this.startDate_CheckBox.TabIndex = 0;
			this.startDate_CheckBox.Text = "Start Date";
			this.startDate_CheckBox.UseVisualStyleBackColor = true;
			this.startDate_CheckBox.CheckedChanged += new System.EventHandler(this.StartDate_CheckBoxCheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.endDate_CheckBox);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 27);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(80, 27);
			this.panel2.TabIndex = 5;
			// 
			// endDate_CheckBox
			// 
			this.endDate_CheckBox.AutoSize = true;
			this.endDate_CheckBox.Checked = true;
			this.endDate_CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.endDate_CheckBox.Location = new System.Drawing.Point(3, 6);
			this.endDate_CheckBox.Name = "endDate_CheckBox";
			this.endDate_CheckBox.Size = new System.Drawing.Size(71, 17);
			this.endDate_CheckBox.TabIndex = 0;
			this.endDate_CheckBox.Text = "End Date";
			this.endDate_CheckBox.UseVisualStyleBackColor = true;
			this.endDate_CheckBox.CheckedChanged += new System.EventHandler(this.EndDate_CheckBoxCheckedChanged);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 63);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.recalls_List);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.button1);
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel3);
			this.splitContainer1.Size = new System.Drawing.Size(288, 134);
			this.splitContainer1.SplitterDistance = 91;
			this.splitContainer1.TabIndex = 1;
			// 
			// recalls_List
			// 
			this.recalls_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.recalls_List.FormattingEnabled = true;
			this.recalls_List.Location = new System.Drawing.Point(0, 0);
			this.recalls_List.Name = "recalls_List";
			this.recalls_List.Size = new System.Drawing.Size(91, 134);
			this.recalls_List.TabIndex = 0;
			this.recalls_List.SelectedIndexChanged += new System.EventHandler(this.Recalls_ListSelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(115, 108);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.AutoSize = true;
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.textBox2, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.textBox3, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.textBox4, 1, 3);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(193, 104);
			this.tableLayoutPanel3.TabIndex = 0;
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
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Method";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Reason";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Time";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(53, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(139, 20);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(53, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(139, 20);
			this.textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox3.Enabled = false;
			this.textBox3.Location = new System.Drawing.Point(53, 55);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(139, 20);
			this.textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Enabled = false;
			this.textBox4.Location = new System.Drawing.Point(53, 81);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(139, 20);
			this.textBox4.TabIndex = 8;
			// 
			// Recalls
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 200);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Recalls";
			this.Text = "Recalls";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox recalls_List;
		private System.Windows.Forms.CheckBox startDate_CheckBox;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.CheckBox endDate_CheckBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker startDate_DateTime;
		private System.Windows.Forms.DateTimePicker endDate_DateTime;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
