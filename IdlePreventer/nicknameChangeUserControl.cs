using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdlePreventer
{
	public partial class nicknameChangeUserControl : UserControl
	{
		public nicknameChangeUserControl()
		{
			InitializeComponent();
		}

		private void nicknameChangeCharactersTextBox_Enter(object sender, EventArgs e)
		{
			nicknameChangeCharactersTextBox.SelectAll();
		}

		private void nicknameChangeCharactersTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			nicknameChangeCharactersTextBox.SelectAll();
		}
	}
}
