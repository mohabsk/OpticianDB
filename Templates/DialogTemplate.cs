using System;
using System.Drawing;
using System.Windows.Forms;

namespace OpticianDB
{
    /// <summary>
    /// Description of AddCondition.
    /// </summary>
    public partial class AddCondition : Form
    {
        public AddCondition()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

        }

        void Button1Click(object sender, EventArgs e)
        {
            this.DialogResult == DialogResult.OK;
            this.Close();
        }


        void Button2Click(object sender, EventArgs e)
        {
            this.DialogResult == DialogResult.Cancel;
            this.Close();
        }
    }
}
