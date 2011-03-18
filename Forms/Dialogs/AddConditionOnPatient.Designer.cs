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
    partial class AddConditionOnPatient
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
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.NewCondition_Button = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.OK_Button = new System.Windows.Forms.Button();
        	this.Cancel_Button = new System.Windows.Forms.Button();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.tableLayoutPanel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.Location = new System.Drawing.Point(72, 12);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(208, 21);
        	this.comboBox1.TabIndex = 0;
        	// 
        	// NewCondition_Button
        	// 
        	this.NewCondition_Button.Location = new System.Drawing.Point(3, 3);
        	this.NewCondition_Button.Name = "NewCondition_Button";
        	this.NewCondition_Button.Size = new System.Drawing.Size(84, 23);
        	this.NewCondition_Button.TabIndex = 1;
        	this.NewCondition_Button.Text = "New Condition";
        	this.NewCondition_Button.UseVisualStyleBackColor = true;
        	this.NewCondition_Button.Click += new System.EventHandler(this.AddCondition_ButtonClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 15);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(54, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Condition:";
        	// 
        	// OK_Button
        	// 
        	this.OK_Button.Location = new System.Drawing.Point(93, 3);
        	this.OK_Button.Name = "OK_Button";
        	this.OK_Button.Size = new System.Drawing.Size(75, 23);
        	this.OK_Button.TabIndex = 3;
        	this.OK_Button.Text = "OK";
        	this.OK_Button.UseVisualStyleBackColor = true;
        	this.OK_Button.Click += new System.EventHandler(this.OK_ButtonClick);
        	// 
        	// Cancel_Button
        	// 
        	this.Cancel_Button.Location = new System.Drawing.Point(174, 3);
        	this.Cancel_Button.Name = "Cancel_Button";
        	this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
        	this.Cancel_Button.TabIndex = 4;
        	this.Cancel_Button.Text = "Cancel";
        	this.Cancel_Button.UseVisualStyleBackColor = true;
        	this.Cancel_Button.Click += new System.EventHandler(this.Cancel_ButtonClick);
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.tableLayoutPanel1.AutoSize = true;
        	this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.tableLayoutPanel1.ColumnCount = 3;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.Controls.Add(this.NewCondition_Button, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.Cancel_Button, 2, 0);
        	this.tableLayoutPanel1.Controls.Add(this.OK_Button, 1, 0);
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 47);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 1;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(252, 29);
        	this.tableLayoutPanel1.TabIndex = 5;
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	this.errorProvider1.RightToLeft = true;
        	// 
        	// AddConditionOnPatient
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 88);
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.comboBox1);
        	this.Name = "AddConditionOnPatient";
        	this.Text = "Assign Condition To Patient";
        	this.tableLayoutPanel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button NewCondition_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
