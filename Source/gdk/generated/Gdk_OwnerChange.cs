// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[GLib.GType (typeof (Gdk.OwnerChangeGType))]
	public enum OwnerChange {

		NewOwner,
		Destroy,
		Close,
	}

	internal class OwnerChangeGType {
		[DllImport ("libgdk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_owner_change_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gdk_owner_change_get_type ());
			}
		}
	}
#endregion
}
