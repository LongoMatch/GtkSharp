// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void ScrollChildHandler(object o, ScrollChildArgs args);

	public class ScrollChildArgs : GLib.SignalArgs {
		public Gtk.ScrollType Scroll{
			get {
				return (Gtk.ScrollType) Args [0];
			}
		}

		public bool Horizontal{
			get {
				return (bool) Args [1];
			}
		}

	}
}