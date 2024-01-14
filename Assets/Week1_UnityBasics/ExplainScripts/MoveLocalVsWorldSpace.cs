using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocalVsWorldSpace : MonoBehaviour
{
   //movement by transform
    private void Update()
    {
        //transform.position += new Vector3(1, 0, 0) * Time.deltaTime * 0.5f;


        //transform.forward calculate direction relative to local space (take object rotation into consideration)
        //transform.position += transform.forward * Time.deltaTime * 0.5f;

        //Vector3.forward calculate direction relative to world space (independent on object rotation)
        transform.position += Vector3.forward * Time.deltaTime * 0.5f;
    }


    //forward -> (0,0,1)
    //backward -> (0,0,-1)
    //left -> (-1,0,0)
    //right -> (1,0,0)
    //up -> (0,1,0)
    //down (0,-1,0)
}
