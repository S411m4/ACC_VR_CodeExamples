using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
///difference between rigidbody.AddForce and rigidbody.velocity
//</summary>

[RequireComponent(typeof(Rigidbody))]
public class MarioPlayer : MonoBehaviour
{
    private Rigidbody rb;

    [Header("player variables")]
    [Tooltip("amount of force applied to player jump")]
    [SerializeField] private float jumpForce;

    [Range(0f, 10f)]
    [SerializeField] private float moveSpeed;
    
    private void Awake()
    {
        //caching component on Awake to save performance and not keep calling it on Update

        rb = this.GetComponent<Rigidbody>();
    }

    //tips for movement
    //multiply by Time.DeltaTime to make sure the movement speed is the same on different frame rates
    //use local space when moving to make sure movement is as expected
    //use variables for speed, jumpHeight, .... and don't hard code these values in code

    private void Update()
    {
        //move player

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * moveSpeed;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * moveSpeed;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space)) //we only want to jump once , so use GetKeyDown
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Acceleration);

        }
    }

    //ways of taking input from unity (basic ways using old input system)
    //Input.GetKey( )

    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.S))
    //    {
    //        Debug.Log("KeyDown");
    //    }

    //    if (Input.GetKeyUp(KeyCode.S))
    //    {
    //        Debug.Log("KeyUp");
    //    }

    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        Debug.Log("Key");
    //    }
    //}

    //using Input.GetAxis( )
    //private void Update()
    //{

    //    //move independent on local rotation, will return value of Horizontal and Vetical Axis in unity
    //    Debug.Log("H: " + Input.GetAxis("Horizontal"));
    //    Debug.Log("V: " + Input.GetAxis("Vertical"));

    //    transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Time.deltaTime * moveSpeed;
    //}
}

