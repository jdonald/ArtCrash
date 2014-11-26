/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class Config : Interface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public Config(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.Config_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(Config obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Config() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_Config(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Config() : this(LeapPINVOKE.new_Config(), true) {
  }

  public Config.ValueType Type(string key) {
    Config.ValueType ret = (Config.ValueType)LeapPINVOKE.Config_Type(swigCPtr, key);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetBool(string key) {
    bool ret = LeapPINVOKE.Config_GetBool(swigCPtr, key);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetBool(string key, bool value) {
    bool ret = LeapPINVOKE.Config_SetBool(swigCPtr, key, value);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetInt32(string key) {
    int ret = LeapPINVOKE.Config_GetInt32(swigCPtr, key);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetInt32(string key, int value) {
    bool ret = LeapPINVOKE.Config_SetInt32(swigCPtr, key, value);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float GetFloat(string key) {
    float ret = LeapPINVOKE.Config_GetFloat(swigCPtr, key);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetFloat(string key, float value) {
    bool ret = LeapPINVOKE.Config_SetFloat(swigCPtr, key, value);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string GetString(string key) {
    string ret = LeapPINVOKE.Config_GetString(swigCPtr, key);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetString(string key, string value) {
    bool ret = LeapPINVOKE.Config_SetString(swigCPtr, key, value);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Save() {
    bool ret = LeapPINVOKE.Config_Save(swigCPtr);
    return ret;
  }

  public enum ValueType {
    TYPE_UNKNOWN = 0,
    TYPE_BOOLEAN = 1,
    TYPE_INT32 = 2,
    TYPE_FLOAT = 6,
    TYPE_STRING = 8,
    TYPEUNKNOWN = TYPE_UNKNOWN,
    TYPEBOOLEAN = TYPE_BOOLEAN,
    TYPEINT32 = TYPE_INT32,
    TYPEFLOAT = TYPE_FLOAT,
    TYPESTRING = TYPE_STRING
  }

}

}