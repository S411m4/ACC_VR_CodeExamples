using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//disadvantages of old input system
//1. it is poll based not event based, so when using it we will always check in the update for input
//2. supports less devices as keyboard, mouse, joystick and touchscreen. 
//adding support for a new device requires third-party plugins
//3.chaning controls bindings during gameplay is very hard
//4.didn't handle device disconnects well

//advantages:
//easier to use and setup than the new input system
//so it is handy if you want a quick test for an idea, or use it for quick debugging


public class Movement_Old_InputSystem : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    private Rigidbody rb;

    private void Awake()
    {
         rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        //method 1: we can check for specific buttons
        if(Input.GetKey(KeyCode.W))
        {
           transform.position += new Vector3(0,0,1) * moveSpeed * Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.S))
        {
           transform.position += new Vector3(0,0,-1) * moveSpeed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.A))
        {
           transform.position += new Vector3(-1,0,0) * moveSpeed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.D))
        {
           transform.position += new Vector3(1,0,0) * moveSpeed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //jump
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }

        //method 2: we can use unity defined horizontal and vertical axis
        //you can check the axis buttons from : project settings -> input manager

        //float horizontalMoveDir = Input.GetAxis("Horizontal");
        //float verticalMoveDir = Input.GetAxis("Vertical");

        //transform.position += new Vector3(horizontalMoveDir, 0, verticalMoveDir) * moveSpeed * Time.deltaTime;

        //if (Input.GetButtonDown("Jump"))
        //{
        //    rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        //}
    }

   

}
