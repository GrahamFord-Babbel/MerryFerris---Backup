using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteriorRotate : MonoBehaviour {
    //public int n = 0;
    public bool southclicked = false;
    public bool northclicked;
    public bool eastclicked;
    public bool westclicked;
    public float newtime;


    void Update()
    {
        if (southclicked == true)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 12);
            newtime = newtime + Time.deltaTime;
            print("the new time is" + newtime);
            if (newtime > 7.55)
            {
                southclicked = false;
                newtime = 0;
            }
        }
        if (northclicked == true)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 12);
            newtime = newtime + Time.deltaTime;
            if (newtime > 7.55)
            {
                northclicked = false;
                newtime = 0;
            }
        }
        if (westclicked == true)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 12);
            newtime = newtime + Time.deltaTime;
            if (newtime > 7.55)
            {
                westclicked = false;
                newtime = 0;
            }
        }
        if (eastclicked == true)
        {
            transform.Rotate(Vector3.left * Time.deltaTime * 12);
            newtime = newtime + Time.deltaTime;
            print("the new time is" + newtime);
            if (newtime > 7.55)
            {
                eastclicked = false;
                newtime = 0;
            }
        }
    }
    public void SouthRotate()
    {
        southclicked = true;
    }
    public void NorthRotate()
    {
        northclicked = true;
      
    }
    public void WestRotate()
    {
        westclicked = true;
       
    }
    public void EastRotate()
    {
        eastclicked = true;
     
    }
    // Use this for initialization
    void Start () {
		
	}

}
//back or forward, not left or right?