using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterStart : MonoBehaviour
{

    public Transform destination;       //empty gameObject for positioning
    private Vector3 home;

    private void Start()
    {
        this.home = this.gameObject.transform.position;
    }

    private void Update()
    {
        if(this.transform.position != this.home)
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = this.destination.position;
        }
    }
}