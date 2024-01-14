using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///  Both GameObjects must contain a Collider component.
///  One must have Collider.isTrigger enabled, and contain a Rigidbody.
///  If both GameObjects have Collider.isTrigger enabled, no collision happens. 
///  The same applies when both GameObjects do not have a Rigidbody component.
/// </summary>
/// 

[RequireComponent(typeof(Rigidbody))]

public class Test_TriggerFunctions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //once on trigger enter
        Debug.Log("Trigger ENTER");
    }

    private void OnTriggerStay(Collider other)
    {
        //as long as in trigger area
        Debug.Log("Trigger STAY");

    }

    private void OnTriggerExit(Collider other)
    {
        //once on trigger exit
        Debug.Log("Trigger EXIT");

    }
}
