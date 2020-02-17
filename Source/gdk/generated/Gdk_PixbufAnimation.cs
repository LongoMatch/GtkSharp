// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gdk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class PixbufAnimation : GLib.Object {

		public PixbufAnimation (IntPtr raw) : base(raw) {}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_animation_new_from_file(IntPtr filename, out IntPtr error);

		public unsafe PixbufAnimation (string filename) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufAnimation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			Raw = gdk_pixbuf_animation_new_from_file(native_filename, out error);
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_animation_new_from_file_utf8(IntPtr filename, out IntPtr error);

		public static unsafe PixbufAnimation NewFromFileUtf8(string filename)
		{
			IntPtr native_filename = GLib.Marshaller.StringToPtrGStrdup (filename);
			IntPtr error = IntPtr.Zero;
			PixbufAnimation result = new PixbufAnimation (gdk_pixbuf_animation_new_from_file_utf8(native_filename, out error));
			GLib.Marshaller.Free (native_filename);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_animation_new_from_resource(IntPtr resource_path, out IntPtr error);

		public static unsafe PixbufAnimation NewFromResource(string resource_path)
		{
			IntPtr native_resource_path = GLib.Marshaller.StringToPtrGStrdup (resource_path);
			IntPtr error = IntPtr.Zero;
			PixbufAnimation result = new PixbufAnimation (gdk_pixbuf_animation_new_from_resource(native_resource_path, out error));
			GLib.Marshaller.Free (native_resource_path);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return result;
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_animation_new_from_stream(IntPtr stream, IntPtr cancellable, out IntPtr error);

		public unsafe PixbufAnimation (GLib.InputStream stream, GLib.Cancellable cancellable) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufAnimation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr error = IntPtr.Zero;
			Raw = gdk_pixbuf_animation_new_from_stream(stream == null ? IntPtr.Zero : stream.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_new_from_stream_async(IntPtr stream, IntPtr cancellable, GLibSharp.AsyncReadyCallbackNative cb, IntPtr user_data);

		public PixbufAnimation (GLib.InputStream stream, GLib.Cancellable cancellable, GLib.AsyncReadyCallback cb) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufAnimation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			GLibSharp.AsyncReadyCallbackWrapper cb_wrapper = new GLibSharp.AsyncReadyCallbackWrapper (cb);
			Raw = gdk_pixbuf_animation_new_from_stream_async(stream == null ? IntPtr.Zero : stream.Handle, cancellable == null ? IntPtr.Zero : cancellable.Handle, cb_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern unsafe IntPtr gdk_pixbuf_animation_new_from_stream_finish(IntPtr async_result, out IntPtr error);

		public unsafe PixbufAnimation (GLib.IAsyncResult async_result) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (PixbufAnimation)) {
				var vals = new List<GLib.Value> ();
				var names = new List<string> ();
				CreateNativeObject (names.ToArray (), vals.ToArray ());
				return;
			}
			IntPtr error = IntPtr.Zero;
			Raw = gdk_pixbuf_animation_new_from_stream_finish(async_result == null ? IntPtr.Zero : ((async_result is GLib.Object) ? (async_result as GLib.Object).Handle : (async_result as GLib.AsyncResultAdapter).Handle), out error);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_pixbuf_animation_get_height(IntPtr raw);

		public int Height { 
			get {
				int raw_ret = gdk_pixbuf_animation_get_height(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_get_iter(IntPtr raw, IntPtr start_time);

		public Gdk.PixbufAnimationIter GetIter(IntPtr start_time) {
			IntPtr raw_ret = gdk_pixbuf_animation_get_iter(Handle, start_time);
			Gdk.PixbufAnimationIter ret = GLib.Object.GetObject(raw_ret) as Gdk.PixbufAnimationIter;
			return ret;
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_get_static_image(IntPtr raw);

		public Gdk.Pixbuf StaticImage { 
			get {
				IntPtr raw_ret = gdk_pixbuf_animation_get_static_image(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gdk_pixbuf_animation_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gdk_pixbuf_animation_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gdk_pixbuf_animation_get_width(IntPtr raw);

		public int Width { 
			get {
				int raw_ret = gdk_pixbuf_animation_get_width(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgdk_pixbuf-2.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gdk_pixbuf_animation_is_static_image(IntPtr raw);

		public bool IsStaticImage { 
			get {
				bool raw_ret = gdk_pixbuf_animation_is_static_image(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

#endregion
	}
}
