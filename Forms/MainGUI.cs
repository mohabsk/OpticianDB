using System;
using System.Windows.Forms;

namespace OpticianDB.Forms
{
	public partial class MainGui : Form
	{
		public MainGui()
		{ //TODO:add to the sql that it stores the glasses conscriptions and the lens conscriptions
			//TODO:add unique and triggers to the sql
			//TODO:add preferred method of recall
			//TODO:add opt in to newsletter
			
			InitializeComponent();
		}
		
		void UserEditorToolStripMenuItemClick(object sender, EventArgs e)
		{
			Forms.UserEditor ue1 = new Forms.UserEditor();
			ue1.Show();
		}
		
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			NewPatient np1 = new NewPatient();
			np1.Show();
		}
		
		void ConditionsManagerToolStripMenuItemClick(object sender, EventArgs e)
		{
			Conditions cn1 = new Conditions();
			cn1.Show();
		}
        
        void ToolStripMenuItem2Click(object sender, EventArgs e)
        {
        	PatientList ul1 = new PatientList();
        	ul1.ShowDialog();
        }
        
	}
}
