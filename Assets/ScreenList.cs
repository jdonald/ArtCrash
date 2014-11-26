/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class ScreenList : Interface, System.Collections.Generic.IEnumerable<Screen> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ScreenList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.ScreenList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ScreenList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ScreenList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_ScreenList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  private class ScreenListEnumerator : System.Collections.Generic.IEnumerator<Screen> {
    private ScreenList _list;
    private int _index;
    public ScreenListEnumerator(ScreenList list) {
      _list = list;
      _index = -1;
    }
    public void Reset() {
      _index = -1;
    }
    public Screen Current {
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
  public System.Collections.Generic.IEnumerator<Screen> GetEnumerator() {
    return new ScreenListEnumerator(this);
  }
  public Screen this[int index] {
    get { return _operator_get(index); }
  }

  public ScreenList() : this(LeapPINVOKE.new_ScreenList(), true) {
  }

  private Screen _operator_get(int index) {
    Screen ret = new Screen(LeapPINVOKE.ScreenList__operator_get(swigCPtr, index), true);
    return ret;
  }

  public Screen ClosestScreenHit(Pointable pointable) {
    Screen ret = new Screen(LeapPINVOKE.ScreenList_ClosestScreenHit__SWIG_0(swigCPtr, Pointable.getCPtr(pointable)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Screen ClosestScreenHit(Vector position, Vector direction) {
    Screen ret = new Screen(LeapPINVOKE.ScreenList_ClosestScreenHit__SWIG_1(swigCPtr, Vector.getCPtr(position), Vector.getCPtr(direction)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Screen ClosestScreen(Vector position) {
    Screen ret = new Screen(LeapPINVOKE.ScreenList_ClosestScreen(swigCPtr, Vector.getCPtr(position)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Count {
    get {
      int ret = LeapPINVOKE.ScreenList_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmpty {
    get {
      bool ret = LeapPINVOKE.ScreenList_IsEmpty_get(swigCPtr);
      return ret;
    } 
  }

}

}
