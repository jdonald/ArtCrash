/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class Device : Interface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public Device(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.Device_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(Device obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Device() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_Device(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Device() : this(LeapPINVOKE.new_Device(), true) {
  }

  public float DistanceToBoundary(Vector position) {
    float ret = LeapPINVOKE.Device_DistanceToBoundary(swigCPtr, Vector.getCPtr(position));
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(Device arg0) {
    bool ret = LeapPINVOKE.Device_Equals(swigCPtr, Device.getCPtr(arg0));
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = LeapPINVOKE.Device_ToString(swigCPtr);
    return ret;
  }

  public float HorizontalViewAngle {
    get {
      float ret = LeapPINVOKE.Device_HorizontalViewAngle_get(swigCPtr);
      return ret;
    } 
  }

  public float VerticalViewAngle {
    get {
      float ret = LeapPINVOKE.Device_VerticalViewAngle_get(swigCPtr);
      return ret;
    } 
  }

  public float Range {
    get {
      float ret = LeapPINVOKE.Device_Range_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsValid {
    get {
      bool ret = LeapPINVOKE.Device_IsValid_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmbedded {
    get {
      bool ret = LeapPINVOKE.Device_IsEmbedded_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsStreaming {
    get {
      bool ret = LeapPINVOKE.Device_IsStreaming_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsFlipped {
    get {
      bool ret = LeapPINVOKE.Device_IsFlipped_get(swigCPtr);
      return ret;
    } 
  }

  public Device.DeviceType Type {
    get {
      Device.DeviceType ret = (Device.DeviceType)LeapPINVOKE.Device_Type_get(swigCPtr);
      return ret;
    } 
  }

  public static Device Invalid {
    get {
      Device ret = new Device(LeapPINVOKE.Device_Invalid_get(), false);
      return ret;
    } 
  }

  public enum DeviceType {
    TYPE_PERIPHERAL = 1,
    TYPE_LAPTOP,
    TYPE_KEYBOARD
  }

}

}