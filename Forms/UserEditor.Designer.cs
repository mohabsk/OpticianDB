namespace OpticianDB.Forms
{
    partial class UserEditor
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditor));
        	this.splitContainer1 = new System.Windows.Forms.SplitContainer();
        	this.user_List = new System.Windows.Forms.ListBox();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.panel4 = new System.Windows.Forms.Panel();
        	this.label4 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.username_Text = new System.Windows.Forms.TextBox();
        	this.panel3 = new System.Windows.Forms.Panel();
        	this.label3 = new System.Windows.Forms.Label();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.label2 = new System.Windows.Forms.Label();
        	this.password_Text = new System.Windows.Forms.TextBox();
        	this.fullName_Text = new System.Windows.Forms.TextBox();
        	this.hashingMethod_ComboBox = new System.Windows.Forms.ComboBox();
        	this.toolTip = new System.Windows.Forms.ToolTip(this.components);
        	this.splitContainer2 = new System.Windows.Forms.SplitContainer();
        	this.toolStrip = new System.Windows.Forms.ToolStrip();
        	this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
        	this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        	this.splitContainer1.Panel1.SuspendLayout();
        	this.splitContainer1.Panel2.SuspendLayout();
        	this.splitContainer1.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.panel4.SuspendLayout();
        	this.panel1.SuspendLayout();
        	this.panel3.SuspendLayout();
        	this.panel2.SuspendLayout();
        	this.splitContainer2.Panel1.SuspendLayout();
        	this.splitContainer2.Panel2.SuspendLayout();
        	this.splitContainer2.SuspendLayout();
        	this.toolStrip.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// splitContainer1
        	// 
        	this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        	this.splitContainer1.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
        	this.splitContainer1.Name = "splitContainer1";
        	// 
        	// splitContainer1.Panel1
        	// 
        	this.splitContainer1.Panel1.Controls.Add(this.user_List);
        	// 
        	// splitContainer1.Panel2
        	// 
        	this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
        	this.splitContainer1.Size = new System.Drawing.Size(292, 213);
        	this.splitContainer1.SplitterDistance = 75;
        	this.splitContainer1.TabIndex = 0;
        	// 
        	// user_List
        	// 
        	this.user_List.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.user_List.FormattingEnabled = true;
        	this.user_List.Location = new System.Drawing.Point(0, 0);
        	this.user_List.Name = "user_List";
        	this.user_List.Size = new System.Drawing.Size(75, 212);
        	this.user_List.TabIndex = 0;
        	this.user_List.SelectedIndexChanged += new System.EventHandler(this.User_ListSelectedIndexChanged);
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.AutoSize = true;
        	this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.tableLayoutPanel1.ColumnCount = 2;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
        	this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
        	this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.username_Text, 1, 0);
        	this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.password_Text, 1, 1);
        	this.tableLayoutPanel1.Controls.Add(this.fullName_Text, 1, 2);
        	this.tableLayoutPanel1.Controls.Add(this.hashingMethod_ComboBox, 1, 3);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 4;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 105);
        	this.tableLayoutPanel1.TabIndex = 0;
        	// 
        	// panel4
        	// 
        	this.panel4.AutoSize = true;
        	this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.panel4.Controls.Add(this.label4);
        	this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel4.Location = new System.Drawing.Point(0, 78);
        	this.panel4.Margin = new System.Windows.Forms.Padding(0);
        	this.panel4.Name = "panel4";
        	this.panel4.Size = new System.Drawing.Size(77, 27);
        	this.panel4.TabIndex = 2;
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(3, 6);
        	this.label4.Margin = new System.Windows.Forms.Padding(3);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(71, 13);
        	this.label4.TabIndex = 4;
        	this.label4.Text = "Hash Method";
        	// 
        	// panel1
        	// 
        	this.panel1.AutoScroll = true;
        	this.panel1.AutoSize = true;
        	this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Margin = new System.Windows.Forms.Padding(0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(77, 26);
        	this.panel1.TabIndex = 1;
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(2, 6);
        	this.label1.Margin = new System.Windows.Forms.Padding(3);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(55, 13);
        	this.label1.TabIndex = 2;
        	this.label1.Text = "Username";
        	// 
        	// username_Text
        	// 
        	this.username_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.username_Text.Location = new System.Drawing.Point(80, 3);
        	this.username_Text.Name = "username_Text";
        	this.username_Text.Size = new System.Drawing.Size(130, 20);
        	this.username_Text.TabIndex = 0;
        	// 
        	// panel3
        	// 
        	this.panel3.AutoSize = true;
        	this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.panel3.Controls.Add(this.label3);
        	this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel3.Location = new System.Drawing.Point(0, 52);
        	this.panel3.Margin = new System.Windows.Forms.Padding(0);
        	this.panel3.Name = "panel3";
        	this.panel3.Size = new System.Drawing.Size(77, 26);
        	this.panel3.TabIndex = 1;
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(3, 6);
        	this.label3.Margin = new System.Windows.Forms.Padding(3);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(54, 13);
        	this.label3.TabIndex = 4;
        	this.label3.Text = "Full Name";
        	// 
        	// panel2
        	// 
        	this.panel2.AutoSize = true;
        	this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        	this.panel2.Controls.Add(this.label2);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel2.Location = new System.Drawing.Point(0, 26);
        	this.panel2.Margin = new System.Windows.Forms.Padding(0);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(77, 26);
        	this.panel2.TabIndex = 1;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(2, 6);
        	this.label2.Margin = new System.Windows.Forms.Padding(3);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(53, 13);
        	this.label2.TabIndex = 3;
        	this.label2.Text = "Password";
        	this.toolTip.SetToolTip(this.label2, "If a blank password is entered the password will not be changed");
        	// 
        	// password_Text
        	// 
        	this.password_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.password_Text.Location = new System.Drawing.Point(80, 29);
        	this.password_Text.Name = "password_Text";
        	this.password_Text.Size = new System.Drawing.Size(130, 20);
        	this.password_Text.TabIndex = 1;
        	this.password_Text.Text = "........";
        	this.toolTip.SetToolTip(this.password_Text, "If a blank password is entered the password will not be changed");
        	this.password_Text.UseSystemPasswordChar = true;
        	this.password_Text.Leave += new System.EventHandler(this.Password_TextLeave);
        	this.password_Text.Enter += new System.EventHandler(this.Password_TextEnter);
        	// 
        	// fullName_Text
        	// 
        	this.fullName_Text.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.fullName_Text.Location = new System.Drawing.Point(80, 55);
        	this.fullName_Text.Name = "fullName_Text";
        	this.fullName_Text.Size = new System.Drawing.Size(130, 20);
        	this.fullName_Text.TabIndex = 1;
        	// 
        	// hashingMethod_ComboBox
        	// 
        	this.hashingMethod_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.hashingMethod_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.hashingMethod_ComboBox.FormattingEnabled = true;
        	this.hashingMethod_ComboBox.Location = new System.Drawing.Point(80, 81);
        	this.hashingMethod_ComboBox.Name = "hashingMethod_ComboBox";
        	this.hashingMethod_ComboBox.Size = new System.Drawing.Size(130, 21);
        	this.hashingMethod_ComboBox.TabIndex = 3;
        	// 
        	// splitContainer2
        	// 
        	this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
        	this.splitContainer2.IsSplitterFixed = true;
        	this.splitContainer2.Location = new System.Drawing.Point(0, 0);
        	this.splitContainer2.Name = "splitContainer2";
        	this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
        	// 
        	// splitContainer2.Panel1
        	// 
        	this.splitContainer2.Panel1.Controls.Add(this.toolStrip);
        	// 
        	// splitContainer2.Panel2
        	// 
        	this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
        	this.splitContainer2.Size = new System.Drawing.Size(292, 239);
        	this.splitContainer2.SplitterDistance = 25;
        	this.splitContainer2.SplitterWidth = 1;
        	this.splitContainer2.TabIndex = 1;
        	// 
        	// toolStrip
        	// 
        	this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
        	this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripButton,
        	        	        	this.saveToolStripButton,
        	        	        	this.toolStripSeparator,
        	        	        	this.cutToolStripButton,
        	        	        	this.copyToolStripButton,
        	        	        	this.pasteToolStripButton});
        	this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
        	this.toolStrip.Location = new System.Drawing.Point(0, 0);
        	this.toolStrip.Name = "toolStrip";
        	this.toolStrip.Size = new System.Drawing.Size(292, 25);
        	this.toolStrip.Stretch = true;
        	this.toolStrip.TabIndex = 0;
        	this.toolStrip.Text = "toolStrip1";
        	// 
        	// newToolStripButton
        	// 
        	this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
        	this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripButton.Name = "newToolStripButton";
        	this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.newToolStripButton.Text = "&New";
        	this.newToolStripButton.Click += new System.EventHandler(this.NewToolStripButtonClick);
        	// 
        	// saveToolStripButton
        	// 
        	this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
        	this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveToolStripButton.Name = "saveToolStripButton";
        	this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.saveToolStripButton.Text = "&Save";
        	this.saveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButtonClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
        	// 
        	// cutToolStripButton
        	// 
        	this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
        	this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.cutToolStripButton.Name = "cutToolStripButton";
        	this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.cutToolStripButton.Text = "C&ut";
        	this.cutToolStripButton.Click += new System.EventHandler(this.CutToolStripButtonClick);
        	// 
        	// copyToolStripButton
        	// 
        	this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
        	this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.copyToolStripButton.Name = "copyToolStripButton";
        	this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.copyToolStripButton.Text = "&Copy";
        	this.copyToolStripButton.Click += new System.EventHandler(this.CopyToolStripButtonClick);
        	// 
        	// pasteToolStripButton
        	// 
        	this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        	this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
        	this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.pasteToolStripButton.Name = "pasteToolStripButton";
        	this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
        	this.pasteToolStripButton.Text = "&Paste";
        	this.pasteToolStripButton.Click += new System.EventHandler(this.PasteToolStripButtonClick);
        	// 
        	// errorProvider
        	// 
        	this.errorProvider.ContainerControl = this;
        	this.errorProvider.RightToLeft = true;
        	// 
        	// UserEditor
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 239);
        	this.Controls.Add(this.splitContainer2);
        	this.Name = "UserEditor";
        	this.Text = "User Editor";
        	this.Load += new System.EventHandler(this.UserEditorLoad);
        	this.splitContainer1.Panel1.ResumeLayout(false);
        	this.splitContainer1.Panel2.ResumeLayout(false);
        	this.splitContainer1.Panel2.PerformLayout();
        	this.splitContainer1.ResumeLayout(false);
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel1.PerformLayout();
        	this.panel4.ResumeLayout(false);
        	this.panel4.PerformLayout();
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	this.panel3.ResumeLayout(false);
        	this.panel3.PerformLayout();
        	this.panel2.ResumeLayout(false);
        	this.panel2.PerformLayout();
        	this.splitContainer2.Panel1.ResumeLayout(false);
        	this.splitContainer2.Panel1.PerformLayout();
        	this.splitContainer2.Panel2.ResumeLayout(false);
        	this.splitContainer2.ResumeLayout(false);
        	this.toolStrip.ResumeLayout(false);
        	this.toolStrip.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.TextBox fullName_Text;
        private System.Windows.Forms.TextBox password_Text;
        private System.Windows.Forms.TextBox username_Text;
        private System.Windows.Forms.ComboBox hashingMethod_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ListBox user_List;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
