using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//advantages:
//1. supports devices across different platforms as keyboard, mouse, joystick, VR controlls, AR glasses, eye trackers, xbobx, playstation, ...
//2.it is event based which ensures that no inputs are lost or delayed due to frame rate fluctuations and increase performance
//3.handle device disconnect well
//4.can change controls bindings during playtime easily
//5.has built-in debugger that can be used to see input values

//disadvantags:
//more complex in setup and usage than the old input system

public class Movement_New_InputSystem : MonoBehaviour
{

    //you can use your input action by two methods
    //method 1: taking reference to individual actions
    //[SerializeField] private InputActionProperty jumpAction; //reference jump action from the input action you created
    //[SerializeField] private InputActionProperty moveAction; 

    private Rigidbody rb;
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float runSpeed = 8f;


    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}



    //private void OnEnable()
    //{
    //    jumpAction.action.Enable(); //enabling the action

    //    //action has three phases, in order: started, performed, cancelled

    //    jumpAction.action.performed += Jump;
    //    jumpAction.action.started += (InputAction.CallbackContext ctx) => Debug.Log("started");  //subscribe using lambda function
    //    jumpAction.action.canceled += (InputAction.CallbackContext ctx) => Debug.Log("Cancelled");


    //    moveAction.action.Enable();
    //    //moveAction.action.performed += Move; //uncomment for discontinous movement, moves unit every time you press

    //}

    //private void OnDisable()
    //{
    //    jumpAction.action.Disable();

    //    jumpAction.action.performed -= Jump;
    //    //you cannot really unsubscribe from events subscribed by lambda functions, you need to either subscribe with a function or store the lambda function in a delegate

    //    moveAction.action.Disable();
    //    //moveAction.action.performed -= Move; 
    //}

    //private void Update()
    //{
    //    //there is no GetKey in the new input , so if we want continous movement we will keep reading the value in update

    //    Vector2 moveXY = moveAction.action.ReadValue<Vector2>(); //returns one of the following: (0,0), (1,0), (-1, 0), (0,1), (0,-1)
    //    Debug.Log(moveXY);

    //    this.transform.position += new Vector3(moveXY.x, 0, moveXY.y) * Time.deltaTime * moveSpeed;
    //}


    //private void Jump(InputAction.CallbackContext ctx)
    //{
    //    Debug.Log("Jump performed");

    //    rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    //}

    //private void Move(InputAction.CallbackContext ctX)
    //{
    //    Vector2 moveXY = moveAction.action.ReadValue<Vector2>();
    //    Debug.Log(moveXY);

    //    this.transform.position += new Vector3(moveXY.x, 0, moveXY.y);
    //}



    //method 2: generating C# class from the input action and using it

    private MyActions myActions = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        myActions = new MyActions();
    }

    private void OnEnable()
    {
        myActions.Enable();



        myActions.Player.move.performed += SetMoveSpeed;
        myActions.Player.FastRunForward.performed += SetRunSpeed;

        myActions.Player.jump.performed += Jump;


    }

    private void OnDisable()
    {
        myActions.Disable();

        myActions.Player.move.performed -= SetMoveSpeed;
        myActions.Player.FastRunForward.performed -= SetRunSpeed;
        myActions.Player.jump.performed -= Jump;


    }

    private void Jump(InputAction.CallbackContext ctx)
    {
        Debug.Log("Jump");

        rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    private void SetMoveSpeed(InputAction.CallbackContext ctx)
    {
        moveSpeed = 4f;
    }
    private void Move()
    {
        InputAction moveAction = myActions.Player.move;

        Vector2 moveXY = moveAction.ReadValue<Vector2>();
        Debug.Log(moveXY);

        this.transform.position += new Vector3(moveXY.x, 0, moveXY.y) * moveSpeed * Time.deltaTime;
    }

    private void SetRunSpeed(InputAction.CallbackContext ctX)
    {
        moveSpeed = 8f;
    }

    private void Update()
    {
        Move();
    }









}
