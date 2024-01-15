using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//like transform.position, the difference is that it moves the object locally
//try changing the y rotation of the gameObject of this script and the gameObject of the transform.position script
//with the same amount to see the difference between the two scripts
//</summary>

public class TranslateMovement : MonoBehaviour
{
   private void Update()
   {

    transform.Translate(Vector3.forward * Time.deltaTime);

        //you can choose mode, whether:
        //Space.self -> relative (moves according to local position, which is the default)
        //Space.World  (moves according to global position)
        
    }
}
