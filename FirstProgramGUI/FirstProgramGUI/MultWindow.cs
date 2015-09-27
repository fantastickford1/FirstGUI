using System;

namespace FirstProgramGUI
{
	public partial class MultWindow : Gtk.Window
	{
		public MultWindow () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

