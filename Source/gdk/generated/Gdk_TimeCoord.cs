// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct TimeCoord : IEquatable<TimeCoord> {

		public uint Time;
		[MarshalAs (UnmanagedType.ByValArray, SizeConst=128)]
		public double[] Axes;

		public static Gdk.TimeCoord Zero = new Gdk.TimeCoord ();

		public static Gdk.TimeCoord New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gdk.TimeCoord.Zero;
			return (Gdk.TimeCoord) Marshal.PtrToStructure (raw, typeof (Gdk.TimeCoord));
		}

		public bool Equals (TimeCoord other)
		{
			return true && Time.Equals (other.Time) && Axes.Equals (other.Axes);
		}

		public override bool Equals (object other)
		{
			return other is TimeCoord && Equals ((TimeCoord) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Time.GetHashCode () ^ Axes.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}
