using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDanceMusic : MonoBehaviour {

    public int clickcount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClickedPlay()
    {
        AudioSource audio = GetComponent<AudioSource>();
        clickcount = clickcount + 1;
        if (clickcount < 2)
        {
            audio.Play();
        }
        else
        {
            audio.Stop();
            clickcount = 0;
        }
    }
}
