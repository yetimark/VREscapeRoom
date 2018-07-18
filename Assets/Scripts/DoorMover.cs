using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Key")
        {
            Debug.Log("The key has hit the door!");
            Debug.Log(this.gameObject.name);
            this.gameObject.transform.parent.transform.Rotate(0, 90, 0);
        }
    }

}
