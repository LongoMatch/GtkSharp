// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;

	public delegate void DragUpdateHandler(object o, DragUpdateArgs args);

	public class DragUpdateArgs : GLib.SignalArgs {
		public double OffsetX{
			get {
				return (double) Args [0];
			}
		}

		public double OffsetY{
			get {
				return (double) Args [1];
			}
		}

	}
}
