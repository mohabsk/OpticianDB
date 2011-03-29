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
using System.Collections.Generic;
using Calendar;

namespace OpticianDB.Forms.Dialogs
{
	partial class AppointmentsOnDate
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
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            this.appointments_DayView = new Calendar.DayView();
            this.optician_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // appointments_DayView
            // 
            drawTool1.DayView = this.appointments_DayView;
            this.appointments_DayView.ActiveTool = drawTool1;
            this.appointments_DayView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.appointments_DayView.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.appointments_DayView.Location = new System.Drawing.Point(0, 21);
            this.appointments_DayView.Margin = new System.Windows.Forms.Padding(0);
            this.appointments_DayView.Name = "appointments_DayView";
            this.appointments_DayView.SelectionEnd = new System.DateTime(((long)(0)));
            this.appointments_DayView.SelectionStart = new System.DateTime(((long)(0)));
            this.appointments_DayView.Size = new System.Drawing.Size(284, 241);
            this.appointments_DayView.StartDate = new System.DateTime(((long)(0)));
            this.appointments_DayView.TabIndex = 0;
            this.appointments_DayView.Text = "dayView1";
            this.appointments_DayView.ResolveAppointments += new Calendar.ResolveAppointmentsEventHandler(this.Appointment_DayViewResolveAppointments);
            // 
            // optician_ComboBox
            // 
            this.optician_ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.optician_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.optician_ComboBox.FormattingEnabled = true;
            this.optician_ComboBox.Location = new System.Drawing.Point(0, 0);
            this.optician_ComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.optician_ComboBox.Name = "optician_ComboBox";
            this.optician_ComboBox.Size = new System.Drawing.Size(284, 21);
            this.optician_ComboBox.TabIndex = 1;
            this.optician_ComboBox.SelectedIndexChanged += new System.EventHandler(this.optician_ComboBox_SelectedIndexChanged);
            // 
            // AppointmentsOnDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.optician_ComboBox);
            this.Controls.Add(this.appointments_DayView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AppointmentsOnDate";
            this.Text = "Appointment Check";
            this.ResumeLayout(false);

		}

        private Calendar.DayView appointments_DayView;
        private System.Windows.Forms.ComboBox optician_ComboBox;
	}
}
