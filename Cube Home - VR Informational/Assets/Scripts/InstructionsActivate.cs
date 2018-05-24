using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsActivate : MonoBehaviour
{
    public GameObject myInstructions;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Instructions()
    {
        if (myInstructions.activeSelf == false)
        {
            myInstructions.SetActive(true);
        }
        else
        {
            myInstructions.SetActive(false);
        }
    }
}