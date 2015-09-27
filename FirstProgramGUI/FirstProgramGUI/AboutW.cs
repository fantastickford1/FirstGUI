using System;
using FirstProgramGUI;
using Gtk;

namespace FirstProgramGUI
{
	public partial class AboutW : Gtk.Dialog
	{
		public AboutW ()
		{
			this.Build ();
		}

		protected void OnOkClick (object sender, EventArgs e)
		{
			FirstProgramGUI.AboutW diagAbut = new FirstProgramGUI.AboutW ();
			diagAbut.Hide ();
		}
	}
}

