#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.ComponentModel;
namespace Efl {

namespace Canvas {

namespace Vg {

/// <summary>Efl vector graphics container class</summary>
[Efl.Canvas.Vg.Container.NativeMethods]
public class Container : Efl.Canvas.Vg.Node, Efl.Eo.IWrapper
{
    ///<summary>Pointer to the native class description.</summary>
    public override System.IntPtr NativeClass
    {
        get
        {
            if (((object)this).GetType() == typeof(Container))
            {
                return GetEflClassStatic();
            }
            else
            {
                return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
            }
        }
    }

    [System.Runtime.InteropServices.DllImport(efl.Libs.Evas)] internal static extern System.IntPtr
        efl_canvas_vg_container_class_get();
    /// <summary>Initializes a new instance of the <see cref="Container"/> class.</summary>
    /// <param name="parent">Parent instance.</param>
    public Container(Efl.Object parent= null
            ) : base(efl_canvas_vg_container_class_get(), typeof(Container), parent)
    {
        FinishInstantiation();
    }

    /// <summary>Initializes a new instance of the <see cref="Container"/> class.
    /// Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
    /// <param name="raw">The native pointer to be wrapped.</param>
    protected Container(System.IntPtr raw) : base(raw)
    {
            }

    /// <summary>Initializes a new instance of the <see cref="Container"/> class.
    /// Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
    /// <param name="baseKlass">The pointer to the base native Eo class.</param>
    /// <param name="managedType">The managed type of the public constructor that originated this call.</param>
    /// <param name="parent">The Efl.Object parent of this instance.</param>
    protected Container(IntPtr baseKlass, System.Type managedType, Efl.Object parent) : base(baseKlass, managedType, parent)
    {
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

    /// <summary>Get child of container</summary>
    /// <param name="name">Child node name</param>
    /// <returns>Child object</returns>
    virtual public Efl.Canvas.Vg.Node GetChild(System.String name) {
                                 var _ret_var = Efl.Canvas.Vg.Container.NativeMethods.efl_canvas_vg_container_child_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle),name);
        Eina.Error.RaiseIfUnhandledException();
                        return _ret_var;
 }
    /// <summary>Get all children of container</summary>
    /// <returns>Iterator to children</returns>
    virtual public Eina.Iterator<Efl.Canvas.Vg.Node> GetChildren() {
         var _ret_var = Efl.Canvas.Vg.Container.NativeMethods.efl_canvas_vg_container_children_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
        Eina.Error.RaiseIfUnhandledException();
        return new Eina.Iterator<Efl.Canvas.Vg.Node>(_ret_var, true, false);
 }
    private static IntPtr GetEflClassStatic()
    {
        return Efl.Canvas.Vg.Container.efl_canvas_vg_container_class_get();
    }
    /// <summary>Wrapper for native methods and virtual method delegates.
    /// For internal use by generated code only.</summary>
    public new class NativeMethods : Efl.Canvas.Vg.Node.NativeMethods
    {
        private static Efl.Eo.NativeModule Module = new Efl.Eo.NativeModule(    efl.Libs.Evas);
        /// <summary>Gets the list of Eo operations to override.</summary>
        /// <returns>The list of Eo operations to be overload.</returns>
        public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
        {
            var descs = new System.Collections.Generic.List<Efl_Op_Description>();
            var methods = Efl.Eo.Globals.GetUserMethods(type);

            if (efl_canvas_vg_container_child_get_static_delegate == null)
            {
                efl_canvas_vg_container_child_get_static_delegate = new efl_canvas_vg_container_child_get_delegate(child_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetChild") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_container_child_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_container_child_get_static_delegate) });
            }

            if (efl_canvas_vg_container_children_get_static_delegate == null)
            {
                efl_canvas_vg_container_children_get_static_delegate = new efl_canvas_vg_container_children_get_delegate(children_get);
            }

            if (methods.FirstOrDefault(m => m.Name == "GetChildren") != null)
            {
                descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(Module.Module, "efl_canvas_vg_container_children_get"), func = Marshal.GetFunctionPointerForDelegate(efl_canvas_vg_container_children_get_static_delegate) });
            }

            descs.AddRange(base.GetEoOps(type));
            return descs;
        }
        /// <summary>Returns the Eo class for the native methods of this class.</summary>
        /// <returns>The native class pointer.</returns>
        public override IntPtr GetEflClass()
        {
            return Efl.Canvas.Vg.Container.efl_canvas_vg_container_class_get();
        }

        #pragma warning disable CA1707, SA1300, SA1600

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        private delegate Efl.Canvas.Vg.Node efl_canvas_vg_container_child_get_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String name);

        [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalEo<Efl.Eo.NonOwnTag>))]
        public delegate Efl.Canvas.Vg.Node efl_canvas_vg_container_child_get_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] System.String name);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_container_child_get_api_delegate> efl_canvas_vg_container_child_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_container_child_get_api_delegate>(Module, "efl_canvas_vg_container_child_get");

        private static Efl.Canvas.Vg.Node child_get(System.IntPtr obj, System.IntPtr pd, System.String name)
        {
            Eina.Log.Debug("function efl_canvas_vg_container_child_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
                                    Efl.Canvas.Vg.Node _ret_var = default(Efl.Canvas.Vg.Node);
                try
                {
                    _ret_var = ((Container)wrapper).GetChild(name);
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
                return efl_canvas_vg_container_child_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)), name);
            }
        }

        private static efl_canvas_vg_container_child_get_delegate efl_canvas_vg_container_child_get_static_delegate;

        
        private delegate System.IntPtr efl_canvas_vg_container_children_get_delegate(System.IntPtr obj, System.IntPtr pd);

        
        public delegate System.IntPtr efl_canvas_vg_container_children_get_api_delegate(System.IntPtr obj);

        public static Efl.Eo.FunctionWrapper<efl_canvas_vg_container_children_get_api_delegate> efl_canvas_vg_container_children_get_ptr = new Efl.Eo.FunctionWrapper<efl_canvas_vg_container_children_get_api_delegate>(Module, "efl_canvas_vg_container_children_get");

        private static System.IntPtr children_get(System.IntPtr obj, System.IntPtr pd)
        {
            Eina.Log.Debug("function efl_canvas_vg_container_children_get was called");
            Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.PrivateDataGet(pd);
            if (wrapper != null)
            {
            Eina.Iterator<Efl.Canvas.Vg.Node> _ret_var = default(Eina.Iterator<Efl.Canvas.Vg.Node>);
                try
                {
                    _ret_var = ((Container)wrapper).GetChildren();
                }
                catch (Exception e)
                {
                    Eina.Log.Warning($"Callback error: {e.ToString()}");
                    Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
                }

        _ret_var.Own = false; return _ret_var.Handle;

            }
            else
            {
                return efl_canvas_vg_container_children_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
            }
        }

        private static efl_canvas_vg_container_children_get_delegate efl_canvas_vg_container_children_get_static_delegate;

        #pragma warning restore CA1707, SA1300, SA1600

}
}
}

}

}

