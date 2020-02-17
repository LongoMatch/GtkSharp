// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class MenuItem : Gtk.Bin, Gtk.IActivatable, Gtk.IActionable {

		public MenuItem (IntPtr raw) : base(raw) {}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_item_new();

		public MenuItem () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (MenuItem)) {
				CreateNativeObject (new string [0], new GLib.Value[0]);
				return;
			}
			Raw = gtk_menu_item_new();
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_menu_item_get_right_justified(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_right_justified(IntPtr raw, bool right_justified);

		[Obsolete]
		[GLib.Property ("right-justified")]
		public bool RightJustified {
			get  {
				bool raw_ret = gtk_menu_item_get_right_justified(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_item_set_right_justified(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_item_get_submenu(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_submenu(IntPtr raw, IntPtr submenu);

		[GLib.Property ("submenu")]
		public Gtk.Widget Submenu {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_submenu(Handle);
				Gtk.Widget ret = GLib.Object.GetObject(raw_ret) as Gtk.Widget;
				return ret;
			}
			set  {
				gtk_menu_item_set_submenu(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_item_get_accel_path(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_accel_path(IntPtr raw, IntPtr accel_path);

		[GLib.Property ("accel-path")]
		public string AccelPath {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_accel_path(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_item_set_accel_path(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_item_get_label(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_label(IntPtr raw, IntPtr label);

		[GLib.Property ("label")]
		public string Label {
			get  {
				IntPtr raw_ret = gtk_menu_item_get_label(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set  {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_menu_item_set_label(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_menu_item_get_use_underline(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_use_underline(IntPtr raw, bool setting);

		[GLib.Property ("use-underline")]
		public bool UseUnderline {
			get  {
				bool raw_ret = gtk_menu_item_get_use_underline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_menu_item_set_use_underline(Handle, value);
			}
		}

		[GLib.Property ("selected-shadow-type")]
		public Gtk.ShadowType SelectedShadowType {
			get {
				GLib.Value val = GetProperty ("selected-shadow-type");
				Gtk.ShadowType ret = (Gtk.ShadowType) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("horizontal-padding")]
		public int HorizontalPadding {
			get {
				GLib.Value val = GetProperty ("horizontal-padding");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("toggle-spacing")]
		public int ToggleSpacing {
			get {
				GLib.Value val = GetProperty ("toggle-spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("arrow-spacing")]
		public int ArrowSpacing {
			get {
				GLib.Value val = GetProperty ("arrow-spacing");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("arrow-scaling")]
		public float ArrowScaling {
			get {
				GLib.Value val = GetProperty ("arrow-scaling");
				float ret = (float) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("width-chars")]
		public int WidthChars {
			get {
				GLib.Value val = GetProperty ("width-chars");
				int ret = (int) val;
				val.Dispose ();
				return ret;
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeRequestedSignalDelegate (IntPtr inst, out int arg0, IntPtr gch);

		static void ToggleSizeRequestedSignalCallback (IntPtr inst, out int arg0, IntPtr gch)
		{
			Gtk.ToggleSizeRequestedArgs args = new Gtk.ToggleSizeRequestedArgs ();
			try {
				GLib.Signal sig = ((GCHandle) gch).Target as GLib.Signal;
				if (sig == null)
					throw new Exception("Unknown signal GC handle received " + gch);

				args.Args = new object[1];
				Gtk.ToggleSizeRequestedHandler handler = (Gtk.ToggleSizeRequestedHandler) sig.Handler;
				handler (GLib.Object.GetObject (inst), args);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}

			try {
				arg0 = ((int)args.Args[0]);
			} catch (Exception) {
				Exception ex = new Exception ("args.RetVal or 'out' property unset or set to incorrect type in Gtk.ToggleSizeRequestedHandler callback");
				GLib.ExceptionManager.RaiseUnhandledException (ex, true);
				// NOTREACHED: above call doesn't return.
				throw ex;
			}
		}

		[GLib.Signal("toggle-size-request")]
		public event Gtk.ToggleSizeRequestedHandler ToggleSizeRequested {
			add {
				this.AddSignalHandler ("toggle-size-request", value, new ToggleSizeRequestedSignalDelegate(ToggleSizeRequestedSignalCallback));
			}
			remove {
				this.RemoveSignalHandler ("toggle-size-request", value);
			}
		}

		[GLib.Signal("activate")]
		public event System.EventHandler Activated {
			add {
				this.AddSignalHandler ("activate", value);
			}
			remove {
				this.RemoveSignalHandler ("activate", value);
			}
		}

		[GLib.Signal("toggle-size-allocate")]
		public event Gtk.ToggleSizeAllocatedHandler ToggleSizeAllocated {
			add {
				this.AddSignalHandler ("toggle-size-allocate", value, typeof (Gtk.ToggleSizeAllocatedArgs));
			}
			remove {
				this.RemoveSignalHandler ("toggle-size-allocate", value);
			}
		}

		[GLib.Signal("deselect")]
		public event System.EventHandler Deselected {
			add {
				this.AddSignalHandler ("deselect", value);
			}
			remove {
				this.RemoveSignalHandler ("deselect", value);
			}
		}

		[GLib.Signal("select")]
		public event System.EventHandler Selected {
			add {
				this.AddSignalHandler ("select", value);
			}
			remove {
				this.RemoveSignalHandler ("select", value);
			}
		}

		[GLib.Signal("activate-item")]
		public event System.EventHandler ActivateItem {
			add {
				this.AddSignalHandler ("activate-item", value);
			}
			remove {
				this.RemoveSignalHandler ("activate-item", value);
			}
		}

		static ActivatedNativeDelegate Activated_cb_delegate;
		static ActivatedNativeDelegate ActivatedVMCallback {
			get {
				if (Activated_cb_delegate == null)
					Activated_cb_delegate = new ActivatedNativeDelegate (Activated_cb);
				return Activated_cb_delegate;
			}
		}

		static void OverrideActivated (GLib.GType gtype)
		{
			OverrideActivated (gtype, ActivatedVMCallback);
		}

		static void OverrideActivated (GLib.GType gtype, ActivatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivatedNativeDelegate (IntPtr inst);

		static void Activated_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnActivated ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideActivated")]
		protected virtual void OnActivated ()
		{
			InternalActivated ();
		}

		private void InternalActivated ()
		{
			ActivatedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("activate"));
				unmanaged = (ActivatedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActivatedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ActivateItemNativeDelegate ActivateItem_cb_delegate;
		static ActivateItemNativeDelegate ActivateItemVMCallback {
			get {
				if (ActivateItem_cb_delegate == null)
					ActivateItem_cb_delegate = new ActivateItemNativeDelegate (ActivateItem_cb);
				return ActivateItem_cb_delegate;
			}
		}

		static void OverrideActivateItem (GLib.GType gtype)
		{
			OverrideActivateItem (gtype, ActivateItemVMCallback);
		}

		static void OverrideActivateItem (GLib.GType gtype, ActivateItemNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("activate_item"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActivateItemNativeDelegate (IntPtr inst);

		static void ActivateItem_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnActivateItem ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideActivateItem")]
		protected virtual void OnActivateItem ()
		{
			InternalActivateItem ();
		}

		private void InternalActivateItem ()
		{
			ActivateItemNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("activate_item"));
				unmanaged = (ActivateItemNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ActivateItemNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static ToggleSizeRequestedNativeDelegate ToggleSizeRequested_cb_delegate;
		static ToggleSizeRequestedNativeDelegate ToggleSizeRequestedVMCallback {
			get {
				if (ToggleSizeRequested_cb_delegate == null)
					ToggleSizeRequested_cb_delegate = new ToggleSizeRequestedNativeDelegate (ToggleSizeRequested_cb);
				return ToggleSizeRequested_cb_delegate;
			}
		}

		static void OverrideToggleSizeRequested (GLib.GType gtype)
		{
			OverrideToggleSizeRequested (gtype, ToggleSizeRequestedVMCallback);
		}

		static void OverrideToggleSizeRequested (GLib.GType gtype, ToggleSizeRequestedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_request"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeRequestedNativeDelegate (IntPtr inst, out int requisition);

		static void ToggleSizeRequested_cb (IntPtr inst, out int requisition)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnToggleSizeRequested (out requisition);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideToggleSizeRequested")]
		protected virtual void OnToggleSizeRequested (out int requisition)
		{
			InternalToggleSizeRequested (out requisition);
		}

		private void InternalToggleSizeRequested (out int requisition)
		{
			ToggleSizeRequestedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_request"));
				unmanaged = (ToggleSizeRequestedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ToggleSizeRequestedNativeDelegate));
			}
			if (unmanaged == null) throw new InvalidOperationException ("No base method to invoke");

			unmanaged (this.Handle, out requisition);
		}

		static ToggleSizeAllocatedNativeDelegate ToggleSizeAllocated_cb_delegate;
		static ToggleSizeAllocatedNativeDelegate ToggleSizeAllocatedVMCallback {
			get {
				if (ToggleSizeAllocated_cb_delegate == null)
					ToggleSizeAllocated_cb_delegate = new ToggleSizeAllocatedNativeDelegate (ToggleSizeAllocated_cb);
				return ToggleSizeAllocated_cb_delegate;
			}
		}

		static void OverrideToggleSizeAllocated (GLib.GType gtype)
		{
			OverrideToggleSizeAllocated (gtype, ToggleSizeAllocatedVMCallback);
		}

		static void OverrideToggleSizeAllocated (GLib.GType gtype, ToggleSizeAllocatedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_allocate"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ToggleSizeAllocatedNativeDelegate (IntPtr inst, int allocation);

		static void ToggleSizeAllocated_cb (IntPtr inst, int allocation)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnToggleSizeAllocated (allocation);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideToggleSizeAllocated")]
		protected virtual void OnToggleSizeAllocated (int allocation)
		{
			InternalToggleSizeAllocated (allocation);
		}

		private void InternalToggleSizeAllocated (int allocation)
		{
			ToggleSizeAllocatedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("toggle_size_allocate"));
				unmanaged = (ToggleSizeAllocatedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(ToggleSizeAllocatedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle, allocation);
		}

		static SetLabelNativeDelegate SetLabel_cb_delegate;
		static SetLabelNativeDelegate SetLabelVMCallback {
			get {
				if (SetLabel_cb_delegate == null)
					SetLabel_cb_delegate = new SetLabelNativeDelegate (SetLabel_cb);
				return SetLabel_cb_delegate;
			}
		}

		static void OverrideSetLabel (GLib.GType gtype)
		{
			OverrideSetLabel (gtype, SetLabelVMCallback);
		}

		static void OverrideSetLabel (GLib.GType gtype, SetLabelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("set_label"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SetLabelNativeDelegate (IntPtr inst, IntPtr label);

		static void SetLabel_cb (IntPtr inst, IntPtr label)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnSetLabel (GLib.Marshaller.Utf8PtrToString (label));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideSetLabel")]
		protected virtual void OnSetLabel (string label)
		{
			InternalSetLabel (label);
		}

		private void InternalSetLabel (string label)
		{
			SetLabelNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("set_label"));
				unmanaged = (SetLabelNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SetLabelNativeDelegate));
			}
			if (unmanaged == null) return;

			IntPtr native_label = GLib.Marshaller.StringToPtrGStrdup (label);
			unmanaged (this.Handle, native_label);
			GLib.Marshaller.Free (native_label);
		}

		static GetLabelNativeDelegate GetLabel_cb_delegate;
		static GetLabelNativeDelegate GetLabelVMCallback {
			get {
				if (GetLabel_cb_delegate == null)
					GetLabel_cb_delegate = new GetLabelNativeDelegate (GetLabel_cb);
				return GetLabel_cb_delegate;
			}
		}

		static void OverrideGetLabel (GLib.GType gtype)
		{
			OverrideGetLabel (gtype, GetLabelVMCallback);
		}

		static void OverrideGetLabel (GLib.GType gtype, GetLabelNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("get_label"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate IntPtr GetLabelNativeDelegate (IntPtr inst);

		static IntPtr GetLabel_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				string __result;
				__result = __obj.OnGetLabel ();
				return GLib.Marshaller.StringToPtrGStrdup(__result);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call does not return.
				throw e;
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideGetLabel")]
		protected virtual string OnGetLabel ()
		{
			return InternalGetLabel ();
		}

		private string InternalGetLabel ()
		{
			GetLabelNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("get_label"));
				unmanaged = (GetLabelNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(GetLabelNativeDelegate));
			}
			if (unmanaged == null) return null;

			IntPtr __result = unmanaged (this.Handle);
			return GLib.Marshaller.PtrToStringGFree(__result);
		}

		static SelectedNativeDelegate Selected_cb_delegate;
		static SelectedNativeDelegate SelectedVMCallback {
			get {
				if (Selected_cb_delegate == null)
					Selected_cb_delegate = new SelectedNativeDelegate (Selected_cb);
				return Selected_cb_delegate;
			}
		}

		static void OverrideSelected (GLib.GType gtype)
		{
			OverrideSelected (gtype, SelectedVMCallback);
		}

		static void OverrideSelected (GLib.GType gtype, SelectedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("select"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SelectedNativeDelegate (IntPtr inst);

		static void Selected_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnSelected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideSelected")]
		protected virtual void OnSelected ()
		{
			InternalSelected ();
		}

		private void InternalSelected ()
		{
			SelectedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("select"));
				unmanaged = (SelectedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(SelectedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static DeselectedNativeDelegate Deselected_cb_delegate;
		static DeselectedNativeDelegate DeselectedVMCallback {
			get {
				if (Deselected_cb_delegate == null)
					Deselected_cb_delegate = new DeselectedNativeDelegate (Deselected_cb);
				return Deselected_cb_delegate;
			}
		}

		static void OverrideDeselected (GLib.GType gtype)
		{
			OverrideDeselected (gtype, DeselectedVMCallback);
		}

		static void OverrideDeselected (GLib.GType gtype, DeselectedNativeDelegate callback)
		{
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) gtype.GetClassPtr()) + (long) class_abi.GetFieldOffset("deselect"));
				*raw_ptr = Marshal.GetFunctionPointerForDelegate((Delegate) callback);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void DeselectedNativeDelegate (IntPtr inst);

		static void Deselected_cb (IntPtr inst)
		{
			try {
				MenuItem __obj = GLib.Object.GetObject (inst, false) as MenuItem;
				__obj.OnDeselected ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.MenuItem), ConnectionMethod="OverrideDeselected")]
		protected virtual void OnDeselected ()
		{
			InternalDeselected ();
		}

		private void InternalDeselected ()
		{
			DeselectedNativeDelegate unmanaged = null;
			unsafe {
				IntPtr* raw_ptr = (IntPtr*)(((long) this.LookupGType().GetThresholdType().GetClassPtr()) + (long) class_abi.GetFieldOffset("deselect"));
				unmanaged = (DeselectedNativeDelegate) Marshal.GetDelegateForFunctionPointer(*raw_ptr, typeof(DeselectedNativeDelegate));
			}
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("hide_on_activate"
							, Gtk.Bin.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(bool)) // hide_on_activate
							, null
							, "activate"
							, 1
							, 1
							),
						new GLib.AbiField("activate"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // activate
							, "hide_on_activate"
							, "activate_item"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("activate_item"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // activate_item
							, "activate"
							, "toggle_size_request"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("toggle_size_request"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // toggle_size_request
							, "activate_item"
							, "toggle_size_allocate"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("toggle_size_allocate"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // toggle_size_allocate
							, "toggle_size_request"
							, "set_label"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("set_label"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // set_label
							, "toggle_size_allocate"
							, "get_label"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("get_label"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // get_label
							, "set_label"
							, "select"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("select"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // select
							, "get_label"
							, "deselect"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("deselect"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // deselect
							, "select"
							, "_gtk_reserved1"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved1"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, "deselect"
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
		static extern void gtk_menu_item_activate(IntPtr raw);

		public new void Activate() {
			gtk_menu_item_activate(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_deselect(IntPtr raw);

		public void Deselect() {
			gtk_menu_item_deselect(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_menu_item_get_reserve_indicator(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_set_reserve_indicator(IntPtr raw, bool reserve);

		public bool ReserveIndicator { 
			get {
				bool raw_ret = gtk_menu_item_get_reserve_indicator(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_menu_item_set_reserve_indicator(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_menu_item_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_menu_item_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_select(IntPtr raw);

		public void Select() {
			gtk_menu_item_select(Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_toggle_size_allocate(IntPtr raw, int allocation);

		public void ToggleSizeAllocate(int allocation) {
			gtk_menu_item_toggle_size_allocate(Handle, allocation);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_menu_item_toggle_size_request(IntPtr raw, out int requisition);

		public int ToggleSizeRequest() {
			int requisition;
			gtk_menu_item_toggle_size_request(Handle, out requisition);
			return requisition;
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_do_set_related_action(IntPtr raw, IntPtr action);

		[Obsolete]
		public void DoSetRelatedAction(Gtk.Action action) {
			gtk_activatable_do_set_related_action(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_sync_action_properties(IntPtr raw, IntPtr action);

		[Obsolete]
		public void SyncActionProperties(Gtk.Action action) {
			gtk_activatable_sync_action_properties(Handle, action == null ? IntPtr.Zero : action.Handle);
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_activatable_get_related_action(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_related_action(IntPtr raw, IntPtr action);

		[Obsolete]
		[GLib.Property ("related-action")]
		public Gtk.Action RelatedAction {
			get  {
				IntPtr raw_ret = gtk_activatable_get_related_action(Handle);
				Gtk.Action ret = GLib.Object.GetObject(raw_ret) as Gtk.Action;
				return ret;
			}
			set  {
				gtk_activatable_set_related_action(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_activatable_get_use_action_appearance(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_activatable_set_use_action_appearance(IntPtr raw, bool use_appearance);

		[Obsolete]
		[GLib.Property ("use-action-appearance")]
		public bool UseActionAppearance {
			get  {
				bool raw_ret = gtk_activatable_get_use_action_appearance(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_activatable_set_use_action_appearance(Handle, value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_actionable_get_action_name(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_action_name(IntPtr raw, IntPtr action_name);

		public string ActionName { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_actionable_get_action_target_value(IntPtr raw);

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_action_target_value(IntPtr raw, IntPtr target_value);

		public GLib.Variant ActionTargetValue { 
			get {
				IntPtr raw_ret = gtk_actionable_get_action_target_value(Handle);
				GLib.Variant ret = new GLib.Variant(raw_ret);
				return ret;
			}
			set {
				gtk_actionable_set_action_target_value(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("libgtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_actionable_set_detailed_action_name(IntPtr raw, IntPtr detailed_action_name);

		public string DetailedActionName { 
			set {
				IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
				gtk_actionable_set_detailed_action_name(Handle, native_value);
				GLib.Marshaller.Free (native_value);
			}
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
