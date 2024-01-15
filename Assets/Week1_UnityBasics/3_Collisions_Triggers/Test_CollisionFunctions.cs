using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  Collision events are only sent if at least one has a non-kinematic rigidbody attached. but not both
///  Collision events will be sent to disabled MonoBehaviours, to allow enabling Behaviours in response to collisions.
///  both must have collider component
/// </summary>
/// 
[RequireComponent(typeof(Rigidbody))]
public class Test_CollisionFunctions : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //once on collision start

        Debug.Log("Collision ENTER");
    }

    private void OnCollisionStay(Collision collision)
    {
        //as long as there is contact between the two objects
        Debug.Log("Collision STAY");

    }

    private void OnCollisionExit(Collision collision)
    {
        //once on collision exit
        Debug.Log("Collision EXIT");

    }


}
