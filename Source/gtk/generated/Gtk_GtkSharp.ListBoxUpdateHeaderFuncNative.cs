// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GtkSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void ListBoxUpdateHeaderFuncNative(IntPtr row, IntPtr before, IntPtr user_data);

	internal class ListBoxUpdateHeaderFuncInvoker {

		ListBoxUpdateHeaderFuncNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~ListBoxUpdateHeaderFuncInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal ListBoxUpdateHeaderFuncInvoker (ListBoxUpdateHeaderFuncNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal ListBoxUpdateHeaderFuncInvoker (ListBoxUpdateHeaderFuncNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal ListBoxUpdateHeaderFuncInvoker (ListBoxUpdateHeaderFuncNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gtk.ListBoxUpdateHeaderFunc Handler {
			get {
				return new Gtk.ListBoxUpdateHeaderFunc(InvokeNative);
			}
		}

		void InvokeNative (Gtk.ListBoxRow row, Gtk.ListBoxRow before)
		{
			native_cb (row == null ? IntPtr.Zero : row.Handle, before == null ? IntPtr.Zero : before.Handle, __data);
		}
	}

	internal class ListBoxUpdateHeaderFuncWrapper {

		public void NativeCallback (IntPtr row, IntPtr before, IntPtr user_data)
		{
			try {
				managed (GLib.Object.GetObject(row) as Gtk.ListBoxRow, GLib.Object.GetObject(before) as Gtk.ListBoxRow);
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal ListBoxUpdateHeaderFuncNative NativeDelegate;
		Gtk.ListBoxUpdateHeaderFunc managed;

		public ListBoxUpdateHeaderFuncWrapper (Gtk.ListBoxUpdateHeaderFunc managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new ListBoxUpdateHeaderFuncNative (NativeCallback);
		}

		public static Gtk.ListBoxUpdateHeaderFunc GetManagedDelegate (ListBoxUpdateHeaderFuncNative native)
		{
			if (native == null)
				return null;
			ListBoxUpdateHeaderFuncWrapper wrapper = (ListBoxUpdateHeaderFuncWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
