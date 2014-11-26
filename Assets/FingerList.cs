/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class FingerList : Interface, System.Collections.Generic.IEnumerable<Finger> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public FingerList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.FingerList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(FingerList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FingerList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_FingerList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  private class FingerListEnumerator : System.Collections.Generic.IEnumerator<Finger> {
    private FingerList _list;
    private int _index;
    public FingerListEnumerator(FingerList list) {
      _list = list;
      _index = -1;
    }
    public void Reset() {
      _index = -1;
    }
    public Finger Current {
      get {
        return _list._operator_get(_index);
      }
    }
    object System.Collections.IEnumerator.Current {
      get {
        return this.Current;
      }
    }
    public bool MoveNext() {
      _index++;
      return (_index < _list.Count);
    }
    public void Dispose() {
      //No cleanup needed
    }
  }
  System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
    return this.GetEnumerator();
  }
  public System.Collections.Generic.IEnumerator<Finger> GetEnumerator() {
    return new FingerListEnumerator(this);
  }
  public Finger this[int index] {
    get { return _operator_get(index); }
  }

  public FingerList() : this(LeapPINVOKE.new_FingerList(), true) {
  }

  private Finger _operator_get(int index) {
    Finger ret = new Finger(LeapPINVOKE.FingerList__operator_get(swigCPtr, index), true);
    return ret;
  }

  public FingerList Append(FingerList other) {
    FingerList ret = new FingerList(LeapPINVOKE.FingerList_Append(swigCPtr, FingerList.getCPtr(other)), false);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FingerList Extended() {
    FingerList ret = new FingerList(LeapPINVOKE.FingerList_Extended(swigCPtr), true);
    return ret;
  }

  public FingerList FingerType(Finger.FingerType type) {
    FingerList ret = new FingerList(LeapPINVOKE.FingerList_FingerType(swigCPtr, (int)type), true);
    return ret;
  }

  public int Count {
    get {
      int ret = LeapPINVOKE.FingerList_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmpty {
    get {
      bool ret = LeapPINVOKE.FingerList_IsEmpty_get(swigCPtr);
      return ret;
    } 
  }

  public Finger Leftmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.FingerList_Leftmost_get(swigCPtr);
      Finger ret = (cPtr == global::System.IntPtr.Zero) ? null : new Finger(cPtr, true);
      return ret;
    } 
  }

  public Finger Rightmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.FingerList_Rightmost_get(swigCPtr);
      Finger ret = (cPtr == global::System.IntPtr.Zero) ? null : new Finger(cPtr, true);
      return ret;
    } 
  }

  public Finger Frontmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.FingerList_Frontmost_get(swigCPtr);
      Finger ret = (cPtr == global::System.IntPtr.Zero) ? null : new Finger(cPtr, true);
      return ret;
    } 
  }

}

}