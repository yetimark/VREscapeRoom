using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour
{
    public float speed = 1f;
    
    public bool go = false;
    public Transform startRotation;
    public Transform targetRotation;
    public GameObject opener;
    public GameObject opener2;

    void ObjectLerp()
    {
        this.gameObject.transform.rotation = Quaternion.Lerp(this.startRotation.rotation, this.targetRotation.rotation, Time.deltaTime * this.speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == this.opener ||
            other.gameObject == this.opener2)
        {
            this.go = true;
        }
    }

    private void Update()
    {
        if (this.go)
        {
            ObjectLerp();
        }
    }
}