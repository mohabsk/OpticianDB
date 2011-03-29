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
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.recallsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.appointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.patientManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
        	this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.userEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.conditionsManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.storedEmailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.menuStrip.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.tasksToolStripMenuItem,
        	        	        	this.patientManagementToolStripMenuItem,
        	        	        	this.managementToolStripMenuItem});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.Size = new System.Drawing.Size(292, 24);
        	this.menuStrip.TabIndex = 0;
        	this.menuStrip.Text = "menuStrip";
        	// 
        	// tasksToolStripMenuItem
        	// 
        	this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.recallsToolStripMenuItem1,
        	        	        	this.appointmentsToolStripMenuItem});
        	this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
        	this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
        	this.tasksToolStripMenuItem.Text = "&Tasks";
        	// 
        	// recallsToolStripMenuItem1
        	// 
        	this.recallsToolStripMenuItem1.Name = "recallsToolStripMenuItem1";
        	this.recallsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        	this.recallsToolStripMenuItem1.Text = "&Recalls";
        	this.recallsToolStripMenuItem1.Click += new System.EventHandler(this.RecallsToolStripMenuItemClick);
        	// 
        	// appointmentsToolStripMenuItem
        	// 
        	this.appointmentsToolStripMenuItem.Name = "appointmentsToolStripMenuItem";
        	this.appointmentsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.appointmentsToolStripMenuItem.Text = "&Appointments";
        	this.appointmentsToolStripMenuItem.Click += new System.EventHandler(this.AppointmentsToolStripMenuItemClick);
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
        	this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
        	this.toolStripMenuItem1.Text = "&New Patient";
        	this.toolStripMenuItem1.Click += new System.EventHandler(this.NewPatientToolStripMenuItemClick);
        	// 
        	// toolStripMenuItem2
        	// 
        	this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
        	this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.toolStripMenuItem2.Name = "toolStripMenuItem2";
        	this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
        	this.toolStripMenuItem2.Text = "&Open Patient";
        	this.toolStripMenuItem2.Click += new System.EventHandler(this.PatientListToolStripMenuItemClick);
        	// 
        	// managementToolStripMenuItem
        	// 
        	this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.userEditorToolStripMenuItem,
        	        	        	this.conditionsManagerToolStripMenuItem,
        	        	        	this.storedEmailsToolStripMenuItem,
        	        	        	this.aboutToolStripMenuItem});
        	this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
        	this.managementToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
        	this.managementToolStripMenuItem.Text = "&Admin";
        	// 
        	// userEditorToolStripMenuItem
        	// 
        	this.userEditorToolStripMenuItem.Name = "userEditorToolStripMenuItem";
        	this.userEditorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.userEditorToolStripMenuItem.Text = "&User Editor";
        	this.userEditorToolStripMenuItem.Click += new System.EventHandler(this.UserEditorToolStripMenuItemClick);
        	// 
        	// conditionsManagerToolStripMenuItem
        	// 
        	this.conditionsManagerToolStripMenuItem.Name = "conditionsManagerToolStripMenuItem";
        	this.conditionsManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.conditionsManagerToolStripMenuItem.Text = "&Conditions Manager";
        	this.conditionsManagerToolStripMenuItem.Click += new System.EventHandler(this.ConditionsManagerToolStripMenuItemClick);
        	// 
        	// storedEmailsToolStripMenuItem
        	// 
        	this.storedEmailsToolStripMenuItem.Name = "storedEmailsToolStripMenuItem";
        	this.storedEmailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.storedEmailsToolStripMenuItem.Text = "&Emails";
        	this.storedEmailsToolStripMenuItem.Click += new System.EventHandler(this.StoredEmailsToolStripMenuItemClick);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
        	this.aboutToolStripMenuItem.Text = "&About";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
        	// 
        	// MainGui
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(292, 266);
        	this.Controls.Add(this.menuStrip);
        	this.MainMenuStrip = this.menuStrip;
        	this.Name = "MainGui";
        	this.Text = "Optician DB";
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conditionsManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patientManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;

        #endregion
        private System.Windows.Forms.ToolStripMenuItem recallsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem appointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storedEmailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}