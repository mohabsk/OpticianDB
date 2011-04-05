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
	partial class NewAppointment
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
			if (disposing) {
				if (components != null) {
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
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            this.appointments_DayView = new Calendar.DayView();
            this.optician_ComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentDate_DateTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.remarks_Text = new System.Windows.Forms.TextBox();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // appointments_DayView
            // 
            drawTool1.DayView = this.appointments_DayView;
            this.appointments_DayView.ActiveTool = drawTool1;
            this.appointments_DayView.AllowInplaceEditing = false;
            this.appointments_DayView.AllowNew = false;
            this.appointments_DayView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.appointments_DayView.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.appointments_DayView.HalfHourHeight = 15;
            this.appointments_DayView.Location = new System.Drawing.Point(12, 101);
            this.appointments_DayView.Name = "appointments_DayView";
            this.appointments_DayView.SelectionEnd = new System.DateTime(((long)(0)));
            this.appointments_DayView.SelectionStart = new System.DateTime(((long)(0)));
            this.appointments_DayView.Size = new System.Drawing.Size(253, 201);
            this.appointments_DayView.StartDate = new System.DateTime(((long)(0)));
            this.appointments_DayView.StartHour = 9;
            this.appointments_DayView.TabIndex = 0;
            this.appointments_DayView.Text = "dayView";
            this.appointments_DayView.WorkingHourEnd = 17;
            this.appointments_DayView.WorkingHourStart = 9;
            this.appointments_DayView.WorkingMinuteEnd = 0;
            this.appointments_DayView.WorkingMinuteStart = 0;
            this.appointments_DayView.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.RefreshCal);
            // 
            // optician_ComboBox
            // 
            this.optician_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optician_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optician_ComboBox.FormattingEnabled = true;
            this.optician_ComboBox.Location = new System.Drawing.Point(58, 3);
            this.optician_ComboBox.Name = "optician_ComboBox";
            this.optician_ComboBox.Size = new System.Drawing.Size(195, 21);
            this.optician_ComboBox.TabIndex = 1;
            this.optician_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Optician_ComboBoxSelectedIndexChanged);
            // 
            // appointmentDate_DateTime
            // 
            this.appointmentDate_DateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDate_DateTime.Location = new System.Drawing.Point(58, 30);
            this.appointmentDate_DateTime.Name = "appointmentDate_DateTime";
            this.appointmentDate_DateTime.Size = new System.Drawing.Size(195, 20);
            this.appointmentDate_DateTime.TabIndex = 2;
            this.appointmentDate_DateTime.Value = new System.DateTime(2011, 3, 24, 0, 0, 0, 0);
            this.appointmentDate_DateTime.ValueChanged += new System.EventHandler(this.AppointmentDate_DateTimeValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.optician_ComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.appointmentDate_DateTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.remarks_Text, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 83);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Optician";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Remarks";
            // 
            // remarks_Text
            // 
            this.remarks_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remarks_Text.Location = new System.Drawing.Point(58, 56);
            this.remarks_Text.Name = "remarks_Text";
            this.remarks_Text.Size = new System.Drawing.Size(195, 20);
            this.remarks_Text.TabIndex = 6;
            // 
            // confirm_Button
            // 
            this.confirm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirm_Button.Location = new System.Drawing.Point(162, 308);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(103, 23);
            this.confirm_Button.TabIndex = 4;
            this.confirm_Button.Text = "Book Appointment";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.Confirm_ButtonClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.RightToLeft = true;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 346);
            this.Controls.Add(this.confirm_Button);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.appointments_DayView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewAppointment";
            this.Text = "New Appointment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox remarks_Text;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button confirm_Button;
		private Calendar.DayView appointments_DayView;
		private System.Windows.Forms.ComboBox optician_ComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DateTimePicker appointmentDate_DateTime;
	}
}
