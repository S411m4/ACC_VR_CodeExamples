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
    transform.position += Vector3.forward * Time.deltaTime;
   }

   //to change relative position, use transform.localPosition

    //vector3.forward(0,0,1)
    //Vector3.back (0,0,-1)
    //Vector3.up(0,1,0)
    //down(0,-1,0)
    //right(1, 0, 0)
    //left (-1,0,0)
}
