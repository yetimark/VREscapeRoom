using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour
{


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Key1")
        {
            Debug.Log("The key has hit the door!");
            this.gameObject.transform.Rotate(0, 90, 0);
        }
    }

}
