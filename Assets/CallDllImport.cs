using UnityEngine;
using System.Collections;
using Leap;

public class CallDllImport : MonoBehaviour {

  int count = 0;
	// Use this for initialization
	void Start () {
	  Debug.Log("started CallDllImport object");
	}
	
	// Update is called once per frame
	void Update () {
		Leap.Frame f = new Leap.Frame();
        if (!f.IsValid) {
          Debug.Log("allocated a Leap.Frame with JNI destructor " + count);
        }
    count += 1;
	}
}
