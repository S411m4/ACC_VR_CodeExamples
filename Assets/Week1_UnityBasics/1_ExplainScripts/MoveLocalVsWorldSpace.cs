using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocalVsWorldSpace : MonoBehaviour
{
   //movement by transform
    private void Update()
    {
       // transform.localPosition += new Vector3(1,0,0);
        //same as
        //transform.localPosition = transform.localPosition +  new Vector3(1,0,0);


        //----------------------------------
       // transform.position += new Vector3(0, 0, 1) * Time.deltaTime;

        //---------------------------------
        //transform.forward calculate direction relative to local space (take object rotation into consideration)
        //transform.position += transform.forward * Time.deltaTime;
        //transform.position += -transform.forward * Time.deltaTime;
        
        
        //-------------------------------------
        //Vector3.forward calculate direction relative to world space (independent on object rotation)
        //transform.position += Vector3.forward * Time.deltaTime;
    }


    //forward -> (0,0,1)
    //backward -> (0,0,-1)
    //left -> (-1,0,0)
    //right -> (1,0,0)
    //up -> (0,1,0)
    //down (0,-1,0)
}
