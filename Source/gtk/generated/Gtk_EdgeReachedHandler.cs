// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void EdgeReachedHandler(object o, EdgeReachedArgs args);

	public class EdgeReachedArgs : GLib.SignalArgs {
		public Gtk.PositionType P0{
			get {
				return (Gtk.PositionType) Args [0];
			}
		}

	}
}
