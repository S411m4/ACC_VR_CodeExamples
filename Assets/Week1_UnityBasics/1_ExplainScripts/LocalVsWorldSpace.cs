using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVsWorldSpace : MonoBehaviour
{

    ////difference between each variable
    private void Start()
    {
        Debug.Log(gameObject.name + "position: " + transform.position); //World position
        Debug.Log(gameObject.name + "local position: " + transform.localPosition); //local position

        //Debug.Log(gameObject.name + "rotation Euler: " + transform.eulerAngles);
        //Debug.Log(gameObject.name + "local rotation Euler: " + transform.localEulerAngles);

        //Debug.Log(gameObject.name + "rotation: " + transform.rotation);
        //Debug.Log(gameObject.name + "local rotation: " + transform.localRotation);
    }



}
