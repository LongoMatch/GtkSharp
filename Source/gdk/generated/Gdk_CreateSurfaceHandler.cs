// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;

	public delegate void CreateSurfaceHandler(object o, CreateSurfaceArgs args);

	public class CreateSurfaceArgs : GLib.SignalArgs {
		public int Width{
			get {
				return (int) Args [0];
			}
		}

		public int Height{
			get {
				return (int) Args [1];
			}
		}

	}
}