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
    partial class Emails
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
        	this.newEmail_Button = new System.Windows.Forms.Button();
        	this.email_List = new System.Windows.Forms.ListBox();
        	this.email_GroupBox = new System.Windows.Forms.GroupBox();
        	this.name_Text = new System.Windows.Forms.TextBox();
        	this.label1 = new System.Windows.Forms.Label();
        	this.email_Text = new System.Windows.Forms.TextBox();
        	this.delete_Button = new System.Windows.Forms.Button();
        	this.save_Button = new System.Windows.Forms.Button();
        	this.help_Button = new System.Windows.Forms.Button();
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.email_GroupBox.SuspendLayout();
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
        	this.splitContainer1.Panel1.Controls.Add(this.newEmail_Button);
        	this.splitContainer1.Panel1.Controls.Add(this.email_List);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.email_GroupBox);
        	this.splitContainer1.Panel2.Controls.Add(this.delete_Button);
        	this.splitContainer1.Panel2.Controls.Add(this.save_Button);
        	this.splitContainer1.Panel2.Controls.Add(this.help_Button);
        	this.splitContainer1.Size = new System.Drawing.Size(292, 266);
        	this.splitContainer1.SplitterDistance = 97;
        	this.splitContainer1.TabIndex = 1;
        	// 
        	// newEmail_Button
        	// 
        	this.newEmail_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.newEmail_Button.Location = new System.Drawing.Point(12, 240);
        	this.newEmail_Button.Name = "newEmail_Button";
        	this.newEmail_Button.Size = new System.Drawing.Size(75, 23);
        	this.newEmail_Button.TabIndex = 1;
        	this.newEmail_Button.Text = "New Email";
        	this.newEmail_Button.UseVisualStyleBackColor = true;
        	this.newEmail_Button.Click += new System.EventHandler(this.NewEmail_ButtonClick);
        	// 
        	// email_List
        	// 
        	this.email_List.Dock = System.Windows.Forms.DockStyle.Top;
        	this.email_List.FormattingEnabled = true;
        	this.email_List.Location = new System.Drawing.Point(0, 0);
        	this.email_List.Name = "email_List";
        	this.email_List.Size = new System.Drawing.Size(97, 238);
        	this.email_List.TabIndex = 0;
        	this.email_List.SelectedIndexChanged += new System.EventHandler(this.Email_ListSelectedIndexChanged);
        	// 
        	// email_GroupBox
        	// 
        	this.email_GroupBox.Controls.Add(this.name_Text);
        	this.email_GroupBox.Controls.Add(this.label1);
        	this.email_GroupBox.Controls.Add(this.email_Text);
        	this.email_GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
        	this.email_GroupBox.Location = new System.Drawing.Point(0, 0);
        	this.email_GroupBox.Name = "email_GroupBox";
        	this.email_GroupBox.Size = new System.Drawing.Size(191, 234);
        	this.email_GroupBox.TabIndex = 4;
        	this.email_GroupBox.TabStop = false;
        	this.email_GroupBox.Text = "Email";
        	// 
        	// name_Text
        	// 
        	this.name_Text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.name_Text.Location = new System.Drawing.Point(75, 13);
        	this.name_Text.Name = "name_Text";
        	this.name_Text.Size = new System.Drawing.Size(110, 20);
        	this.name_Text.TabIndex = 2;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(3, 16);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(66, 13);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Email Name:";
        	// 
        	// email_Text
        	// 
        	this.email_Text.Dock = System.Windows.Forms.DockStyle.Bottom;
        	this.email_Text.Location = new System.Drawing.Point(3, 39);
        	this.email_Text.Multiline = true;
        	this.email_Text.Name = "email_Text";
        	this.email_Text.Size = new System.Drawing.Size(185, 192);
        	this.email_Text.TabIndex = 0;
        	// 
        	// delete_Button
        	// 
        	this.delete_Button.AutoSize = true;
        	this.delete_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.delete_Button.Location = new System.Drawing.Point(92, 240);
        	this.delete_Button.Name = "delete_Button";
        	this.delete_Button.Size = new System.Drawing.Size(48, 23);
        	this.delete_Button.TabIndex = 3;
        	this.delete_Button.Text = "Delete";
        	this.delete_Button.UseVisualStyleBackColor = true;
        	this.delete_Button.Click += new System.EventHandler(this.Delete_ButtonClick);
        	// 
        	// save_Button
        	// 
        	this.save_Button.AutoSize = true;
        	this.save_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.save_Button.Location = new System.Drawing.Point(146, 240);
        	this.save_Button.Name = "save_Button";
        	this.save_Button.Size = new System.Drawing.Size(42, 23);
        	this.save_Button.TabIndex = 2;
        	this.save_Button.Text = "Save";
        	this.save_Button.UseVisualStyleBackColor = true;
        	this.save_Button.Click += new System.EventHandler(this.Save_ButtonClick);
        	// 
        	// help_Button
        	// 
        	this.help_Button.AutoSize = true;
        	this.help_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.help_Button.Location = new System.Drawing.Point(3, 240);
        	this.help_Button.Name = "help_Button";
        	this.help_Button.Size = new System.Drawing.Size(39, 23);
        	this.help_Button.TabIndex = 1;
        	this.help_Button.Text = "Help";
        	this.help_Button.UseVisualStyleBackColor = true;
        	this.help_Button.Click += new System.EventHandler(this.Help_ButtonClick);
        	// 
        	// Emails
        	// 
        	this.AcceptButton = this.save_Button;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 266);
        	this.Controls.Add(this.splitContainer1);
        	this.HelpButton = true;
        	this.Name = "Emails";
        	this.Text = "Emails";
        	this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Help_ButtonClick);
        	this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Help_ButtonClick);
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.Panel2.PerformLayout();
        	this.splitContainer1.ResumeLayout(false);
        	this.email_GroupBox.ResumeLayout(false);
        	this.email_GroupBox.PerformLayout();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.TextBox email_Text;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newEmail_Button;
        private System.Windows.Forms.Button help_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.GroupBox email_GroupBox;
        private System.Windows.Forms.ListBox email_List;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
