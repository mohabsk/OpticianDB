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
	partial class AppointmentInProgress
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.dateOfBirth_Text = new System.Windows.Forms.TextBox();
            this.nhsNumber_Text = new System.Windows.Forms.TextBox();
            this.conditions_List = new System.Windows.Forms.ListBox();
            this.apmtRemarks_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.pastTests_Button = new System.Windows.Forms.Button();
            this.saveAppointment_Button = new System.Windows.Forms.Button();
            this.addCondition_Button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.name_Text, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateOfBirth_Text, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nhsNumber_Text, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.conditions_List, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.apmtRemarks_Text, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(239, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "NHS Number";
            // 
            // name_Text
            // 
            this.name_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.name_Text.Enabled = false;
            this.name_Text.Location = new System.Drawing.Point(79, 3);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(157, 20);
            this.name_Text.TabIndex = 0;
            // 
            // dateOfBirth_Text
            // 
            this.dateOfBirth_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateOfBirth_Text.Enabled = false;
            this.dateOfBirth_Text.Location = new System.Drawing.Point(79, 29);
            this.dateOfBirth_Text.Name = "dateOfBirth_Text";
            this.dateOfBirth_Text.Size = new System.Drawing.Size(157, 20);
            this.dateOfBirth_Text.TabIndex = 1;
            // 
            // nhsNumber_Text
            // 
            this.nhsNumber_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nhsNumber_Text.Enabled = false;
            this.nhsNumber_Text.Location = new System.Drawing.Point(79, 55);
            this.nhsNumber_Text.Name = "nhsNumber_Text";
            this.nhsNumber_Text.Size = new System.Drawing.Size(157, 20);
            this.nhsNumber_Text.TabIndex = 2;
            // 
            // conditions_List
            // 
            this.conditions_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conditions_List.FormattingEnabled = true;
            this.conditions_List.Location = new System.Drawing.Point(79, 107);
            this.conditions_List.Name = "conditions_List";
            this.conditions_List.Size = new System.Drawing.Size(157, 74);
            this.conditions_List.TabIndex = 3;
            // 
            // apmtRemarks_Text
            // 
            this.apmtRemarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apmtRemarks_Text.Enabled = false;
            this.apmtRemarks_Text.Location = new System.Drawing.Point(79, 81);
            this.apmtRemarks_Text.Name = "apmtRemarks_Text";
            this.apmtRemarks_Text.Size = new System.Drawing.Size(157, 20);
            this.apmtRemarks_Text.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Conditions";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Remarks";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.remarks_Text);
            this.groupBox6.Location = new System.Drawing.Point(6, 167);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(231, 75);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Remarks";
            // 
            // remarks_Text
            // 
            this.remarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarks_Text.Location = new System.Drawing.Point(3, 16);
            this.remarks_Text.Multiline = true;
            this.remarks_Text.Name = "remarks_Text";
            this.remarks_Text.Size = new System.Drawing.Size(225, 56);
            this.remarks_Text.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 71);
            this.groupBox4.TabIndex = 0;
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
            this.rSph_Text.Location = new System.Drawing.Point(32, 3);
            this.rSph_Text.Name = "rSph_Text";
            this.rSph_Text.Size = new System.Drawing.Size(44, 20);
            this.rSph_Text.TabIndex = 2;
            // 
            // lSph_Text
            // 
            this.lSph_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lSph_Text.Location = new System.Drawing.Point(32, 29);
            this.lSph_Text.Name = "lSph_Text";
            this.lSph_Text.Size = new System.Drawing.Size(44, 20);
            this.lSph_Text.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tableLayoutPanel3);
            this.groupBox3.Location = new System.Drawing.Point(130, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 123);
            this.groupBox3.TabIndex = 1;
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
            this.rCyl_Text.Location = new System.Drawing.Point(32, 3);
            this.rCyl_Text.Name = "rCyl_Text";
            this.rCyl_Text.Size = new System.Drawing.Size(37, 20);
            this.rCyl_Text.TabIndex = 2;
            // 
            // rAxis_Text
            // 
            this.rAxis_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rAxis_Text.Location = new System.Drawing.Point(32, 29);
            this.rAxis_Text.Name = "rAxis_Text";
            this.rAxis_Text.Size = new System.Drawing.Size(37, 20);
            this.rAxis_Text.TabIndex = 3;
            // 
            // lCyl_Text
            // 
            this.lCyl_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lCyl_Text.Location = new System.Drawing.Point(32, 55);
            this.lCyl_Text.Name = "lCyl_Text";
            this.lCyl_Text.Size = new System.Drawing.Size(37, 20);
            this.lCyl_Text.TabIndex = 4;
            // 
            // lAxis_Text
            // 
            this.lAxis_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lAxis_Text.Location = new System.Drawing.Point(32, 81);
            this.lAxis_Text.Name = "lAxis_Text";
            this.lAxis_Text.Size = new System.Drawing.Size(37, 20);
            this.lAxis_Text.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.tableLayoutPanel4);
            this.groupBox5.Location = new System.Drawing.Point(6, 93);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(118, 70);
            this.groupBox5.TabIndex = 2;
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
            this.rVa1_Text.Location = new System.Drawing.Point(32, 3);
            this.rVa1_Text.Name = "rVa1_Text";
            this.rVa1_Text.Size = new System.Drawing.Size(26, 20);
            this.rVa1_Text.TabIndex = 2;
            // 
            // lVa1_Text
            // 
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
            this.rVa2_Text.Location = new System.Drawing.Point(82, 3);
            this.rVa2_Text.Name = "rVa2_Text";
            this.rVa2_Text.Size = new System.Drawing.Size(27, 20);
            this.rVa2_Text.TabIndex = 6;
            // 
            // lVa2_Text
            // 
            this.lVa2_Text.Location = new System.Drawing.Point(82, 29);
            this.lVa2_Text.Name = "lVa2_Text";
            this.lVa2_Text.Size = new System.Drawing.Size(27, 20);
            this.lVa2_Text.TabIndex = 7;
            // 
            // pastTests_Button
            // 
            this.pastTests_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pastTests_Button.AutoSize = true;
            this.pastTests_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pastTests_Button.Location = new System.Drawing.Point(164, 475);
            this.pastTests_Button.Name = "pastTests_Button";
            this.pastTests_Button.Size = new System.Drawing.Size(93, 23);
            this.pastTests_Button.TabIndex = 3;
            this.pastTests_Button.Text = "View Past Tests";
            this.pastTests_Button.UseVisualStyleBackColor = true;
            this.pastTests_Button.Click += new System.EventHandler(this.PastTests_Button_Click);
            // 
            // saveAppointment_Button
            // 
            this.saveAppointment_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveAppointment_Button.AutoSize = true;
            this.saveAppointment_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveAppointment_Button.Location = new System.Drawing.Point(12, 506);
            this.saveAppointment_Button.Name = "saveAppointment_Button";
            this.saveAppointment_Button.Size = new System.Drawing.Size(104, 23);
            this.saveAppointment_Button.TabIndex = 4;
            this.saveAppointment_Button.Text = "Save Test Results";
            this.saveAppointment_Button.UseVisualStyleBackColor = true;
            this.saveAppointment_Button.Click += new System.EventHandler(this.SaveAppointment_Button_Click);
            // 
            // addCondition_Button
            // 
            this.addCondition_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addCondition_Button.AutoSize = true;
            this.addCondition_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCondition_Button.Location = new System.Drawing.Point(12, 475);
            this.addCondition_Button.Name = "addCondition_Button";
            this.addCondition_Button.Size = new System.Drawing.Size(83, 23);
            this.addCondition_Button.TabIndex = 2;
            this.addCondition_Button.Text = "Add Condition";
            this.addCondition_Button.UseVisualStyleBackColor = true;
            this.addCondition_Button.Click += new System.EventHandler(this.AddCondition_Button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // AppointmentInProgress
            // 
            this.AcceptButton = this.saveAppointment_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 541);
            this.Controls.Add(this.addCondition_Button);
            this.Controls.Add(this.saveAppointment_Button);
            this.Controls.Add(this.pastTests_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AppointmentInProgress";
            this.Text = "Appointment View";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox dateOfBirth_Text;
        private System.Windows.Forms.TextBox nhsNumber_Text;
        private System.Windows.Forms.ListBox conditions_List;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button pastTests_Button;
        private System.Windows.Forms.Button saveAppointment_Button;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rSph_Text;
        private System.Windows.Forms.TextBox lSph_Text;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox rCyl_Text;
        private System.Windows.Forms.TextBox rAxis_Text;
        private System.Windows.Forms.TextBox lCyl_Text;
        private System.Windows.Forms.TextBox lAxis_Text;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rVa1_Text;
        private System.Windows.Forms.TextBox lVa1_Text;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox rVa2_Text;
        private System.Windows.Forms.TextBox lVa2_Text;
        private System.Windows.Forms.Button addCondition_Button;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox remarks_Text;
        private System.Windows.Forms.TextBox apmtRemarks_Text;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
