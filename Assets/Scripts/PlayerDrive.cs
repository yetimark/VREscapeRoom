using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrive : MonoBehaviour
{



    public float goSpeed;

    public float turnSpeed;



    void Update()

    {

        if (Input.GetAxis("Horizontal") != 0 ||

            Input.GetAxis("Vertical") != 0)

        {

            this.gameObject.transform.Translate(0, 0, Input.GetAxis("Vertical") * this.goSpeed);

            this.gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * this.turnSpeed, 0);

        }

    }

}