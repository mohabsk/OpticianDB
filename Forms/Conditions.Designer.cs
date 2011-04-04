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
    partial class Conditions
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
            if (disposing)
            {
                if (components != null)
                {
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
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.conditions_List = new System.Windows.Forms.ListBox();
        	this.newCnd_Button = new System.Windows.Forms.Button();
        	this.viewPatients_Button = new System.Windows.Forms.Button();
        	this.delete_Button = new System.Windows.Forms.Button();
        	this.save_Button = new System.Windows.Forms.Button();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.condition_Text = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.tableLayoutPanel2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
        	this.splitContainer1.Panel2.Controls.Add(this.viewPatients_Button);
        	this.splitContainer1.Panel2.Controls.Add(this.delete_Button);
        	this.splitContainer1.Panel2.Controls.Add(this.save_Button);
        	this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
        	this.splitContainer1.Size = new System.Drawing.Size(292, 266);
        	this.splitContainer1.SplitterDistance = 97;
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Controls.Add(this.conditions_List, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.newCnd_Button, 0, 1);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 2;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(97, 266);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// conditions_List
        	// 
        	this.conditions_List.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.conditions_List.FormattingEnabled = true;
        	this.conditions_List.Location = new System.Drawing.Point(3, 3);
        	this.conditions_List.Name = "conditions_List";
        	this.conditions_List.Size = new System.Drawing.Size(91, 225);
        	this.conditions_List.TabIndex = 1;
        	this.conditions_List.SelectedIndexChanged += new System.EventHandler(this.Conditions_ListSelectedIndexChanged);
        	// 
        	// newCnd_Button
        	// 
        	this.newCnd_Button.Location = new System.Drawing.Point(3, 240);
        	this.newCnd_Button.Name = "newCnd_Button";
        	this.newCnd_Button.Size = new System.Drawing.Size(91, 23);
        	this.newCnd_Button.TabIndex = 0;
        	this.newCnd_Button.Text = "New Condition";
        	this.newCnd_Button.UseVisualStyleBackColor = true;
        	this.newCnd_Button.Click += new System.EventHandler(this.newCnd_ButtonClick);
        	// 
        	// viewPatients_Button
        	// 
        	this.viewPatients_Button.Enabled = false;
        	this.viewPatients_Button.Location = new System.Drawing.Point(6, 240);
        	this.viewPatients_Button.Name = "viewPatients_Button";
        	this.viewPatients_Button.Size = new System.Drawing.Size(82, 23);
        	this.viewPatients_Button.TabIndex = 3;
        	this.viewPatients_Button.Text = "View Patients";
        	this.viewPatients_Button.UseVisualStyleBackColor = true;
        	this.viewPatients_Button.Visible = false;
        	// 
        	// delete_Button
        	// 
        	this.delete_Button.Enabled = false;
        	this.delete_Button.Location = new System.Drawing.Point(113, 240);
        	this.delete_Button.Name = "delete_Button";
        	this.delete_Button.Size = new System.Drawing.Size(75, 23);
        	this.delete_Button.TabIndex = 2;
        	this.delete_Button.Text = "Delete";
        	this.delete_Button.UseVisualStyleBackColor = true;
        	this.delete_Button.Click += new System.EventHandler(this.Delete_ButtonClick);
        	// 
        	// save_Button
        	// 
        	this.save_Button.Enabled = false;
        	this.save_Button.Location = new System.Drawing.Point(113, 211);
        	this.save_Button.Name = "save_Button";
        	this.save_Button.Size = new System.Drawing.Size(75, 23);
        	this.save_Button.TabIndex = 1;
        	this.save_Button.Text = "Save";
        	this.save_Button.UseVisualStyleBackColor = true;
        	this.save_Button.Click += new System.EventHandler(this.Save_ButtonClick);
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 2;
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.Controls.Add(this.condition_Text, 1, 0);
        	this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 12);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 1;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(185, 100);
        	this.tableLayoutPanel2.TabIndex = 0;
        	// 
        	// condition_Text
        	// 
        	this.condition_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.condition_Text.Enabled = false;
        	this.condition_Text.Location = new System.Drawing.Point(63, 3);
        	this.condition_Text.Name = "condition_Text";
        	this.condition_Text.Size = new System.Drawing.Size(119, 20);
        	this.condition_Text.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(3, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(54, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Condition:";
        	// 
        	// errorProvider
        	// 
        	this.errorProvider.ContainerControl = this;
        	this.errorProvider.RightToLeft = true;
        	// 
        	// Conditions
        	// 
        	this.AcceptButton = this.save_Button;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 266);
        	this.Controls.Add(this.splitContainer1);
        	this.Name = "Conditions";
        	this.Text = "Conditions";
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.ResumeLayout(false);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.tableLayoutPanel2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox condition_Text;
        private System.Windows.Forms.Button viewPatients_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button newCnd_Button;
        private System.Windows.Forms.ListBox conditions_List;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
