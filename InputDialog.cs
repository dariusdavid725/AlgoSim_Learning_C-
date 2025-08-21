using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoSimLearning
{
	public partial class InputDialog : Form
	{
		public int Cost { get; private set; }

		public InputDialog()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtCost.Text, out int cost))
			{
				Cost = cost;
				DialogResult = DialogResult.OK;
			}
			else
			{
				MessageBox.Show("Te rog introdu un număr întreg pozitiv pentru cost!");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}

}
