using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExteriorRotate : MonoBehaviour
{

    //[Tooltip ("The Animator component on this gameobject")]
    public Animator animator;
    //[Tooltip ("The name of the Animator trigger parameter")]
    public string triggerName;

    public void SphereClicked()
    {
        // If the player pressed the cardboard button (or touched the screen), set the trigger parameter to active (until it has been used in a transition)
        {
            print("clicked");
            animator.SetTrigger(triggerName);
        }
    }
}