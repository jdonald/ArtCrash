/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Leap {

public class Matrix : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public Matrix(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public static global::System.Runtime.InteropServices.HandleRef getCPtr(Matrix obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Matrix() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LeapPINVOKE.delete_Matrix(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  /** Multiply two matrices. */ 
  public static Matrix operator * (Matrix m1, Matrix m2) {
    return m1._operator_mul(m2);
  }
  /** Copy this matrix to the specified array of 9 float values in row-major order. */
  public float[] ToArray3x3(float[] output) {
    output[0] = xBasis.x; output[1] = xBasis.y; output[2] = xBasis.z;
    output[3] = yBasis.x; output[4] = yBasis.y; output[5] = yBasis.z;
    output[6] = zBasis.x; output[7] = zBasis.y; output[8] = zBasis.z;
    return output;
  }
  /** Copy this matrix to the specified array containing 9 double values in row-major order. */
  public double[] ToArray3x3(double[] output) {
    output[0] = xBasis.x; output[1] = xBasis.y; output[2] = xBasis.z;
    output[3] = yBasis.x; output[4] = yBasis.y; output[5] = yBasis.z;
    output[6] = zBasis.x; output[7] = zBasis.y; output[8] = zBasis.z;
    return output;
  }
  /** Convert this matrix to an array containing 9 float values in row-major order. */
  public float[] ToArray3x3() {
    return ToArray3x3(new float[9]);
  }
  /** Copy this matrix to the specified array of 16 float values in row-major order. */
  public float[] ToArray4x4(float[] output) {
    output[0]  = xBasis.x; output[1]  = xBasis.y; output[2]  = xBasis.z; output[3]  = 0.0f;
    output[4]  = yBasis.x; output[5]  = yBasis.y; output[6]  = yBasis.z; output[7]  = 0.0f;
    output[8]  = zBasis.x; output[9]  = zBasis.y; output[10] = zBasis.z; output[11] = 0.0f;
    output[12] = origin.x; output[13] = origin.y; output[14] = origin.z; output[15] = 1.0f;
    return output;
  }
  /** Copy this matrix to the specified array of 16 double values in row-major order. */
  public double[] ToArray4x4(double[] output) {
    output[0]  = xBasis.x; output[1]  = xBasis.y; output[2]  = xBasis.z; output[3]  = 0.0f;
    output[4]  = yBasis.x; output[5]  = yBasis.y; output[6]  = yBasis.z; output[7]  = 0.0f;
    output[8]  = zBasis.x; output[9]  = zBasis.y; output[10] = zBasis.z; output[11] = 0.0f;
    output[12] = origin.x; output[13] = origin.y; output[14] = origin.z; output[15] = 1.0f;
    return output;
  }
  /** Convert this matrix to an array containing 16 float values in row-major order. */
  public float[] ToArray4x4() {
    return ToArray4x4(new float[16]);
  }

  public Matrix() : this(LeapPINVOKE.new_Matrix__SWIG_0(), true) {
  }

  public Matrix(Matrix other) : this(LeapPINVOKE.new_Matrix__SWIG_1(Matrix.getCPtr(other)), true) {
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix(Vector _xBasis, Vector _yBasis, Vector _zBasis) : this(LeapPINVOKE.new_Matrix__SWIG_2(Vector.getCPtr(_xBasis), Vector.getCPtr(_yBasis), Vector.getCPtr(_zBasis)), true) {
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix(Vector _xBasis, Vector _yBasis, Vector _zBasis, Vector _origin) : this(LeapPINVOKE.new_Matrix__SWIG_3(Vector.getCPtr(_xBasis), Vector.getCPtr(_yBasis), Vector.getCPtr(_zBasis), Vector.getCPtr(_origin)), true) {
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix(Vector axis, float angleRadians) : this(LeapPINVOKE.new_Matrix__SWIG_4(Vector.getCPtr(axis), angleRadians), true) {
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Matrix(Vector axis, float angleRadians, Vector translation) : this(LeapPINVOKE.new_Matrix__SWIG_5(Vector.getCPtr(axis), angleRadians, Vector.getCPtr(translation)), true) {
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRotation(Vector axis, float angleRadians) {
    LeapPINVOKE.Matrix_SetRotation(swigCPtr, Vector.getCPtr(axis), angleRadians);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
  }

  public Vector TransformPoint(Vector arg0) {
    Vector ret = new Vector(LeapPINVOKE.Matrix_TransformPoint(swigCPtr, Vector.getCPtr(arg0)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Vector TransformDirection(Vector arg0) {
    Vector ret = new Vector(LeapPINVOKE.Matrix_TransformDirection(swigCPtr, Vector.getCPtr(arg0)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix RigidInverse() {
    Matrix ret = new Matrix(LeapPINVOKE.Matrix_RigidInverse(swigCPtr), true);
    return ret;
  }

  private Matrix _operator_mul(Matrix other) {
    Matrix ret = new Matrix(LeapPINVOKE.Matrix__operator_mul(swigCPtr, Matrix.getCPtr(other)), true);
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Equals(Matrix other) {
    bool ret = LeapPINVOKE.Matrix_Equals(swigCPtr, Matrix.getCPtr(other));
    if (LeapPINVOKE.SWIGPendingException.Pending) throw LeapPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override string ToString() {
    string ret = LeapPINVOKE.Matrix_ToString(swigCPtr);
    return ret;
  }

  public Vector xBasis {
    set {
      LeapPINVOKE.Matrix_xBasis_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Matrix_xBasis_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector yBasis {
    set {
      LeapPINVOKE.Matrix_yBasis_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Matrix_yBasis_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector zBasis {
    set {
      LeapPINVOKE.Matrix_zBasis_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Matrix_zBasis_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector origin {
    set {
      LeapPINVOKE.Matrix_origin_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LeapPINVOKE.Matrix_origin_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public static Matrix Identity {
    get {
      Matrix ret = new Matrix(LeapPINVOKE.Matrix_Identity_get(), false);
      return ret;
    } 
  }

}

}