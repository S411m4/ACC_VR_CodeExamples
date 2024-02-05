using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Listener_Example : MonoBehaviour
{
    private void Start()
    {
        StaticInvoker_Example.OnSpaceHitEvent += PrintSomething;
        StaticInvoker_Example.OnSpaceHitEvent += DestroyObject;

        StaticInvoker_Example.OnSHitEvent += ChangeMaterial;


    }

    private void OnDestroy()
    {
        StaticInvoker_Example.OnSpaceHitEvent -= PrintSomething;
        StaticInvoker_Example.OnSpaceHitEvent -= DestroyObject;
        StaticInvoker_Example.OnSHitEvent -= ChangeMaterial;

    }

    private void ChangeMaterial(Material material)
    {
        this.GetComponent<MeshRenderer>().material = material;
    }

    private void DestroyObject()
    {
        Destroy(this.gameObject);
    }
    private void PrintSomething()
    {
        Debug.Log(this.gameObject.name + " Dead");
    }
}
