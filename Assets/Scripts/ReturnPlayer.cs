using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnPlayer : MonoBehaviour {

    public Vector3 home;

    private void Start()
    {
        this.home = this.gameObject.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Beast")
        {
            this.gameObject.transform.position = this.home;
        }
    }
}
