/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class ImageList : Interface, System.Collections.Generic.IEnumerable<Image> {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public ImageList(global::System.IntPtr cPtr, bool cMemoryOwn) : base(LeapPINVOKE.ImageList_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(ImageList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ImageList() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_ImageList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  private class ImageListEnumerator : System.Collections.Generic.IEnumerator<Image> {
    private ImageList _list;
    private int _index;
    public ImageListEnumerator(ImageList list) {
      _list = list;
      _index = -1;
    }
    public void Reset() {
      _index = -1;
    }
    public Image Current {
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
  public System.Collections.Generic.IEnumerator<Image> GetEnumerator() {
    return new ImageListEnumerator(this);
  }
  public Image this[int index] {
    get { return _operator_get(index); }
  }

  public ImageList() : this(LeapPINVOKE.new_ImageList(), true) {
  }

  private Image _operator_get(int index) {
    Image ret = new Image(LeapPINVOKE.ImageList__operator_get(swigCPtr, index), true);
    return ret;
  }

  public ImageList Append(ImageList other) {
    ImageList ret = new ImageList(LeapPINVOKE.ImageList_Append(swigCPtr, ImageList.getCPtr(other)), false);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int Count {
    get {
      int ret = LeapPINVOKE.ImageList_Count_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsEmpty {
    get {
      bool ret = LeapPINVOKE.ImageList_IsEmpty_get(swigCPtr);
      return ret;
    } 
  }

}

}