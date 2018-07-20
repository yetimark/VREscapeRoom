using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chestthing : MonoBehaviour
{
    private Vector3 home;
    public Transform startRotation;
    public Transform targetRotation;
    public float speed = 1f;

    public GameObject knob;

    private void Start()
    {
        this.home = this.knob.transform.position;
    }

    void ObjectLerp()
    {
        this.gameObject.transform.rotation = Quaternion.Lerp(this.startRotation.rotation, this.targetRotation.rotation, Time.deltaTime * this.speed);
    }

    private void Update()
    {
        if (this.knob.transform.position != this.home)
        {
            ObjectLerp();
        }
        else if(this.gameObject.transform == this.targetRotation)
        {
            //GameObject.FindGameObjectsWithTag("awesome").GetComponent<ParticleSystem>().Play();
        }

        
    }
}