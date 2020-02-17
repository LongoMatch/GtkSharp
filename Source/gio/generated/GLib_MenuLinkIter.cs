// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GLib {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuLinkIter : GLib.Object {

		public MenuLinkIter (IntPtr raw) : base(raw) {}

		protected MenuLinkIter() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		static GetNextNativeDelegate GetNext_cb_delegate;
		static GetNextNativeDelegate GetNextVMCallback {
			get {
				if (GetNext_cb_delegate == null)
					GetNext_cb_delegate = new GetNextNativeDelegate (GetNext_cb);
				return GetNext_cb_delegate;
			}
		}

		static void OverrideGetNext (GLib.GType gtype)
		{
			OverrideGetNext (gtype, GetNextVMCallback);
		}

		static void OverrideGetNext (GLib.GType gtype, GetNextNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_next"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate bool GetNextNativeDelegate (IntPtr inst, IntPtr out_link, IntPtr value);

		static bool GetNext_cb (IntPtr inst, IntPtr out_link, IntPtr value)
		{
			try {
				MenuLinkIter __obj = GLib.Object.GetObject (inst, false) as MenuLinkIter;
				bool __result;
				__result = __obj.OnGetNext (GLib.Marshaller.Utf8PtrToString (out_link), GLib.Object.GetObject(value) as GLib.MenuModel);
				return __result;
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(GLib.MenuLinkIter), ConnectionMethod="OverrideGetNext")]
		protected virtual bool OnGetNext (string out_link, GLib.MenuModel value)
		{
			return InternalGetNext (out_link, value);
		}

		private bool InternalGetNext (string out_link, GLib.MenuModel value)
		{
			GetNextNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_next"));
				unmanaged = (GetNextNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetNextNativeDelegate));
			}
			if (unmanaged == null) return false;

			IntPtr native_out_link = GLib.Marshaller.StringToPtrGStrdup (out_link);
			bool __result = unmanaged (this.Handle, native_out_link, value == null ? IntPtr.Zero : value.Handle);
			GLib.Marshaller.Free (native_out_link);
			return __result;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("get_next"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_next
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_link_iter_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = g_menu_link_iter_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_menu_link_iter_get_next(IntPtr raw, IntPtr out_link, IntPtr value);

		public bool GetNext(string out_link, GLib.MenuModel value) {
			IntPtr native_out_link = GLib.Marshaller.StringToPtrGStrdup (out_link);
			bool raw_ret = g_menu_link_iter_get_next(Handle, native_out_link, value == null ? IntPtr.Zero : value.Handle);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_out_link);
			return ret;
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_link_iter_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = g_menu_link_iter_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr g_menu_link_iter_get_value(IntPtr raw);

		public GLib.MenuModel Value { 
			get {
				IntPtr raw_ret = g_menu_link_iter_get_value(Handle);
				GLib.MenuModel ret = GLib.Object.GetObject(raw_ret) as GLib.MenuModel;
				return ret;
			}
		}

		[DllImport("gio-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool g_menu_link_iter_next(IntPtr raw);

		public bool Next() {
			bool raw_ret = g_menu_link_iter_next(Handle);
			bool ret = raw_ret;
			return ret;
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
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
