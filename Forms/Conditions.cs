/*
 * Created by SharpDevelop.
 * User: pry09099729
 * Date: 03/03/2011
 * Time: 10:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpticianDB.Forms
{
	/// <summary>
	/// Description of Conditions.
	/// </summary>
	public partial class Conditions : Form
	{
		DBBackEnd dbb;
		public Conditions()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			dbb = new DBBackEnd();
			
			RefreshList();
		}

		void RefreshList()
		{
			listBox1.ClearSelected();
			listBox1.Items.Clear();
			foreach (string Condition in dbb.ConditionsList) {
				listBox1.Items.Add(Condition);
			}
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			using(Dialogs.AddCondition ac1 = new Dialogs.AddCondition())
			{
				DialogResult AddConditionResult = ac1.ShowDialog();
				if (AddConditionResult == DialogResult.OK)
				{
					RefreshList();
				}
			}
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex == -1)
				return;
		}
	}
}
