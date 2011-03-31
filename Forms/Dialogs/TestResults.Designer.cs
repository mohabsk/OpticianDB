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
	partial class TestResults
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
			this.results_List = new System.Windows.Forms.ListBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.users_Text = new System.Windows.Forms.TextBox();
			this.testDate_Text = new System.Windows.Forms.TextBox();
			this.amend_Button = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.remarks_Text = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.rSph_Text = new System.Windows.Forms.TextBox();
			this.lSph_Text = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.rCyl_Text = new System.Windows.Forms.TextBox();
			this.rAxis_Text = new System.Windows.Forms.TextBox();
			this.lCyl_Text = new System.Windows.Forms.TextBox();
			this.lAxis_Text = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.rVa1_Text = new System.Windows.Forms.TextBox();
			this.lVa1_Text = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.rVa2_Text = new System.Windows.Forms.TextBox();
			this.lVa2_Text = new System.Windows.Forms.TextBox();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.results_List);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.amend_Button);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox6);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
			this.splitContainer1.Size = new System.Drawing.Size(403, 355);
			this.splitContainer1.SplitterDistance = 154;
			this.splitContainer1.TabIndex = 0;
			// 
			// results_List
			// 
			this.results_List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.results_List.FormattingEnabled = true;
			this.results_List.Location = new System.Drawing.Point(0, 0);
			this.results_List.Name = "results_List";
			this.results_List.Size = new System.Drawing.Size(154, 355);
			this.results_List.TabIndex = 0;
			this.results_List.SelectedIndexChanged += new System.EventHandler(this.Results_ListSelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.users_Text);
			this.groupBox1.Controls.Add(this.testDate_Text);
			this.groupBox1.Location = new System.Drawing.Point(2, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 67);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Date and Optician";
			// 
			// users_Text
			// 
			this.users_Text.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.users_Text.Enabled = false;
			this.users_Text.Location = new System.Drawing.Point(3, 44);
			this.users_Text.Name = "users_Text";
			this.users_Text.Size = new System.Drawing.Size(229, 20);
			this.users_Text.TabIndex = 3;
			// 
			// testDate_Text
			// 
			this.testDate_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.testDate_Text.Enabled = false;
			this.testDate_Text.Location = new System.Drawing.Point(3, 16);
			this.testDate_Text.Name = "testDate_Text";
			this.testDate_Text.Size = new System.Drawing.Size(229, 20);
			this.testDate_Text.TabIndex = 2;
			// 
			// amend_Button
			// 
			this.amend_Button.AutoSize = true;
			this.amend_Button.Enabled = false;
			this.amend_Button.Location = new System.Drawing.Point(154, 320);
			this.amend_Button.Name = "amend_Button";
			this.amend_Button.Size = new System.Drawing.Size(79, 23);
			this.amend_Button.TabIndex = 8;
			this.amend_Button.Text = "Amend";
			this.amend_Button.UseVisualStyleBackColor = true;
			this.amend_Button.Click += new System.EventHandler(this.Amend_ButtonClick);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.remarks_Text);
			this.groupBox6.Location = new System.Drawing.Point(2, 233);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(230, 75);
			this.groupBox6.TabIndex = 7;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Remarks";
			// 
			// remarks_Text
			// 
			this.remarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.remarks_Text.Enabled = false;
			this.remarks_Text.Location = new System.Drawing.Point(3, 16);
			this.remarks_Text.Multiline = true;
			this.remarks_Text.Name = "remarks_Text";
			this.remarks_Text.Size = new System.Drawing.Size(224, 56);
			this.remarks_Text.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel2);
			this.groupBox4.Location = new System.Drawing.Point(2, 85);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(118, 71);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "SPH";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label7, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.label8, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.rSph_Text, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lSph_Text, 1, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(112, 52);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "OS";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "OD";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(82, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(27, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "diop";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(82, 26);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(27, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "diop";
			// 
			// rSph_Text
			// 
			this.rSph_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rSph_Text.Enabled = false;
			this.rSph_Text.Location = new System.Drawing.Point(32, 3);
			this.rSph_Text.Name = "rSph_Text";
			this.rSph_Text.Size = new System.Drawing.Size(44, 20);
			this.rSph_Text.TabIndex = 2;
			// 
			// lSph_Text
			// 
			this.lSph_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lSph_Text.Enabled = false;
			this.lSph_Text.Location = new System.Drawing.Point(32, 29);
			this.lSph_Text.Name = "lSph_Text";
			this.lSph_Text.Size = new System.Drawing.Size(44, 20);
			this.lSph_Text.TabIndex = 3;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel3);
			this.groupBox3.Location = new System.Drawing.Point(121, 85);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(111, 123);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "CYL";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.Controls.Add(this.label11, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.label10, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.label12, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.label9, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.label13, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.label14, 2, 3);
			this.tableLayoutPanel3.Controls.Add(this.rCyl_Text, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.rAxis_Text, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.lCyl_Text, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.lAxis_Text, 1, 3);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel3.Size = new System.Drawing.Size(105, 104);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "OD";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(75, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(27, 13);
			this.label10.TabIndex = 6;
			this.label10.Text = "diop";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 52);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(22, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "OS";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(75, 52);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(27, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "diop";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(75, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(11, 13);
			this.label13.TabIndex = 7;
			this.label13.Text = "°";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(75, 78);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(11, 13);
			this.label14.TabIndex = 9;
			this.label14.Text = "°";
			// 
			// rCyl_Text
			// 
			this.rCyl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rCyl_Text.Enabled = false;
			this.rCyl_Text.Location = new System.Drawing.Point(32, 3);
			this.rCyl_Text.Name = "rCyl_Text";
			this.rCyl_Text.Size = new System.Drawing.Size(37, 20);
			this.rCyl_Text.TabIndex = 2;
			// 
			// rAxis_Text
			// 
			this.rAxis_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rAxis_Text.Enabled = false;
			this.rAxis_Text.Location = new System.Drawing.Point(32, 29);
			this.rAxis_Text.Name = "rAxis_Text";
			this.rAxis_Text.Size = new System.Drawing.Size(37, 20);
			this.rAxis_Text.TabIndex = 3;
			// 
			// lCyl_Text
			// 
			this.lCyl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lCyl_Text.Enabled = false;
			this.lCyl_Text.Location = new System.Drawing.Point(32, 55);
			this.lCyl_Text.Name = "lCyl_Text";
			this.lCyl_Text.Size = new System.Drawing.Size(37, 20);
			this.lCyl_Text.TabIndex = 4;
			// 
			// lAxis_Text
			// 
			this.lAxis_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lAxis_Text.Enabled = false;
			this.lAxis_Text.Location = new System.Drawing.Point(32, 81);
			this.lAxis_Text.Name = "lAxis_Text";
			this.lAxis_Text.Size = new System.Drawing.Size(37, 20);
			this.lAxis_Text.TabIndex = 5;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tableLayoutPanel4);
			this.groupBox5.Location = new System.Drawing.Point(5, 159);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(118, 70);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "VA";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 4;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.label15, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.label16, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.rVa1_Text, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.lVa1_Text, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.label17, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.label18, 2, 1);
			this.tableLayoutPanel4.Controls.Add(this.rVa2_Text, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.lVa2_Text, 3, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(112, 51);
			this.tableLayoutPanel4.TabIndex = 2;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(3, 26);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(22, 13);
			this.label15.TabIndex = 1;
			this.label15.Text = "OS";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(3, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(23, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "OD";
			// 
			// rVa1_Text
			// 
			this.rVa1_Text.Enabled = false;
			this.rVa1_Text.Location = new System.Drawing.Point(32, 3);
			this.rVa1_Text.Name = "rVa1_Text";
			this.rVa1_Text.Size = new System.Drawing.Size(26, 20);
			this.rVa1_Text.TabIndex = 2;
			// 
			// lVa1_Text
			// 
			this.lVa1_Text.Enabled = false;
			this.lVa1_Text.Location = new System.Drawing.Point(32, 29);
			this.lVa1_Text.Name = "lVa1_Text";
			this.lVa1_Text.Size = new System.Drawing.Size(26, 20);
			this.lVa1_Text.TabIndex = 3;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(64, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(12, 13);
			this.label17.TabIndex = 4;
			this.label17.Text = "/";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(64, 26);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(12, 13);
			this.label18.TabIndex = 5;
			this.label18.Text = "/";
			// 
			// rVa2_Text
			// 
			this.rVa2_Text.Enabled = false;
			this.rVa2_Text.Location = new System.Drawing.Point(82, 3);
			this.rVa2_Text.Name = "rVa2_Text";
			this.rVa2_Text.Size = new System.Drawing.Size(27, 20);
			this.rVa2_Text.TabIndex = 6;
			// 
			// lVa2_Text
			// 
			this.lVa2_Text.Enabled = false;
			this.lVa2_Text.Location = new System.Drawing.Point(82, 29);
			this.lVa2_Text.Name = "lVa2_Text";
			this.lVa2_Text.Size = new System.Drawing.Size(27, 20);
			this.lVa2_Text.TabIndex = 7;
			// 
			// TestResults
			// 
			this.AcceptButton = this.amend_Button;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 355);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "TestResults";
			this.Text = "Past Test Results";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox users_Text;
		private System.Windows.Forms.TextBox testDate_Text;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button amend_Button;
		private System.Windows.Forms.TextBox lVa2_Text;
		private System.Windows.Forms.TextBox rVa2_Text;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox lVa1_Text;
		private System.Windows.Forms.TextBox rVa1_Text;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox lAxis_Text;
		private System.Windows.Forms.TextBox lCyl_Text;
		private System.Windows.Forms.TextBox rAxis_Text;
		private System.Windows.Forms.TextBox rCyl_Text;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox lSph_Text;
		private System.Windows.Forms.TextBox rSph_Text;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox remarks_Text;
		private System.Windows.Forms.GroupBox groupBox6;

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox results_List;
	}
}
