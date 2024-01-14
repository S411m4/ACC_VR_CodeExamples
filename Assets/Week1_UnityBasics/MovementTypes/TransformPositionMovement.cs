using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//change the position of the gameObject transform, this type of movement is not affected by any physics
//it is like teleporating the object from one place to another
//we multiple by Time.deltatime to make sure that the speed is the same across different devices with different
//frame rates
//</summary>
public class TransformPositionMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    } 
}
