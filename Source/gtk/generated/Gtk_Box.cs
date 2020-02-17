// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Box : Gtk.Container, Gtk.IOrientable {

		public Box (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_box_new(int orientation, int spacing);

		public Box (Gtk.Orientation orientation, int spacing) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Box)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				names.Add ("orientation");
				vals.Add (new GLib.Value (orientation));
				names.Add ("spacing");
				vals.Add (new GLib.Value (spacing));
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			Raw = gtk_box_new((int) orientation, spacing);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_box_get_spacing(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_spacing(IntPtr raw, int spacing);

		[GLib.Property ("spacing")]
		public int Spacing {
			get  {
				int raw_ret = gtk_box_get_spacing(Handle);
				int ret = raw_ret;
				return ret;
			}
			set  {
				gtk_box_set_spacing(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_box_get_homogeneous(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_homogeneous(IntPtr raw, bool homogeneous);

		[GLib.Property ("homogeneous")]
		public bool Homogeneous {
			get  {
				bool raw_ret = gtk_box_get_homogeneous(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_box_set_homogeneous(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_box_get_baseline_position(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_baseline_position(IntPtr raw, int position);

		[GLib.Property ("baseline-position")]
		public Gtk.BaselinePosition BaselinePosition {
			get  {
				int raw_ret = gtk_box_get_baseline_position(Handle);
				Gtk.BaselinePosition ret = (Gtk.BaselinePosition) raw_ret;
				return ret;
			}
			set  {
				gtk_box_set_baseline_position(Handle, (int) value);
			}
		}

		[GLib.Property ("expand")]
		public new bool Expand {
			get {
				GLib.Value val = GetProperty ("expand");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("expand", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("fill")]
		public bool Fill {
			get {
				GLib.Value val = GetProperty ("fill");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("fill", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("padding")]
		public uint Padding {
			get {
				GLib.Value val = GetProperty ("padding");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("padding", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("pack-type")]
		public Gtk.PackType PackType {
			get {
				GLib.Value val = GetProperty ("pack-type");
				Gtk.PackType ret = (Gtk.PackType) (Enum) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value((Enum) value);
				SetProperty("pack-type", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("position")]
		public int Position {
			get {
				GLib.Value val = GetProperty ("position");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("position", val);
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
							, Gtk.Container.class_abi.Fields
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
		static extern IntPtr gtk_box_get_center_widget(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_center_widget(IntPtr raw, IntPtr widget);

		public Gtk.Widget CenterWidget { 
			get {
				IntPtr raw_ret = gtk_box_get_center_widget(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set {
				gtk_box_set_center_widget(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_box_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_box_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_pack_end(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		public void PackEnd(Gtk.Widget child, bool expand, bool fill, uint padding) {
			gtk_box_pack_end(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_pack_start(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding);

		public void PackStart(Gtk.Widget child, bool expand, bool fill, uint padding) {
			gtk_box_pack_start(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_query_child_packing(IntPtr raw, IntPtr child, out bool expand, out bool fill, out uint padding, out int pack_type);

		public void QueryChildPacking(Gtk.Widget child, out bool expand, out bool fill, out uint padding, out Gtk.PackType pack_type) {
			int native_pack_type;
			gtk_box_query_child_packing(Handle, child == null ? IntPtr.Zero : child.Handle, out expand, out fill, out padding, out native_pack_type);
			pack_type = (Gtk.PackType) native_pack_type;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_reorder_child(IntPtr raw, IntPtr child, int position);

		public void ReorderChild(Gtk.Widget child, int position) {
			gtk_box_reorder_child(Handle, child == null ? IntPtr.Zero : child.Handle, position);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_box_set_child_packing(IntPtr raw, IntPtr child, bool expand, bool fill, uint padding, int pack_type);

		public void SetChildPacking(Gtk.Widget child, bool expand, bool fill, uint padding, Gtk.PackType pack_type) {
			gtk_box_set_child_packing(Handle, child == null ? IntPtr.Zero : child.Handle, expand, fill, padding, (int) pack_type);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_orientable_get_orientation(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_orientable_set_orientation(IntPtr raw, int orientation);

		[GLib.Property ("orientation")]
		public Gtk.Orientation Orientation {
			get  {
				int raw_ret = gtk_orientable_get_orientation(Handle);
				Gtk.Orientation ret = (Gtk.Orientation) raw_ret;
				return ret;
			}
			set  {
				gtk_orientable_set_orientation(Handle, (int) value);
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, Gtk.Container.abi_info.Fields
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
