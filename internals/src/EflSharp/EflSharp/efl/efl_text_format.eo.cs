#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

/// <summary>The look and layout of the text
/// The text format can affect the geometry of the text object, as well as how characters are presented.</summary>
[Efl.ITextFormatConcrete.NativeMethods]
public interface ITextFormat : 
    Efl.Eo.IWrapper, IDisposable
{
    /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
/// <returns>Ellipsis value</returns>
double GetEllipsis();
    /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
/// <param name="value">Ellipsis value</param>
void SetEllipsis(double value);
    /// <summary>Wrap mode for use in the text</summary>
/// <returns>Wrap mode</returns>
Efl.TextFormatWrap GetWrap();
    /// <summary>Wrap mode for use in the text</summary>
/// <param name="wrap">Wrap mode</param>
void SetWrap(Efl.TextFormatWrap wrap);
    /// <summary>Multiline is enabled or not</summary>
/// <returns><c>true</c> if multiline is enabled, <c>false</c> otherwise</returns>
bool GetMultiline();
    /// <summary>Multiline is enabled or not</summary>
/// <param name="enabled"><c>true</c> if multiline is enabled, <c>false</c> otherwise</param>
void SetMultiline(bool enabled);
    /// <summary>Horizontal alignment of text</summary>
/// <returns>Alignment type</returns>
Efl.TextFormatHorizontalAlignmentAutoType GetHalignAutoType();
    /// <summary>Horizontal alignment of text</summary>
/// <param name="value">Alignment type</param>
void SetHalignAutoType(Efl.TextFormatHorizontalAlignmentAutoType value);
    /// <summary>Horizontal alignment of text</summary>
/// <returns>Horizontal alignment value</returns>
double GetHalign();
    /// <summary>Horizontal alignment of text</summary>
/// <param name="value">Horizontal alignment value</param>
void SetHalign(double value);
    /// <summary>Vertical alignment of text</summary>
/// <returns>Vertical alignment value</returns>
double GetValign();
    /// <summary>Vertical alignment of text</summary>
/// <param name="value">Vertical alignment value</param>
void SetValign(double value);
    /// <summary>Minimal line gap (top and bottom) for each line in the text
/// <c>value</c> is absolute size.</summary>
/// <returns>Line gap value</returns>
double GetLinegap();
    /// <summary>Minimal line gap (top and bottom) for each line in the text
/// <c>value</c> is absolute size.</summary>
/// <param name="value">Line gap value</param>
void SetLinegap(double value);
    /// <summary>Relative line gap (top and bottom) for each line in the text
/// The original line gap value is multiplied by <c>value</c>.</summary>
/// <returns>Relative line gap value</returns>
double GetLinerelgap();
    /// <summary>Relative line gap (top and bottom) for each line in the text
/// The original line gap value is multiplied by <c>value</c>.</summary>
/// <param name="value">Relative line gap value</param>
void SetLinerelgap(double value);
    /// <summary>Tabstops value</summary>
/// <returns>Tapstops value</returns>
int GetTabstops();
    /// <summary>Tabstops value</summary>
/// <param name="value">Tapstops value</param>
void SetTabstops(int value);
    /// <summary>Whether text is a password</summary>
/// <returns><c>true</c> if the text is a password, <c>false</c> otherwise</returns>
bool GetPassword();
    /// <summary>Whether text is a password</summary>
/// <param name="enabled"><c>true</c> if the text is a password, <c>false</c> otherwise</param>
void SetPassword(bool enabled);
    /// <summary>The character used to replace characters that can&apos;t be displayed
/// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
/// <returns>Replacement character</returns>
System.String GetReplacementChar();
    /// <summary>The character used to replace characters that can&apos;t be displayed
/// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
/// <param name="repch">Replacement character</param>
void SetReplacementChar(System.String repch);
                                                                                            /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
/// <value>Ellipsis value</value>
    double Ellipsis {
        get ;
        set ;
    }
    /// <summary>Wrap mode for use in the text</summary>
/// <value>Wrap mode</value>
    Efl.TextFormatWrap Wrap {
        get ;
        set ;
    }
    /// <summary>Multiline is enabled or not</summary>
/// <value><c>true</c> if multiline is enabled, <c>false</c> otherwise</value>
    bool Multiline {
        get ;
        set ;
    }
    /// <summary>Horizontal alignment of text</summary>
/// <value>Alignment type</value>
    Efl.TextFormatHorizontalAlignmentAutoType HalignAutoType {
        get ;
        set ;
    }
    /// <summary>Horizontal alignment of text</summary>
/// <value>Horizontal alignment value</value>
    double Halign {
        get ;
        set ;
    }
    /// <summary>Vertical alignment of text</summary>
/// <value>Vertical alignment value</value>
    double Valign {
        get ;
        set ;
    }
    /// <summary>Minimal line gap (top and bottom) for each line in the text
/// <c>value</c> is absolute size.</summary>
/// <value>Line gap value</value>
    double Linegap {
        get ;
        set ;
    }
    /// <summary>Relative line gap (top and bottom) for each line in the text
/// The original line gap value is multiplied by <c>value</c>.</summary>
/// <value>Relative line gap value</value>
    double Linerelgap {
        get ;
        set ;
    }
    /// <summary>Tabstops value</summary>
/// <value>Tapstops value</value>
    int Tabstops {
        get ;
        set ;
    }
    /// <summary>Whether text is a password</summary>
/// <value><c>true</c> if the text is a password, <c>false</c> otherwise</value>
    bool Password {
        get ;
        set ;
    }
    /// <summary>The character used to replace characters that can&apos;t be displayed
/// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
/// <value>Replacement character</value>
    System.String ReplacementChar {
        get ;
        set ;
    }
}
/// <summary>The look and layout of the text
/// The text format can affect the geometry of the text object, as well as how characters are presented.</summary>
sealed public class ITextFormatConcrete : 

