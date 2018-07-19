using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class bookshelfMover : MonoBehaviour         //modified from unity manual Vector3.Lerp

{

    public float speed = 1f;

    public float journeyLength;

    public Transform startMarker;

    public Transform endMarker;
    public GameObject bookShelf;



    private float startTime;

    private bool go = false;



    private void Start()

    {

        this.startTime = Time.time;

        this.journeyLength = Vector3.Distance(this.startMarker.position, this.endMarker.position);

    }





    void SecretDoor()

    {

        float distanceCovered = (Time.time - this.startTime) * this.speed;

        float fracJourney = distanceCovered / this.journeyLength;



        this.bookShelf.transform.position = Vector3.Lerp(this.startMarker.position, this.endMarker.position, fracJourney);

    }



    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.name == "SecretBook")

        {

            this.go = true;

        }

    }



    private void Update()

    {

        if (this.go)

        {

            SecretDoor();

        }

    }



}