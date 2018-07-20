using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenceStick : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beast")         //be sure to tag enemy animals as "beast" 
                                                     //also make a prefab of beasts so they can be respawned in if a player has failed game
        {
            Destroy(other.gameObject);
        }
    }
}