ITextFormat
    
{
    ///<summary>Pointer to the native class description.</summary>
    public System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(ITextFormatConcrete))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    private  System.IntPtr handle;
    ///<summary>Pointer to the native instance.</summary>
    public System.IntPtr NativeHandle
    {
        get { return handle; }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
        efl_text_format_interface_get();
    /// <summary>Initializes a new instance of the <see cref="ITextFormat"/> class.
    /// Internal usage: This is used when interacting with C code and should not be used directly.</summary>
    private ITextFormatConcrete(System.IntPtr raw)
    {
        handle = raw;
    }
    ///<summary>Destructor.</summary>
    ~ITextFormatConcrete()
    {
        Dispose(false);
    }

    ///<summary>Releases the underlying native instance.</summary>
    private void Dispose(bool disposing)
    {
        if (handle != System.IntPtr.Zero)
        {
            IntPtr h = handle;
            handle = IntPtr.Zero;

            IntPtr gcHandlePtr = IntPtr.Zero;
            if (disposing)
            {
                Efl.Eo.Globals.efl_mono_native_dispose(h, gcHandlePtr);
            }
            else
            {
                Monitor.Enter(Efl.All.InitLock);
                if (Efl.All.MainLoopInitialized)
                {
                    Efl.Eo.Globals.efl_mono_thread_safe_native_dispose(h, gcHandlePtr);
                }

                Monitor.Exit(Efl.All.InitLock);
            }
        }

    }

    ///<summary>Releases the underlying native instance.</summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>Verifies if the given object is equal to this one.</summary>
    /// <param name="instance">The object to compare to.</param>
    /// <returns>True if both objects point to the same native object.</returns>
    public override bool Equals(object instance)
    {
        var other = instance as Efl.Object;
        if (other == null)
        {
            return false;
        }
        return this.NativeHandle == other.NativeHandle;
    }

    /// <summary>Gets the hash code for this object based on the native pointer it points to.</summary>
    /// <returns>The value of the pointer, to be used as the hash code of this object.</returns>
    public override int GetHashCode()
    {
        return this.NativeHandle.ToInt32();
    }

    /// <summary>Turns the native pointer into a string representation.</summary>
    /// <returns>A string with the type and the native pointer for this object.</returns>
    public override String ToString()
    {
        return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
    }

    /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
    /// <returns>Ellipsis value</returns>
    public double GetEllipsis() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_ellipsis_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
    /// <param name="value">Ellipsis value</param>
    public void SetEllipsis(double value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_ellipsis_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Wrap mode for use in the text</summary>
    /// <returns>Wrap mode</returns>
    public Efl.TextFormatWrap GetWrap() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_wrap_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Wrap mode for use in the text</summary>
    /// <param name="wrap">Wrap mode</param>
    public void SetWrap(Efl.TextFormatWrap wrap) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_wrap_set_ptr.Value.Delegate(this.NativeHandle,wrap);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Multiline is enabled or not</summary>
    /// <returns><c>true</c> if multiline is enabled, <c>false</c> otherwise</returns>
    public bool GetMultiline() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_multiline_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Multiline is enabled or not</summary>
    /// <param name="enabled"><c>true</c> if multiline is enabled, <c>false</c> otherwise</param>
    public void SetMultiline(bool enabled) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_multiline_set_ptr.Value.Delegate(this.NativeHandle,enabled);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Horizontal alignment of text</summary>
    /// <returns>Alignment type</returns>
    public Efl.TextFormatHorizontalAlignmentAutoType GetHalignAutoType() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_halign_auto_type_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Horizontal alignment of text</summary>
    /// <param name="value">Alignment type</param>
    public void SetHalignAutoType(Efl.TextFormatHorizontalAlignmentAutoType value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_halign_auto_type_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Horizontal alignment of text</summary>
    /// <returns>Horizontal alignment value</returns>
    public double GetHalign() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_halign_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Horizontal alignment of text</summary>
    /// <param name="value">Horizontal alignment value</param>
    public void SetHalign(double value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_halign_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Vertical alignment of text</summary>
    /// <returns>Vertical alignment value</returns>
    public double GetValign() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_valign_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Vertical alignment of text</summary>
    /// <param name="value">Vertical alignment value</param>
    public void SetValign(double value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_valign_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Minimal line gap (top and bottom) for each line in the text
    /// <c>value</c> is absolute size.</summary>
    /// <returns>Line gap value</returns>
    public double GetLinegap() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_linegap_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Minimal line gap (top and bottom) for each line in the text
    /// <c>value</c> is absolute size.</summary>
    /// <param name="value">Line gap value</param>
    public void SetLinegap(double value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_linegap_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Relative line gap (top and bottom) for each line in the text
    /// The original line gap value is multiplied by <c>value</c>.</summary>
    /// <returns>Relative line gap value</returns>
    public double GetLinerelgap() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_linerelgap_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Relative line gap (top and bottom) for each line in the text
    /// The original line gap value is multiplied by <c>value</c>.</summary>
    /// <param name="value">Relative line gap value</param>
    public void SetLinerelgap(double value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_linerelgap_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Tabstops value</summary>
    /// <returns>Tapstops value</returns>
    public int GetTabstops() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_tabstops_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Tabstops value</summary>
    /// <param name="value">Tapstops value</param>
    public void SetTabstops(int value) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_tabstops_set_ptr.Value.Delegate(this.NativeHandle,value);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Whether text is a password</summary>
    /// <returns><c>true</c> if the text is a password, <c>false</c> otherwise</returns>
    public bool GetPassword() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_password_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>Whether text is a password</summary>
    /// <param name="enabled"><c>true</c> if the text is a password, <c>false</c> otherwise</param>
    public void SetPassword(bool enabled) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_password_set_ptr.Value.Delegate(this.NativeHandle,enabled);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>The character used to replace characters that can&apos;t be displayed
    /// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
    /// <returns>Replacement character</returns>
    public System.String GetReplacementChar() {
         var _ret_var = Efl.ITextFormatConcrete.NativeMethods.efl_text_replacement_char_get_ptr.Value.Delegate(this.NativeHandle);
        Eina.Error.RaiseIfUnhandledException();
        return _ret_var;
 }
    /// <summary>The character used to replace characters that can&apos;t be displayed
    /// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
    /// <param name="repch">Replacement character</param>
    public void SetReplacementChar(System.String repch) {
                                 Efl.ITextFormatConcrete.NativeMethods.efl_text_replacement_char_set_ptr.Value.Delegate(this.NativeHandle,repch);
        Eina.Error.RaiseIfUnhandledException();
                         }
    /// <summary>Ellipsis value (number from -1.0 to 1.0)</summary>
/// <value>Ellipsis value</value>
    public double Ellipsis {
        get { return GetEllipsis(); }
        set { SetEllipsis(value); }
    }
    /// <summary>Wrap mode for use in the text</summary>
/// <value>Wrap mode</value>
    public Efl.TextFormatWrap Wrap {
        get { return GetWrap(); }
        set { SetWrap(value); }
    }
    /// <summary>Multiline is enabled or not</summary>
/// <value><c>true</c> if multiline is enabled, <c>false</c> otherwise</value>
    public bool Multiline {
        get { return GetMultiline(); }
        set { SetMultiline(value); }
    }
    /// <summary>Horizontal alignment of text</summary>
/// <value>Alignment type</value>
    public Efl.TextFormatHorizontalAlignmentAutoType HalignAutoType {
        get { return GetHalignAutoType(); }
        set { SetHalignAutoType(value); }
    }
    /// <summary>Horizontal alignment of text</summary>
/// <value>Horizontal alignment value</value>
    public double Halign {
        get { return GetHalign(); }
        set { SetHalign(value); }
    }
    /// <summary>Vertical alignment of text</summary>
/// <value>Vertical alignment value</value>
    public double Valign {
        get { return GetValign(); }
        set { SetValign(value); }
    }
    /// <summary>Minimal line gap (top and bottom) for each line in the text
/// <c>value</c> is absolute size.</summary>
/// <value>Line gap value</value>
    public double Linegap {
        get { return GetLinegap(); }
        set { SetLinegap(value); }
    }
    /// <summary>Relative line gap (top and bottom) for each line in the text
/// The original line gap value is multiplied by <c>value</c>.</summary>
/// <value>Relative line gap value</value>
    public double Linerelgap {
        get { return GetLinerelgap(); }
        set { SetLinerelgap(value); }
    }
    /// <summary>Tabstops value</summary>
/// <value>Tapstops value</value>
    public int Tabstops {
        get { return GetTabstops(); }
        set { SetTabstops(value); }
    }
    /// <summary>Whether text is a password</summary>
/// <value><c>true</c> if the text is a password, <c>false</c> otherwise</value>
    public bool Password {
        get { return GetPassword(); }
        set { SetPassword(value); }
    }
    /// <summary>The character used to replace characters that can&apos;t be displayed
/// Currently only used to replace characters if <see cref="Efl.ITextFormat.Password"/> is enabled.</summary>
/// <value>Replacement character</value>
    public System.String ReplacementChar {
        get { return GetReplacementChar(); }
        set { SetReplacementChar(value); }
    }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.ITextFormatConcrete.efl_text_format_interface_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public class NativeMethods  : Efl.Eo.NativeClass
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Efl);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_text_ellipsis_get_static_delegate == null)
            {
                efl_text_ellipsis_get_static_delegate = new efl_text_ellipsis_get_delegate(ellipsis_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetEllipsis") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_ellipsis_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_ellipsis_get_static_delegate) });
            }

            if (efl_text_ellipsis_set_static_delegate == null)
            {
                efl_text_ellipsis_set_static_delegate = new efl_text_ellipsis_set_delegate(ellipsis_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetEllipsis") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_ellipsis_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_ellipsis_set_static_delegate) });
            }

            if (efl_text_wrap_get_static_delegate == null)
            {
                efl_text_wrap_get_static_delegate = new efl_text_wrap_get_delegate(wrap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetWrap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_wrap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_wrap_get_static_delegate) });
            }

            if (efl_text_wrap_set_static_delegate == null)
            {
                efl_text_wrap_set_static_delegate = new efl_text_wrap_set_delegate(wrap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetWrap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_wrap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_wrap_set_static_delegate) });
            }

            if (efl_text_multiline_get_static_delegate == null)
            {
                efl_text_multiline_get_static_delegate = new efl_text_multiline_get_delegate(multiline_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetMultiline") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_multiline_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_multiline_get_static_delegate) });
            }

            if (efl_text_multiline_set_static_delegate == null)
            {
                efl_text_multiline_set_static_delegate = new efl_text_multiline_set_delegate(multiline_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetMultiline") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_multiline_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_multiline_set_static_delegate) });
            }

            if (efl_text_halign_auto_type_get_static_delegate == null)
            {
                efl_text_halign_auto_type_get_static_delegate = new efl_text_halign_auto_type_get_delegate(halign_auto_type_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHalignAutoType") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_halign_auto_type_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_halign_auto_type_get_static_delegate) });
            }

            if (efl_text_halign_auto_type_set_static_delegate == null)
            {
                efl_text_halign_auto_type_set_static_delegate = new efl_text_halign_auto_type_set_delegate(halign_auto_type_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHalignAutoType") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_halign_auto_type_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_halign_auto_type_set_static_delegate) });
            }

            if (efl_text_halign_get_static_delegate == null)
            {
                efl_text_halign_get_static_delegate = new efl_text_halign_get_delegate(halign_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetHalign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_halign_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_halign_get_static_delegate) });
            }

            if (efl_text_halign_set_static_delegate == null)
            {
                efl_text_halign_set_static_delegate = new efl_text_halign_set_delegate(halign_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetHalign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_halign_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_halign_set_static_delegate) });
            }

            if (efl_text_valign_get_static_delegate == null)
            {
                efl_text_valign_get_static_delegate = new efl_text_valign_get_delegate(valign_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetValign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_valign_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_valign_get_static_delegate) });
            }

            if (efl_text_valign_set_static_delegate == null)
            {
                efl_text_valign_set_static_delegate = new efl_text_valign_set_delegate(valign_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetValign") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_valign_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_valign_set_static_delegate) });
            }

            if (efl_text_linegap_get_static_delegate == null)
            {
                efl_text_linegap_get_static_delegate = new efl_text_linegap_get_delegate(linegap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLinegap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_linegap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_linegap_get_static_delegate) });
            }

            if (efl_text_linegap_set_static_delegate == null)
            {
                efl_text_linegap_set_static_delegate = new efl_text_linegap_set_delegate(linegap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetLinegap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_linegap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_linegap_set_static_delegate) });
            }

            if (efl_text_linerelgap_get_static_delegate == null)
            {
                efl_text_linerelgap_get_static_delegate = new efl_text_linerelgap_get_delegate(linerelgap_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetLinerelgap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_linerelgap_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_linerelgap_get_static_delegate) });
            }

            if (efl_text_linerelgap_set_static_delegate == null)
            {
                efl_text_linerelgap_set_static_delegate = new efl_text_linerelgap_set_delegate(linerelgap_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetLinerelgap") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_linerelgap_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_linerelgap_set_static_delegate) });
            }

            if (efl_text_tabstops_get_static_delegate == null)
            {
                efl_text_tabstops_get_static_delegate = new efl_text_tabstops_get_delegate(tabstops_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetTabstops") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_tabstops_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_tabstops_get_static_delegate) });
            }

            if (efl_text_tabstops_set_static_delegate == null)
            {
                efl_text_tabstops_set_static_delegate = new efl_text_tabstops_set_delegate(tabstops_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetTabstops") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_tabstops_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_tabstops_set_static_delegate) });
            }

            if (efl_text_password_get_static_delegate == null)
            {
                efl_text_password_get_static_delegate = new efl_text_password_get_delegate(password_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetPassword") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_password_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_password_get_static_delegate) });
            }

            if (efl_text_password_set_static_delegate == null)
            {
                efl_text_password_set_static_delegate = new efl_text_password_set_delegate(password_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetPassword") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_password_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_password_set_static_delegate) });
            }

            if (efl_text_replacement_char_get_static_delegate == null)
            {
                efl_text_replacement_char_get_static_delegate = new efl_text_replacement_char_get_delegate(replacement_char_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetReplacementChar") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_replacement_char_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_replacement_char_get_static_delegate) });
            }

            if (efl_text_replacement_char_set_static_delegate == null)
            {
                efl_text_replacement_char_set_static_delegate = new efl_text_replacement_char_set_delegate(replacement_char_set);
            }

            if (methods.FirstOrDefault(m => m.Name == "SetReplacementChar") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_text_replacement_char_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_replacement_char_set_static_delegate) });
            }

            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.ITextFormatConcrete.efl_text_format_interface_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        
        private delegate double efl_text_ellipsis_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_text_ellipsis_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_ellipsis_get_api_delegate> efl_text_ellipsis_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_ellipsis_get_api_delegate>(Module, "efl_text_ellipsis_get");

        private static double ellipsis_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_ellipsis_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetEllipsis();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_ellipsis_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_ellipsis_get_delegate efl_text_ellipsis_get_static_delegate;

        
        private delegate void efl_text_ellipsis_set_delegate(System.IntPtr obj, System.IntPtr pd,  double value);

        
        public delegate void efl_text_ellipsis_set_api_delegate(System.IntPtr obj,  double value);

        public static Efl.Eo.FunctionWrapper<efl_text_ellipsis_set_api_delegate> efl_text_ellipsis_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_ellipsis_set_api_delegate>(Module, "efl_text_ellipsis_set");

        private static void ellipsis_set(System.IntPtr obj, System.IntPtr pd, double value)
        {
            Eina.Log.Debug("function efl_text_ellipsis_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetEllipsis(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_ellipsis_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_ellipsis_set_delegate efl_text_ellipsis_set_static_delegate;

        
        private delegate Efl.TextFormatWrap efl_text_wrap_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.TextFormatWrap efl_text_wrap_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_wrap_get_api_delegate> efl_text_wrap_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_wrap_get_api_delegate>(Module, "efl_text_wrap_get");

        private static Efl.TextFormatWrap wrap_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_wrap_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.TextFormatWrap _ret_var = default(Efl.TextFormatWrap);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetWrap();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_wrap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_wrap_get_delegate efl_text_wrap_get_static_delegate;

        
        private delegate void efl_text_wrap_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.TextFormatWrap wrap);

        
        public delegate void efl_text_wrap_set_api_delegate(System.IntPtr obj,  Efl.TextFormatWrap wrap);

        public static Efl.Eo.FunctionWrapper<efl_text_wrap_set_api_delegate> efl_text_wrap_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_wrap_set_api_delegate>(Module, "efl_text_wrap_set");

        private static void wrap_set(System.IntPtr obj, System.IntPtr pd, Efl.TextFormatWrap wrap)
        {
            Eina.Log.Debug("function efl_text_wrap_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetWrap(wrap);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_wrap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), wrap);
            }
        }

        private static efl_text_wrap_set_delegate efl_text_wrap_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_text_multiline_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_text_multiline_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_multiline_get_api_delegate> efl_text_multiline_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_multiline_get_api_delegate>(Module, "efl_text_multiline_get");

        private static bool multiline_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_multiline_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetMultiline();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_multiline_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_multiline_get_delegate efl_text_multiline_get_static_delegate;

        
        private delegate void efl_text_multiline_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool enabled);

        
        public delegate void efl_text_multiline_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool enabled);

        public static Efl.Eo.FunctionWrapper<efl_text_multiline_set_api_delegate> efl_text_multiline_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_multiline_set_api_delegate>(Module, "efl_text_multiline_set");

        private static void multiline_set(System.IntPtr obj, System.IntPtr pd, bool enabled)
        {
            Eina.Log.Debug("function efl_text_multiline_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetMultiline(enabled);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_multiline_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), enabled);
            }
        }

        private static efl_text_multiline_set_delegate efl_text_multiline_set_static_delegate;

        
        private delegate Efl.TextFormatHorizontalAlignmentAutoType efl_text_halign_auto_type_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate Efl.TextFormatHorizontalAlignmentAutoType efl_text_halign_auto_type_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_halign_auto_type_get_api_delegate> efl_text_halign_auto_type_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_halign_auto_type_get_api_delegate>(Module, "efl_text_halign_auto_type_get");

        private static Efl.TextFormatHorizontalAlignmentAutoType halign_auto_type_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_halign_auto_type_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Efl.TextFormatHorizontalAlignmentAutoType _ret_var = default(Efl.TextFormatHorizontalAlignmentAutoType);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetHalignAutoType();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_halign_auto_type_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_halign_auto_type_get_delegate efl_text_halign_auto_type_get_static_delegate;

        
        private delegate void efl_text_halign_auto_type_set_delegate(System.IntPtr obj, System.IntPtr pd,  Efl.TextFormatHorizontalAlignmentAutoType value);

        
        public delegate void efl_text_halign_auto_type_set_api_delegate(System.IntPtr obj,  Efl.TextFormatHorizontalAlignmentAutoType value);

        public static Efl.Eo.FunctionWrapper<efl_text_halign_auto_type_set_api_delegate> efl_text_halign_auto_type_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_halign_auto_type_set_api_delegate>(Module, "efl_text_halign_auto_type_set");

        private static void halign_auto_type_set(System.IntPtr obj, System.IntPtr pd, Efl.TextFormatHorizontalAlignmentAutoType value)
        {
            Eina.Log.Debug("function efl_text_halign_auto_type_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetHalignAutoType(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_halign_auto_type_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_halign_auto_type_set_delegate efl_text_halign_auto_type_set_static_delegate;

        
        private delegate double efl_text_halign_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_text_halign_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_halign_get_api_delegate> efl_text_halign_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_halign_get_api_delegate>(Module, "efl_text_halign_get");

        private static double halign_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_halign_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetHalign();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_halign_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_halign_get_delegate efl_text_halign_get_static_delegate;

        
        private delegate void efl_text_halign_set_delegate(System.IntPtr obj, System.IntPtr pd,  double value);

        
        public delegate void efl_text_halign_set_api_delegate(System.IntPtr obj,  double value);

        public static Efl.Eo.FunctionWrapper<efl_text_halign_set_api_delegate> efl_text_halign_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_halign_set_api_delegate>(Module, "efl_text_halign_set");

        private static void halign_set(System.IntPtr obj, System.IntPtr pd, double value)
        {
            Eina.Log.Debug("function efl_text_halign_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetHalign(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_halign_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_halign_set_delegate efl_text_halign_set_static_delegate;

        
        private delegate double efl_text_valign_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_text_valign_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_valign_get_api_delegate> efl_text_valign_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_valign_get_api_delegate>(Module, "efl_text_valign_get");

        private static double valign_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_valign_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetValign();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_valign_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_valign_get_delegate efl_text_valign_get_static_delegate;

        
        private delegate void efl_text_valign_set_delegate(System.IntPtr obj, System.IntPtr pd,  double value);

        
        public delegate void efl_text_valign_set_api_delegate(System.IntPtr obj,  double value);

        public static Efl.Eo.FunctionWrapper<efl_text_valign_set_api_delegate> efl_text_valign_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_valign_set_api_delegate>(Module, "efl_text_valign_set");

        private static void valign_set(System.IntPtr obj, System.IntPtr pd, double value)
        {
            Eina.Log.Debug("function efl_text_valign_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetValign(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_valign_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_valign_set_delegate efl_text_valign_set_static_delegate;

        
        private delegate double efl_text_linegap_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_text_linegap_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_linegap_get_api_delegate> efl_text_linegap_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_linegap_get_api_delegate>(Module, "efl_text_linegap_get");

        private static double linegap_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_linegap_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetLinegap();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_linegap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_linegap_get_delegate efl_text_linegap_get_static_delegate;

        
        private delegate void efl_text_linegap_set_delegate(System.IntPtr obj, System.IntPtr pd,  double value);

        
        public delegate void efl_text_linegap_set_api_delegate(System.IntPtr obj,  double value);

        public static Efl.Eo.FunctionWrapper<efl_text_linegap_set_api_delegate> efl_text_linegap_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_linegap_set_api_delegate>(Module, "efl_text_linegap_set");

        private static void linegap_set(System.IntPtr obj, System.IntPtr pd, double value)
        {
            Eina.Log.Debug("function efl_text_linegap_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetLinegap(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_linegap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_linegap_set_delegate efl_text_linegap_set_static_delegate;

        
        private delegate double efl_text_linerelgap_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate double efl_text_linerelgap_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_linerelgap_get_api_delegate> efl_text_linerelgap_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_linerelgap_get_api_delegate>(Module, "efl_text_linerelgap_get");

        private static double linerelgap_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_linerelgap_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            double _ret_var = default(double);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetLinerelgap();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_linerelgap_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_linerelgap_get_delegate efl_text_linerelgap_get_static_delegate;

        
        private delegate void efl_text_linerelgap_set_delegate(System.IntPtr obj, System.IntPtr pd,  double value);

        
        public delegate void efl_text_linerelgap_set_api_delegate(System.IntPtr obj,  double value);

        public static Efl.Eo.FunctionWrapper<efl_text_linerelgap_set_api_delegate> efl_text_linerelgap_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_linerelgap_set_api_delegate>(Module, "efl_text_linerelgap_set");

        private static void linerelgap_set(System.IntPtr obj, System.IntPtr pd, double value)
        {
            Eina.Log.Debug("function efl_text_linerelgap_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetLinerelgap(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_linerelgap_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_linerelgap_set_delegate efl_text_linerelgap_set_static_delegate;

        
        private delegate int efl_text_tabstops_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate int efl_text_tabstops_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_tabstops_get_api_delegate> efl_text_tabstops_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_tabstops_get_api_delegate>(Module, "efl_text_tabstops_get");

        private static int tabstops_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_tabstops_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            int _ret_var = default(int);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetTabstops();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_tabstops_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_tabstops_get_delegate efl_text_tabstops_get_static_delegate;

        
        private delegate void efl_text_tabstops_set_delegate(System.IntPtr obj, System.IntPtr pd,  int value);

        
        public delegate void efl_text_tabstops_set_api_delegate(System.IntPtr obj,  int value);

        public static Efl.Eo.FunctionWrapper<efl_text_tabstops_set_api_delegate> efl_text_tabstops_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_tabstops_set_api_delegate>(Module, "efl_text_tabstops_set");

        private static void tabstops_set(System.IntPtr obj, System.IntPtr pd, int value)
        {
            Eina.Log.Debug("function efl_text_tabstops_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetTabstops(value);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_tabstops_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), value);
            }
        }

        private static efl_text_tabstops_set_delegate efl_text_tabstops_set_static_delegate;

        [return: MarshalAs(UnmanagedType.U1)]
        private delegate bool efl_text_password_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.U1)]
        public delegate bool efl_text_password_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_password_get_api_delegate> efl_text_password_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_password_get_api_delegate>(Module, "efl_text_password_get");

        private static bool password_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_password_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            bool _ret_var = default(bool);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetPassword();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_password_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_password_get_delegate efl_text_password_get_static_delegate;

        
        private delegate void efl_text_password_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.U1)] bool enabled);

        
        public delegate void efl_text_password_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.U1)] bool enabled);

        public static Efl.Eo.FunctionWrapper<efl_text_password_set_api_delegate> efl_text_password_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_password_set_api_delegate>(Module, "efl_text_password_set");

        private static void password_set(System.IntPtr obj, System.IntPtr pd, bool enabled)
        {
            Eina.Log.Debug("function efl_text_password_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetPassword(enabled);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_password_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), enabled);
            }
        }

        private static efl_text_password_set_delegate efl_text_password_set_static_delegate;

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        private delegate System.String efl_text_replacement_char_get_delegate(System.IntPtr obj, System.IntPtr pd);

        [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]
        public delegate System.String efl_text_replacement_char_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_text_replacement_char_get_api_delegate> efl_text_replacement_char_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_replacement_char_get_api_delegate>(Module, "efl_text_replacement_char_get");

        private static System.String replacement_char_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_text_replacement_char_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            System.String _ret_var = default(System.String);
                try
                {
                    _ret_var = ((ITextFormat)wrapper).GetReplacementChar();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        return _ret_var;

            }
            else
            {
                return efl_text_replacement_char_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_text_replacement_char_get_delegate efl_text_replacement_char_get_static_delegate;

        
        private delegate void efl_text_replacement_char_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String repch);

        
        public delegate void efl_text_replacement_char_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String repch);

        public static Efl.Eo.FunctionWrapper<efl_text_replacement_char_set_api_delegate> efl_text_replacement_char_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_replacement_char_set_api_delegate>(Module, "efl_text_replacement_char_set");

        private static void replacement_char_set(System.IntPtr obj, System.IntPtr pd, System.String repch)
        {
            Eina.Log.Debug("function efl_text_replacement_char_set was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    
                try
                {
                    ((ITextFormat)wrapper).SetReplacementChar(repch);
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

                        
            }
            else
            {
                efl_text_replacement_char_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), repch);
            }
        }

        private static efl_text_replacement_char_set_delegate efl_text_replacement_char_set_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

namespace Efl {

/// <summary>Wrap mode of the text (not in effect if not multiline)</summary>
public enum TextFormatWrap
{
/// <summary>No wrapping</summary>
None = 0,
/// <summary>Wrap mode character</summary>
Char = 1,
/// <summary>Wrap mode word</summary>
Word = 2,
/// <summary>Wrap mode mixed</summary>
Mixed = 3,
/// <summary>Wrap mode hyphenation</summary>
Hyphenation = 4,
}

}

namespace Efl {

/// <summary>Auto-horizontal alignment of the text</summary>
public enum TextFormatHorizontalAlignmentAutoType
{
/// <summary>No auto-alignment rule</summary>
None = 0,
/// <summary>Respects LTR/RTL (bidirectional) settings</summary>
Normal = 1,
/// <summary>Respects locale&apos;s langauge settings</summary>
Locale = 2,
/// <summary>Text is places at opposite side of LTR/RTL (bidirectional) settings</summary>
End = 3,
}

}

