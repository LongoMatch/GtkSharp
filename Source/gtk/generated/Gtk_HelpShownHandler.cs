// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void HelpShownHandler(object o, HelpShownArgs args);

	public class HelpShownArgs : GLib.SignalArgs {
		public Gtk.WidgetHelpType HelpType{
			get {
				return (Gtk.WidgetHelpType) Args [0];
			}
		}

	}
}