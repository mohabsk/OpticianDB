using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpticianDB.Forms.Dialogs
{
	/// <summary>
	/// Description of AddCondition.
	/// </summary>
	public partial class AddCondition : Form
	{
		DBBackEnd dbb;
		internal int SelectedCondition;
		public AddCondition()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dbb = new DBBackEnd();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			errorProvider1.Clear();
			if(textBox1.Text == string.Empty)
			{
				errorProvider1.SetError(textBox1,"Field cannot be empty");
				return;
			}
			int result = dbb.AddCondition(textBox1.Text);
			if(result == -1)
			{
				errorProvider1.SetError(textBox1,"Condition already exists");
				return;
			}
			SelectedCondition = result;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
		
		
		void Button2Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
