// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Pango {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class LayoutLine : GLib.Opaque {

		public Pango.Layout Layout {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("layout"));
					return GLib.Object.GetObject((*raw_ptr)) as Pango.Layout;
				}
			}
		}

		public int StartIndex {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("start_index"));
					return (*raw_ptr);
				}
			}
		}

		public int Length {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("length"));
					return (*raw_ptr);
				}
			}
		}

		public bool IsParagraphStart {
			get {
				unsafe {
					bool* raw_ptr = (bool*)(((byte*)Handle) + abi_info.GetFieldOffset("is_paragraph_start"));
					return (*raw_ptr);
				}
			}
		}

		public uint ResolvedDir {
			get {
				unsafe {
					uint* raw_ptr = (uint*)(((byte*)Handle) + abi_info.GetFieldOffset("resolved_dir"));
					return (*raw_ptr);
				}
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_line_get_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetExtents(ref Pango.Rectangle ink_rect, ref Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = GLib.Marshaller.StructureToPtrAlloc (ink_rect);
			IntPtr native_logical_rect = GLib.Marshaller.StructureToPtrAlloc (logical_rect);
			pango_layout_line_get_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_line_get_pixel_extents(IntPtr raw, IntPtr ink_rect, IntPtr logical_rect);

		public void GetPixelExtents(ref Pango.Rectangle ink_rect, ref Pango.Rectangle logical_rect) {
			IntPtr native_ink_rect = GLib.Marshaller.StructureToPtrAlloc (ink_rect);
			IntPtr native_logical_rect = GLib.Marshaller.StructureToPtrAlloc (logical_rect);
			pango_layout_line_get_pixel_extents(Handle, native_ink_rect, native_logical_rect);
			ink_rect = Pango.Rectangle.New (native_ink_rect);
			Marshal.FreeHGlobal (native_ink_rect);
			logical_rect = Pango.Rectangle.New (native_logical_rect);
			Marshal.FreeHGlobal (native_logical_rect);
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_line_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = pango_layout_line_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_line_index_to_x(IntPtr raw, int index_, bool trailing, out int x_pos);

		public int IndexToX(int index_, bool trailing) {
			int x_pos;
			pango_layout_line_index_to_x(Handle, index_, trailing, out x_pos);
			return x_pos;
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool pango_layout_line_x_to_index(IntPtr raw, int x_pos, out int index_, out int trailing);

		public bool XToIndex(int x_pos, out int index_, out int trailing) {
			bool raw_ret = pango_layout_line_x_to_index(Handle, x_pos, out index_, out trailing);
			bool ret = raw_ret;
			return ret;
		}

		public LayoutLine(IntPtr raw) : base(raw) {}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_layout_line_ref(IntPtr raw);

		protected override void Ref (IntPtr raw)
		{
			if (!Owned) {
				pango_layout_line_ref (raw);
				Owned = true;
			}
		}

		[Obsolete("Pango.LayoutLine is now refcounted automatically")]
		public LayoutLine Ref () { return this; }

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_layout_line_unref(IntPtr raw);

		protected override void Unref (IntPtr raw)
		{
			if (Owned) {
				pango_layout_line_unref (raw);
				Owned = false;
			}
		}

		[Obsolete("Pango.LayoutLine is now refcounted automatically")]
		public void Unref () {}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				pango_layout_line_unref (handle);
				return false;
			}
		}

		~LayoutLine ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("layout"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // layout
							, null
							, "start_index"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("start_index"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // start_index
							, "layout"
							, "length"
							, (long) Marshal.OffsetOf(typeof(PangoLayoutLine_start_indexAlign), "start_index")
							, 0
							),
						new GLib.AbiField("length"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // length
							, "start_index"
							, "runs"
							, (long) Marshal.OffsetOf(typeof(PangoLayoutLine_lengthAlign), "length")
							, 0
							),
						new GLib.AbiField("runs"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // runs
							, "length"
							, "is_paragraph_start"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("is_paragraph_start"
							, -1
							, (uint) Marshal.SizeOf(typeof(bool)) // is_paragraph_start
							, "runs"
							, "resolved_dir"
							, 1
							, 1
							),
						new GLib.AbiField("resolved_dir"
							, -1
							, (uint) Marshal.SizeOf(typeof(uint)) // resolved_dir
							, "is_paragraph_start"
							, null
							, 1
							, 3
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoLayoutLine_start_indexAlign
		{
			sbyte f1;
			private int start_index;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct PangoLayoutLine_lengthAlign
		{
			sbyte f1;
			private int length;
		}


		// End of the ABI representation.

#endregion
	}
}