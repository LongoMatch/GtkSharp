// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Alignment : Gtk.Bin {

		public Alignment (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_alignment_new(float xalign, float yalign, float xscale, float yscale);

		public Alignment (float xalign, float yalign, float xscale, float yscale) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Alignment)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("xalign");
				vals.Add (new GLib.Value (xalign));
				names.Add ("yalign");
				vals.Add (new GLib.Value (yalign));
				names.Add ("xscale");
				vals.Add (new GLib.Value (xscale));
				names.Add ("yscale");
				vals.Add (new GLib.Value (yscale));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_alignment_new(xalign, yalign, xscale, yscale);
		}

		[GLib.Property ("xalign")]
		public float Xalign {
			get {
				GLib.Value val = GetProperty ("xalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("xalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("yalign")]
		public float Yalign {
			get {
				GLib.Value val = GetProperty ("yalign");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("yalign", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("xscale")]
		public float Xscale {
			get {
				GLib.Value val = GetProperty ("xscale");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("xscale", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("yscale")]
		public float Yscale {
			get {
				GLib.Value val = GetProperty ("yscale");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("yscale", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("top-padding")]
		public uint TopPadding {
			get {
				GLib.Value val = GetProperty ("top-padding");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("top-padding", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("bottom-padding")]
		public uint BottomPadding {
			get {
				GLib.Value val = GetProperty ("bottom-padding");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("bottom-padding", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("left-padding")]
		public uint LeftPadding {
			get {
				GLib.Value val = GetProperty ("left-padding");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("left-padding", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("right-padding")]
		public uint RightPadding {
			get {
				GLib.Value val = GetProperty ("right-padding");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("right-padding", val);
				val.Dispose ();
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_get_padding(IntPtr raw, out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right);

		[Obsolete]
		public void GetPadding(out uint padding_top, out uint padding_bottom, out uint padding_left, out uint padding_right) {
			gtk_alignment_get_padding(Handle, out padding_top, out padding_bottom, out padding_left, out padding_right);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_alignment_get_type();

		[Obsolete]
		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_alignment_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_set(IntPtr raw, float xalign, float yalign, float xscale, float yscale);

		[Obsolete]
		public void Set(float xalign, float yalign, float xscale, float yscale) {
			gtk_alignment_set(Handle, xalign, yalign, xscale, yscale);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_alignment_set_padding(IntPtr raw, uint padding_top, uint padding_bottom, uint padding_left, uint padding_right);

		[Obsolete]
		public void SetPadding(uint padding_top, uint padding_bottom, uint padding_left, uint padding_right) {
			gtk_alignment_set_padding(Handle, padding_top, padding_bottom, padding_left, padding_right);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Bin.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
