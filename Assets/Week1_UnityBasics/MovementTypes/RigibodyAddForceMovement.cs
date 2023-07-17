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

    private void Update()
    {
        rb.AddForce(Vector3.forward * forceAmount  * Time.deltaTime);

    }
}
