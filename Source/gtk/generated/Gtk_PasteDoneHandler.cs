// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void PasteDoneHandler(object o, PasteDoneArgs args);

	public class PasteDoneArgs : GLib.SignalArgs {
		public Gtk.Clipboard Clipboard{
			get {
				return (Gtk.Clipboard) Args [0];
			}
		}

	}
}
