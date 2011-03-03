namespace OpticianDB.Forms
{
    partial class MainGui
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGui));
        	this.menuStrip1 = new System.Windows.Forms.MenuStrip();
        	this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        	this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.userEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.conditionsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addConditionOnPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuStrip1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip1
        	// 
        	this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.patientManagementToolStripMenuItem,
        	        	        	this.managementToolStripMenuItem,
        	        	        	this.developerToolStripMenuItem});
        	this.menuStrip1.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip1.Name = "menuStrip1";
        	this.menuStrip1.Size = new System.Drawing.Size(292, 24);
        	this.menuStrip1.TabIndex = 0;
        	this.menuStrip1.Text = "menuStrip1";
        	// 
        	// patientManagementToolStripMenuItem
        	// 
        	this.patientManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripMenuItem1,
        	        	        	this.toolStripMenuItem2});
        	this.patientManagementToolStripMenuItem.Name = "patientManagementToolStripMenuItem";
        	this.patientManagementToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
        	this.patientManagementToolStripMenuItem.Text = "&Patient Management";
        	// 
        	// toolStripMenuItem1
        	// 
        	this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
        	this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripMenuItem1.Name = "toolStripMenuItem1";
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
        	this.toolStripMenuItem1.Text = "&New Patient";
        	this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
        	// 
        	// toolStripMenuItem2
        	// 
        	this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
        	this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        	this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
        	this.toolStripMenuItem2.Text = "&Open Patient";
        	this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2Click);
        	// 
        	// managementToolStripMenuItem
        	// 
        	this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.userEditorToolStripMenuItem,
        	        	        	this.conditionsManagerToolStripMenuItem});
        	this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
        	this.managementToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        	this.managementToolStripMenuItem.Text = "&Admin";
        	// 
        	// userEditorToolStripMenuItem
        	// 
        	this.userEditorToolStripMenuItem.Name = "userEditorToolStripMenuItem";
        	this.userEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.userEditorToolStripMenuItem.Text = "User Editor";
        	this.userEditorToolStripMenuItem.Click += new System.EventHandler(this.UserEditorToolStripMenuItemClick);
        	// 
        	// conditionsManagerToolStripMenuItem
        	// 
        	this.conditionsManagerToolStripMenuItem.Name = "conditionsManagerToolStripMenuItem";
        	this.conditionsManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.conditionsManagerToolStripMenuItem.Text = "Conditions Manager";
        	this.conditionsManagerToolStripMenuItem.Click += new System.EventHandler(this.ConditionsManagerToolStripMenuItemClick);
        	// 
        	// developerToolStripMenuItem
        	// 
        	this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.addConditionOnPatientToolStripMenuItem});
        	this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
        	this.developerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
        	this.developerToolStripMenuItem.Text = "&Developer";
        	// 
        	// addConditionOnPatientToolStripMenuItem
        	// 
        	this.addConditionOnPatientToolStripMenuItem.Name = "addConditionOnPatientToolStripMenuItem";
        	this.addConditionOnPatientToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
        	this.addConditionOnPatientToolStripMenuItem.Text = "AddConditionOnPatient";
        	// 
        	// MainGui
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 266);
        	this.Controls.Add(this.menuStrip1);
        	this.MainMenuStrip = this.menuStrip1;
        	this.Name = "MainGui";
        	this.Text = "MainGUI";
        	this.menuStrip1.ResumeLayout(false);
        	this.menuStrip1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem addConditionOnPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
    }
}