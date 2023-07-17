using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   
    //make sure to choose the keys from inspector
    [SerializeField] private KeyCode keyUp; //for input example
    [SerializeField] private KeyCode keyDown; //for input example
    [SerializeField] private KeyCode key; //for input example


    private void Update()
    {
        Vector3 moveDir = new Vector3(0,0,0);

        if(Input.GetKey(KeyCode.D))
        {
            moveDir = new Vector3(0,0,1);
        }

        if(Input.GetKey(KeyCode.A))
        {
            moveDir = new Vector3(0,0,-1);

        }

        if(Input.GetKey(KeyCode.W))
        {
            moveDir = new Vector3(-1,0,0);

        }

        if(Input.GetKey(KeyCode.S))
        {
            moveDir = new Vector3(1,0,0);

        }

        transform.position += moveDir * Time.deltaTime;
    }



    //difference between Input timing
    // private void Update()
    // {
    //     if(Input.GetKey(key))
    //     {
    //         Debug.Log(key);
    //     }

    //     if(Input.GetKeyDown(keyDown))
    //     {
    //         Debug.Log(keyDown);
    //     }

    //     if(Input.GetKeyUp(keyUp))
    //     {
    //         Debug.Log(keyUp);
    //     }
    // }



    //difference between different Unity Functions, is according to the order of their execution
    //they are called in the order below
    //Note: there cannot be two Update(),in your script, the same for the other functions below

    //  private void Awake()
    // {
    //     Debug.Log("Awake");
    // }

      
    // private void Start()
    // {
    //   Debug.Log("Start");

    // }

    // private void Update()
    // {
        
    //     Debug.Log("Update");
    // }
 
    

    // private void LateUpdate()
    // {
    //   Debug.Log("FixedUpdate");

    // }

  

}
