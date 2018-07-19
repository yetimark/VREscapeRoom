using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterStart : MonoBehaviour {

    public Transform destination;       //empty gameObject for positioning

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.position = this.destination.position;
    }
}
