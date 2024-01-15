using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//moving gameObject by physics , by changing the velocity once
//according to newton's law the constant velocity applied will remain unchanged as long there is no external
//force affecting it
//this is why we applied the velocity once on Start(), and not on Update()
//</summary>


public class RigibodyVelocityMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float velocityMult = 200;


    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = transform.forward * Time.deltaTime * velocityMult;
    }
}
