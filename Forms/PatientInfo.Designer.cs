namespace OpticianDB.Forms
{
    partial class PatientInfo
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
        	this.label7 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label5 = new System.Windows.Forms.Label();
        	this.address_Text = new System.Windows.Forms.TextBox();
        	this.telNum_Text = new System.Windows.Forms.TextBox();
        	this.nhsNumber_Text = new System.Windows.Forms.TextBox();
        	this.email_Text = new System.Windows.Forms.TextBox();
        	this.dob_DateTime = new System.Windows.Forms.DateTimePicker();
        	this.preferredRecall_Combo = new System.Windows.Forms.ComboBox();
        	this.ammend_Button = new System.Windows.Forms.Button();
        	this.cnd_List = new System.Windows.Forms.ListBox();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.addCnd_Button = new System.Windows.Forms.Button();
        	this.removeCnd_Button = new System.Windows.Forms.Button();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.apmtHistory_Button = new System.Windows.Forms.Button();
        	this.newApmt_Click = new System.Windows.Forms.Button();
        	this.schedRecall_Button = new System.Windows.Forms.Button();
        	this.apmtDue_Button = new System.Windows.Forms.Button();
        	this.removePatient_Button = new System.Windows.Forms.Button();
        	this.name_Text = new System.Windows.Forms.TextBox();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.tableLayoutPanel1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 2;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Controls.Add(this.label7, 0, 5);
        	this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
        	this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
        	this.tableLayoutPanel1.Controls.Add(this.address_Text, 1, 0);
        	this.tableLayoutPanel1.Controls.Add(this.telNum_Text, 1, 1);
        	this.tableLayoutPanel1.Controls.Add(this.nhsNumber_Text, 1, 3);
        	this.tableLayoutPanel1.Controls.Add(this.email_Text, 1, 4);
        	this.tableLayoutPanel1.Controls.Add(this.dob_DateTime, 1, 2);
        	this.tableLayoutPanel1.Controls.Add(this.preferredRecall_Combo, 1, 5);
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 6;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 212);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// label7
        	// 
        	this.label7.AutoSize = true;
        	this.label7.Location = new System.Drawing.Point(3, 182);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(83, 13);
        	this.label7.TabIndex = 11;
        	this.label7.Text = "Preferred Recall";
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(3, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(45, 13);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Address";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(3, 78);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(98, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Telephone Number";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(3, 104);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(66, 13);
        	this.label3.TabIndex = 2;
        	this.label3.Text = "Date of Birth";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(3, 130);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(70, 13);
        	this.label4.TabIndex = 3;
        	this.label4.Text = "NHS Number";
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(3, 156);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(32, 13);
        	this.label5.TabIndex = 4;
        	this.label5.Text = "Email";
        	// 
        	// address_Text
        	// 
        	this.address_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.address_Text.Location = new System.Drawing.Point(107, 3);
        	this.address_Text.Multiline = true;
        	this.address_Text.Name = "address_Text";
        	this.address_Text.Size = new System.Drawing.Size(210, 72);
        	this.address_Text.TabIndex = 5;
        	// 
        	// textBox2
        	// 
        	this.telNum_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.telNum_Text.Location = new System.Drawing.Point(107, 81);
        	this.telNum_Text.Name = "textBox2";
        	this.telNum_Text.Size = new System.Drawing.Size(210, 20);
        	this.telNum_Text.TabIndex = 6;
        	// 
        	// nhsNumber_Text
        	// 
        	this.nhsNumber_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.nhsNumber_Text.Location = new System.Drawing.Point(107, 133);
        	this.nhsNumber_Text.Name = "nhsNumber_Text";
        	this.nhsNumber_Text.Size = new System.Drawing.Size(210, 20);
        	this.nhsNumber_Text.TabIndex = 8;
        	// 
        	// email_Text
        	// 
        	this.email_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.email_Text.Location = new System.Drawing.Point(107, 159);
        	this.email_Text.Name = "email_Text";
        	this.email_Text.Size = new System.Drawing.Size(210, 20);
        	this.email_Text.TabIndex = 9;
        	// 
        	// dob_Text
        	// 
        	this.dob_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dob_DateTime.Location = new System.Drawing.Point(107, 107);
        	this.dob_DateTime.Name = "dob_Text";
        	this.dob_DateTime.Size = new System.Drawing.Size(210, 20);
        	this.dob_DateTime.TabIndex = 10;
        	this.dob_DateTime.Value = new System.DateTime(2011, 3, 3, 0, 0, 0, 0);
        	// 
        	// preferredRecall_Combo
        	// 
        	this.preferredRecall_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.preferredRecall_Combo.FormattingEnabled = true;
        	this.preferredRecall_Combo.Items.AddRange(new object[] {
        	        	        	"Post",
        	        	        	"Phone",
        	        	        	"Email"});
        	this.preferredRecall_Combo.Location = new System.Drawing.Point(107, 185);
        	this.preferredRecall_Combo.Name = "preferredRecall_Combo";
        	this.preferredRecall_Combo.Size = new System.Drawing.Size(210, 21);
        	this.preferredRecall_Combo.TabIndex = 12;
        	// 
        	// ammend_Button
        	// 
        	this.ammend_Button.Location = new System.Drawing.Point(265, 13);
        	this.ammend_Button.Name = "ammend_Button";
        	this.ammend_Button.Size = new System.Drawing.Size(75, 23);
        	this.ammend_Button.TabIndex = 2;
        	this.ammend_Button.Text = "Ammend";
        	this.ammend_Button.UseVisualStyleBackColor = true;
        	this.ammend_Button.Click += new System.EventHandler(this.Amend_Click);
        	// 
        	// cnd_List
        	// 
        	this.cnd_List.FormattingEnabled = true;
        	this.cnd_List.Location = new System.Drawing.Point(6, 19);
        	this.cnd_List.Name = "cnd_List";
        	this.cnd_List.Size = new System.Drawing.Size(120, 95);
        	this.cnd_List.TabIndex = 3;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Controls.Add(this.cnd_List);
        	this.groupBox1.Controls.Add(this.addCnd_Button);
        	this.groupBox1.Controls.Add(this.removeCnd_Button);
        	this.groupBox1.Location = new System.Drawing.Point(12, 273);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(135, 149);
        	this.groupBox1.TabIndex = 4;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Conditions";
        	// 
        	// addCnd_Button
        	// 
        	this.addCnd_Button.Location = new System.Drawing.Point(6, 118);
        	this.addCnd_Button.Name = "addCnd_Button";
        	this.addCnd_Button.Size = new System.Drawing.Size(43, 23);
        	this.addCnd_Button.TabIndex = 6;
        	this.addCnd_Button.Text = "Add";
        	this.addCnd_Button.UseVisualStyleBackColor = true;
        	this.addCnd_Button.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// removeCnd_Button
        	// 
        	this.removeCnd_Button.Location = new System.Drawing.Point(67, 118);
        	this.removeCnd_Button.Name = "removeCnd_Button";
        	this.removeCnd_Button.Size = new System.Drawing.Size(59, 23);
        	this.removeCnd_Button.TabIndex = 7;
        	this.removeCnd_Button.Text = "Remove";
        	this.removeCnd_Button.UseVisualStyleBackColor = true;
        	this.removeCnd_Button.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Controls.Add(this.tableLayoutPanel1);
        	this.groupBox2.Location = new System.Drawing.Point(12, 42);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(332, 231);
        	this.groupBox2.TabIndex = 5;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Basic Information";
        	// 
        	// apmtHistory_Button
        	// 
        	this.apmtHistory_Button.Location = new System.Drawing.Point(196, 302);
        	this.apmtHistory_Button.Name = "apmtHistory_Button";
        	this.apmtHistory_Button.Size = new System.Drawing.Size(142, 23);
        	this.apmtHistory_Button.TabIndex = 8;
        	this.apmtHistory_Button.Text = "Appointments History";
        	this.apmtHistory_Button.UseVisualStyleBackColor = true;
        	this.apmtHistory_Button.Click += new System.EventHandler(this.button4_Click);
        	// 
        	// newApmt_Click
        	// 
        	this.newApmt_Click.Location = new System.Drawing.Point(196, 273);
        	this.newApmt_Click.Name = "newApmt_Click";
        	this.newApmt_Click.Size = new System.Drawing.Size(142, 23);
        	this.newApmt_Click.TabIndex = 9;
        	this.newApmt_Click.Text = "Make New Appointment";
        	this.newApmt_Click.UseVisualStyleBackColor = true;
        	this.newApmt_Click.Click += new System.EventHandler(this.button5_Click);
        	// 
        	// schedRecall_Button
        	// 
        	this.schedRecall_Button.Location = new System.Drawing.Point(197, 331);
        	this.schedRecall_Button.Name = "schedRecall_Button";
        	this.schedRecall_Button.Size = new System.Drawing.Size(141, 23);
        	this.schedRecall_Button.TabIndex = 10;
        	this.schedRecall_Button.Text = "Schedule Recall";
        	this.schedRecall_Button.UseVisualStyleBackColor = true;
        	this.schedRecall_Button.Click += new System.EventHandler(this.button6_Click);
        	// 
        	// apmtDue_Button
        	// 
        	this.apmtDue_Button.Location = new System.Drawing.Point(197, 361);
        	this.apmtDue_Button.Name = "apmtDue_Button";
        	this.apmtDue_Button.Size = new System.Drawing.Size(141, 23);
        	this.apmtDue_Button.TabIndex = 11;
        	this.apmtDue_Button.Text = "Show Appointments Due";
        	this.apmtDue_Button.UseVisualStyleBackColor = true;
        	this.apmtDue_Button.Click += new System.EventHandler(this.button7_Click);
        	// 
        	// removePatient_Button
        	// 
        	this.removePatient_Button.Location = new System.Drawing.Point(197, 391);
        	this.removePatient_Button.Name = "removePatient_Button";
        	this.removePatient_Button.Size = new System.Drawing.Size(138, 23);
        	this.removePatient_Button.TabIndex = 12;
        	this.removePatient_Button.Text = "Remove Patient";
        	this.removePatient_Button.UseVisualStyleBackColor = true;
        	this.removePatient_Button.Click += new System.EventHandler(this.button8_Click);
        	// 
        	// name_Text
        	// 
        	this.name_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.name_Text.Location = new System.Drawing.Point(12, 10);
        	this.name_Text.Name = "name_Text";
        	this.name_Text.Size = new System.Drawing.Size(247, 26);
        	this.name_Text.TabIndex = 13;
        	this.name_Text.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	this.errorProvider1.RightToLeft = true;
        	// 
        	// PatientInfo
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(352, 434);
        	this.Controls.Add(this.name_Text);
        	this.Controls.Add(this.removePatient_Button);
        	this.Controls.Add(this.apmtDue_Button);
        	this.Controls.Add(this.schedRecall_Button);
        	this.Controls.Add(this.newApmt_Click);
        	this.Controls.Add(this.apmtHistory_Button);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.ammend_Button);
        	this.Name = "PatientInfo";
        	this.Text = "Patient Information";
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel1.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.TextBox address_Text;
        private System.Windows.Forms.TextBox nhsNumber_Text;
        private System.Windows.Forms.TextBox email_Text;
        private System.Windows.Forms.Button ammend_Button;
        private System.Windows.Forms.DateTimePicker dob_DateTime;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.ComboBox preferredRecall_Combo;
        private System.Windows.Forms.ListBox cnd_List;
        private System.Windows.Forms.Button addCnd_Button;
        private System.Windows.Forms.Button removeCnd_Button;
        private System.Windows.Forms.Button apmtHistory_Button;
        private System.Windows.Forms.Button newApmt_Click;
        private System.Windows.Forms.Button schedRecall_Button;
        private System.Windows.Forms.Button apmtDue_Button;
        private System.Windows.Forms.Button removePatient_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telNum_Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}