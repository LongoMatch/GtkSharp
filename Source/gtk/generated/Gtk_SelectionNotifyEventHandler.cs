// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void SelectionNotifyEventHandler(object o, SelectionNotifyEventArgs args);

	public class SelectionNotifyEventArgs : GLib.SignalArgs {
		public Gdk.EventSelection Event{
			get {
				return (Gdk.EventSelection) Args [0];
			}
		}

	}
}