/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class Arm : Interface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public Arm(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.Arm_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(Arm obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Arm() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_Arm(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Arm() : this(LeapPINVOKE.new_Arm(), true) {
  }

  public bool Equals(Arm arg0) {
    bool ret = LeapPINVOKE.Arm_Equals(swigCPtr, Arm.getCPtr(arg0));
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = LeapPINVOKE.Arm_ToString(swigCPtr);
    return ret;
  }

  public float Width {
    get {
      float ret = LeapPINVOKE.Arm_Width_get(swigCPtr);
      return ret;
    } 
  }

  public Vector Center {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Arm_Center_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, true);
      return ret;
    } 
  }

  public Vector Direction {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Arm_Direction_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, true);
      return ret;
    } 
  }

  public Matrix Basis {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Arm_Basis_get(swigCPtr);
      Matrix ret = (cPtr == global::System.IntPtr.Zero) ? null : new Matrix(cPtr, true);
      return ret;
    } 
  }

  public Vector ElbowPosition {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Arm_ElbowPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, true);
      return ret;
    } 
  }

  public Vector WristPosition {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Arm_WristPosition_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, true);
      return ret;
    } 
  }

  public bool IsValid {
    get {
      bool ret = LeapPINVOKE.Arm_IsValid_get(swigCPtr);
      return ret;
    } 
  }

  public static Arm Invalid {
    get {
      Arm ret = new Arm(LeapPINVOKE.Arm_Invalid_get(), false);
      return ret;
    } 
  }

}

}
