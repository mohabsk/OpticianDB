using System;
using System.Windows.Forms;

namespace OpticianDB.Forms
{
	public partial class NewPatient : Form
	{
		DBBackEnd dbb;
		public NewPatient()
		{
			InitializeComponent();
			dbb = new DBBackEnd();
		}
		bool cansave()
		{
			bool errors = false;
			errorProvider1.Clear();
			if (textBox1.Text == string.Empty)
			{
				errorProvider1.SetError(textBox1,"Value cannot be empty");
				errors = true;
			}
			if(textBox2.Text == string.Empty)
			{
				errorProvider1.SetError(textBox2,"Value cannot be empty");
				errors = true;
			}
			if (textBox5.Text == string.Empty)
			{
				errorProvider1.SetError(textBox5,"Value cannot be empty");
				errors = true;
			}
			if(errors)
				return false;
			return true;
		}
		void AddPatient(object sender, EventArgs e)
		{
			if (!cansave())
			{
				return;
			}
			int result = dbb.AddPatient(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value, textBox5.Text, textBox6.Text);
			if (result == -1)
			{
				MessageBox.Show("Record already exists","Record Addition Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
			} else
			{
				PatientInfo pi = new PatientInfo(result);
				pi.Show();
				pi.Focus(); //FIXME
				this.Close();
			}
		}
		
		
		void AddAndContinue(object sender, EventArgs e)
		{
			
		}
	}
}
