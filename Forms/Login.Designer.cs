namespace OpticianDB.Forms
{
    partial class Login
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
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        	this.LogoPictureBox = new System.Windows.Forms.PictureBox();
        	this.UsernameLabel = new System.Windows.Forms.Label();
        	this.PasswordLabel = new System.Windows.Forms.Label();
        	this.UsernameTextBox = new System.Windows.Forms.TextBox();
        	this.PasswordTextBox = new System.Windows.Forms.TextBox();
        	this.OK = new System.Windows.Forms.Button();
        	this.Cancel = new System.Windows.Forms.Button();
        	this.progressIndicator1 = new ProgressControls.ProgressIndicator();
        	this.login_BackgroundWorker = new System.ComponentModel.BackgroundWorker();
        	((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// LogoPictureBox
        	// 
        	this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
        	this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
        	this.LogoPictureBox.Name = "LogoPictureBox";
        	this.LogoPictureBox.Size = new System.Drawing.Size(165, 193);
        	this.LogoPictureBox.TabIndex = 0;
        	this.LogoPictureBox.TabStop = false;
        	// 
        	// UsernameLabel
        	// 
        	this.UsernameLabel.Location = new System.Drawing.Point(172, 24);
        	this.UsernameLabel.Name = "UsernameLabel";
        	this.UsernameLabel.Size = new System.Drawing.Size(220, 23);
        	this.UsernameLabel.TabIndex = 0;
        	this.UsernameLabel.Text = "&User name";
        	this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// PasswordLabel
        	// 
        	this.PasswordLabel.Location = new System.Drawing.Point(172, 81);
        	this.PasswordLabel.Name = "PasswordLabel";
        	this.PasswordLabel.Size = new System.Drawing.Size(220, 23);
        	this.PasswordLabel.TabIndex = 2;
        	this.PasswordLabel.Text = "&Password";
        	this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// UsernameTextBox
        	// 
        	this.UsernameTextBox.Location = new System.Drawing.Point(174, 44);
        	this.UsernameTextBox.Name = "UsernameTextBox";
        	this.UsernameTextBox.Size = new System.Drawing.Size(220, 20);
        	this.UsernameTextBox.TabIndex = 1;
        	// 
        	// PasswordTextBox
        	// 
        	this.PasswordTextBox.BackColor = System.Drawing.SystemColors.Window;
        	this.PasswordTextBox.Location = new System.Drawing.Point(174, 101);
        	this.PasswordTextBox.Name = "PasswordTextBox";
        	this.PasswordTextBox.PasswordChar = '*';
        	this.PasswordTextBox.Size = new System.Drawing.Size(220, 20);
        	this.PasswordTextBox.TabIndex = 3;
        	this.PasswordTextBox.UseSystemPasswordChar = true;
        	// 
        	// OK
        	// 
        	this.OK.Location = new System.Drawing.Point(197, 161);
        	this.OK.Name = "OK";
        	this.OK.Size = new System.Drawing.Size(94, 23);
        	this.OK.TabIndex = 4;
        	this.OK.Text = "&OK";
        	this.OK.Click += new System.EventHandler(this.OK_Click);
        	// 
        	// Cancel
        	// 
        	this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        	this.Cancel.Location = new System.Drawing.Point(300, 161);
        	this.Cancel.Name = "Cancel";
        	this.Cancel.Size = new System.Drawing.Size(94, 23);
        	this.Cancel.TabIndex = 5;
        	this.Cancel.Text = "&Cancel";
        	this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
        	// 
        	// progressIndicator1
        	// 
        	this.progressIndicator1.AutoStart = true;
        	this.progressIndicator1.Location = new System.Drawing.Point(370, 12);
        	this.progressIndicator1.Name = "progressIndicator1";
        	this.progressIndicator1.Percentage = 0F;
        	this.progressIndicator1.Size = new System.Drawing.Size(19, 19);
        	this.progressIndicator1.TabIndex = 6;
        	this.progressIndicator1.Text = "progressIndicator";
        	this.progressIndicator1.Visible = false;
        	// 
        	// login_BackgroundWorker
        	// 
        	this.login_BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Login_BackgroundWorkerDoWork);
        	this.login_BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Login_BackgroundWorkerRunWorkerCompleted);
        	// 
        	// LogOnForm
        	// 
        	this.AcceptButton = this.OK;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.CancelButton = this.Cancel;
        	this.ClientSize = new System.Drawing.Size(401, 192);
        	this.Controls.Add(this.progressIndicator1);
        	this.Controls.Add(this.Cancel);
        	this.Controls.Add(this.OK);
        	this.Controls.Add(this.PasswordTextBox);
        	this.Controls.Add(this.UsernameTextBox);
        	this.Controls.Add(this.PasswordLabel);
        	this.Controls.Add(this.UsernameLabel);
        	this.Controls.Add(this.LogoPictureBox);
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "LogOnForm";
        	this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        	this.Text = "Login";
        	((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.ComponentModel.BackgroundWorker login_BackgroundWorker;
        private ProgressControls.ProgressIndicator progressIndicator1;

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.TextBox UsernameTextBox;
    }
}