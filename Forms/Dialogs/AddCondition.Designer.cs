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
    partial class AddCondition
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
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.add_Button = new System.Windows.Forms.Button();
        	this.cancel_Button = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.condition_Text = new System.Windows.Forms.TextBox();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.tableLayoutPanel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.tableLayoutPanel1.ColumnCount = 2;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Controls.Add(this.add_Button, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.cancel_Button, 1, 0);
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(149, 47);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 1;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(130, 29);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// add_Button
        	// 
        	this.add_Button.Location = new System.Drawing.Point(3, 3);
        	this.add_Button.Name = "add_Button";
        	this.add_Button.Size = new System.Drawing.Size(59, 23);
        	this.add_Button.TabIndex = 1;
        	this.add_Button.Text = "Add";
        	this.add_Button.UseVisualStyleBackColor = true;
        	this.add_Button.Click += new System.EventHandler(this.Add_ButtonClick);
        	// 
        	// cancel_Button
        	// 
        	this.cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.cancel_Button.Location = new System.Drawing.Point(68, 3);
        	this.cancel_Button.Name = "cancel_Button";
        	this.cancel_Button.Size = new System.Drawing.Size(59, 23);
        	this.cancel_Button.TabIndex = 2;
        	this.cancel_Button.Text = "Cancel";
        	this.cancel_Button.UseVisualStyleBackColor = true;
        	this.cancel_Button.Click += new System.EventHandler(this.Cancel_ButtonClick);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(12, 16);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(97, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Name of Condition:";
        	// 
        	// condition_Text
        	// 
        	this.condition_Text.Location = new System.Drawing.Point(115, 13);
        	this.condition_Text.Name = "condition_Text";
        	this.condition_Text.Size = new System.Drawing.Size(164, 20);
        	this.condition_Text.TabIndex = 0;
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	this.errorProvider1.RightToLeft = true;
        	// 
        	// AddCondition
        	// 
        	this.AcceptButton = this.add_Button;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.cancel_Button;
        	this.ClientSize = new System.Drawing.Size(291, 88);
        	this.Controls.Add(this.condition_Text);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Name = "AddCondition";
        	this.Text = "New Condition";
        	this.tableLayoutPanel1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox condition_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
