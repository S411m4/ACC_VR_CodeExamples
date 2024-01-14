using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//move object by physics
//it adds force to the objects (like little pushes) every update
//the force amount is relativly big because there are other forces affecting the gameObject, like gravity
//</summary>

public class RigibodyAddForceMovement : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private int forceAmount = 200;
    private void Awake()
    {
        rb = this.GetComponent<Rigidbody>();

    }

    private void Start()
    {
        //transform.forward for rotation dependent movement
        //Vector3.forward for rotation independent movement

        rb.AddForce(transform.forward * forceAmount  * Time.deltaTime);

    }
}
