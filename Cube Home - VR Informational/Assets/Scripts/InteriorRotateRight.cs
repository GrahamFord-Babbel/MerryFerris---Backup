using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorRotateRight : MonoBehaviour {

    public GameObject rightobj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //if (Input.GetMouseButtonDown(0) && rightobj...)
       // {
            print("clicked");
 
            rightobj.transform.Rotate(Vector3.up * Time.deltaTime);
       // }
	}
}
