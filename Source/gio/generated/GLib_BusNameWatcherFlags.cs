// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GLib.BusNameWatcherFlagsGType))]
	public enum BusNameWatcherFlags {

		None,
		AutoStart = 1 << 0,
	}

	internal class BusNameWatcherFlagsGType {
		[DllImport ("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_bus_name_watcher_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (g_bus_name_watcher_flags_get_type ());
			}
		}
	}
#endregion
}
