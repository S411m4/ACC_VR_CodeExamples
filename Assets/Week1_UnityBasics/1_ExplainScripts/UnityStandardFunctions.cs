using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// unity standard functions and their differences
/// </summary>
public class UnityStandardFunctions : MonoBehaviour
{
    //called at start of scene , after Awake
    //called only once at start of scene
    private void Start()
    {
        Debug.Log("Start");
    }

    ////when gameObject is active in scene, called once
    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    //called at the start of scene
    //called before Start( )
    //called only once at start of scene
    private void Awake()
    {

        Debug.Log("Awake");
    }

    //called as long as scene is running
    //called slower than Update 
    //used for physics simulation, has same frequency as physics system independent on framerate
    private void FixedUpdate()
    {

        Debug.Log("FixedUpdate");
    }

    //called every frame if gameObject is active
    private void Update()
    {

        Debug.Log("Update");
    }

    //called if gameobject is active
    //execute after update function
    //for example using Update to move objects in scene
    //and using late update to reflect these chantes in camera behaviour
    private void LateUpdate()
    {

        Debug.Log("LateUpdate");
    }

    ////called when gameobject is set to inactive, called once
    private void OnDisable()
    {

        Debug.Log("OnDisable");
    }

    ////called when gameobject is destroy, called once
    private void OnDestroy()
    {

        Debug.Log("OnDestroy");
    }
}
