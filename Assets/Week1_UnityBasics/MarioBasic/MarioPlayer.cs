using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
///difference between rigidbody.AddForce and rigidbody.velocity
//</summary>
public class MarioPlayer : MonoBehaviour
{
    private Rigidbody rb; 
    [SerializeField] private float jumpHeight;
    
    private void Awake()
    {
        //caching component on Awake to save performance and not keep calling it on Update

        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Acceleration);
            //adds Force (like a push) and accelrate velocity of object gradually
            
            //rb.velocity = new Vector3(0,1,0) * jumpHeight;
            //adds velocity to the object instantaly 
        }
    }
}

