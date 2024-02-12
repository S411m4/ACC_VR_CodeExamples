using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Listener_Example : MonoBehaviour
{
    private void Awake()
    {
        StaticInvoker_Example.OnSHit += ChangeColor;
        StaticInvoker_Example.OnSpaceHit += Die;
    }

    private void OnDestroy()
    {
        StaticInvoker_Example.OnSHit -= ChangeColor;
        StaticInvoker_Example.OnSpaceHit -= Die;
    }


    private void ChangeColor(Material m)
    {
        this.GetComponent<MeshRenderer>().material = m;
    }

    private void Die()
    {
        if(this.gameObject.CompareTag("Player"))
             Destroy(gameObject);
        
    }


    //    private void Start()
    //    {
    //        StaticInvoker_Example.OnSpaceHitEvent += PrintSomething;
    //        StaticInvoker_Example.OnSpaceHitEvent += DestroyObject;

    //        StaticInvoker_Example.OnSHitEvent += ChangeMaterial;


    //    }

    //    private void OnDestroy()
    //    {
    //        StaticInvoker_Example.OnSpaceHitEvent -= PrintSomething;
    //        StaticInvoker_Example.OnSpaceHitEvent -= DestroyObject;
    //        StaticInvoker_Example.OnSHitEvent -= ChangeMaterial;

    //    }

    //    private void ChangeMaterial(Material material)
    //    {
    //        this.GetComponent<MeshRenderer>().material = material;
    //    }

    //    private void DestroyObject()
    //    {
    //        Destroy(this.gameObject);
    //    }
    //    private void PrintSomething()
    //    {
    //        Debug.Log(this.gameObject.name + " Dead");
    //    }
}
