/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class ToolList : Interface, System.Collections.Generic.IEnumerable<Tool> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ToolList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.ToolList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ToolList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ToolList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_ToolList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  private class ToolListEnumerator : System.Collections.Generic.IEnumerator<Tool> {
    private ToolList _list;
    private int _index;
    public ToolListEnumerator(ToolList list) {
      _list = list;
      _index = -1;
    }
    public void Reset() {
      _index = -1;
    }
    public Tool Current {
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
  public System.Collections.Generic.IEnumerator<Tool> GetEnumerator() {
    return new ToolListEnumerator(this);
  }
  public Tool this[int index] {
    get { return _operator_get(index); }
  }

  public ToolList() : this(LeapPINVOKE.new_ToolList(), true) {
  }

  private Tool _operator_get(int index) {
    Tool ret = new Tool(LeapPINVOKE.ToolList__operator_get(swigCPtr, index), true);
    return ret;
  }

  public ToolList Append(ToolList other) {
    ToolList ret = new ToolList(LeapPINVOKE.ToolList_Append(swigCPtr, ToolList.getCPtr(other)), false);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Count {
    get {
      int ret = LeapPINVOKE.ToolList_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmpty {
    get {
      bool ret = LeapPINVOKE.ToolList_IsEmpty_get(swigCPtr);
      return ret;
    } 
  }

  public Tool Leftmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.ToolList_Leftmost_get(swigCPtr);
      Tool ret = (cPtr == global::System.IntPtr.Zero) ? null : new Tool(cPtr, true);
      return ret;
    } 
  }

  public Tool Rightmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.ToolList_Rightmost_get(swigCPtr);
      Tool ret = (cPtr == global::System.IntPtr.Zero) ? null : new Tool(cPtr, true);
      return ret;
    } 
  }

  public Tool Frontmost {
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.ToolList_Frontmost_get(swigCPtr);
      Tool ret = (cPtr == global::System.IntPtr.Zero) ? null : new Tool(cPtr, true);
      return ret;
    } 
  }

}

}
