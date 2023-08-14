using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_ : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float moveSpeed = 4f;

    public static Player_ instance;

    private MyActionsRebind myActionsRebind = null;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        myActionsRebind = new MyActionsRebind();
        instance = this;
    }

    public MyActionsRebind GetPlayerActions()
    {
        return myActionsRebind;
    }

    private void OnEnable()
    {
        myActionsRebind.Enable();
        myActionsRebind.Player.jump.performed += Jump;
    }

    private void OnDisable()
    {
        myActionsRebind.Disable();
        myActionsRebind.Player.jump.performed -= Jump;



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
        InputAction moveAction = myActionsRebind.Player.move;

        Vector2 moveXY = moveAction.ReadValue<Vector2>();
        Debug.Log(moveXY);

        this.transform.position += new Vector3(moveXY.x, 0, moveXY.y) * moveSpeed * Time.deltaTime;
    }


    private void Update()
    {
        Move();
    }

}
