using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// gameobjects in unity has their own properties defined by components
/// transform and gameObject are special components because every gameObject even if it is empty must have a transform
/// and transform component must be attached to a gameobject
/// </summary>
public class Test_GetComponent : MonoBehaviour
{
    private void Start()
    {
        ////---------------------------------------------
        ////GetComponent< >( )
        //Transform t = GetComponent<Transform>();
        //Debug.Log(t.position);


        ////------------------------------------------------
        ////gameObejct and transform component
        //Debug.Log("position: " + this.transform.position);
        //Debug.Log("rotation (Quaternion): " + this.transform.rotation);
        //Debug.Log("scale: " + this.transform.localScale);

        //Debug.Log("name: " + gameObject.name);
        //Debug.Log("isActive: " + gameObject.activeSelf);
        //Debug.Log("tag: " + gameObject.tag);
        //Debug.Log("layer: " + gameObject.layer);


        ////-----------------------------------------------
        ////remember to check for null before using the component
        ////ERROR: if component is not found will return NULL, and if we tried using the variable will get null reference error
        //Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        //Debug.Log(rb.velocity); //WRONG

        //if (rb != null) { Debug.Log(rb.velocity); }
        //else { Debug.Log("Not Found"); }

        ////----------------------------------
        ////or we can use TryGetComponent< >(out ComponentType componentVar)
        //if (TryGetComponent<Rigidbody>(out Rigidbody rb_T))
        //{
        //    Debug.Log(rb_T.velocity);
        //}
        //else
        //{
        //    gameObject.AddComponent<Rigidbody>();
        //}
        ////we can add or remove components by 
        ////gameObject.AddComponent<ComponentName>( );
        ////gameObject.RemoveComponent<ComponentName>( );


    }
}
