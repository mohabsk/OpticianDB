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
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.listBox1 = new System.Windows.Forms.ListBox();
        	this.button1 = new System.Windows.Forms.Button();
        	this.splitContainer1.Panel1.SuspendLayout();
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
        	this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
        	this.splitContainer1.Size = new System.Drawing.Size(292, 266);
        	this.splitContainer1.SplitterDistance = 97;
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 1;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
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
        	// listBox1
        	// 
        	this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.listBox1.FormattingEnabled = true;
        	this.listBox1.Location = new System.Drawing.Point(3, 3);
        	this.listBox1.Name = "listBox1";
        	this.listBox1.Size = new System.Drawing.Size(91, 225);
        	this.listBox1.TabIndex = 1;
        	this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(3, 240);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(91, 23);
        	this.button1.TabIndex = 0;
        	this.button1.Text = "New Condition";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// Conditions
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 266);
        	this.Controls.Add(this.splitContainer1);
        	this.Name = "Conditions";
        	this.Text = "Conditions";
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.ResumeLayout(false);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
