using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//difference between collider events and trigger events
//</summary>

public class ChangeCollisionMaterialRandom : MonoBehaviour
{

  

     [SerializeField] private Material[] materialList;
     [SerializeField] private Material redMaterial; //for the trigger example
     [SerializeField] private  Material blueMaterial; //for the trigger example




   private void OnCollisionEnter(Collision other)
   {

      //change material of your gameObject when you collide
      //this.GetComponent<MeshRenderer>().material = materialList[Random.RandomRange(0, materialList.Length)];

      //change material of the object that you collided with
      other.gameObject.GetComponent<MeshRenderer>().material = materialList[Random.Range(0,materialList.Length)];
   }




   // //change the material of the collided object depending on timing of collision in trigger collider
   //   private void OnTriggerEnter(Collider other)
   //   {
        
   //      other.gameObject.GetComponent<MeshRenderer>().material =redMaterial;

   //   }

   //    private void OnTriggerStay(Collider other) //comment this to see clearly the difference between OnTriggerEnter and OnTriggerExit
   //    {
   //       other.gameObject.GetComponent<MeshRenderer>().material = materialList[Random.Range(0, materialList.Length)];
   //    }
    

   //   private void OnTriggerExit(Collider other)
   //   {
   //      other.gameObject.GetComponent<MeshRenderer>().material =blueMaterial;

   //   }

     
}
