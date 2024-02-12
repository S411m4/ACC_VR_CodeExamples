using System;
using UnityEngine;

public class StaticInvoker_Example : MonoBehaviour
{
    [SerializeField] private Material material;

    public static Action OnSpaceHit;
    public static Action<Material> OnSHit;

   


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            //change color
            OnSHit?.Invoke(material);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //die
            OnSpaceHit?.Invoke();
        }
    }
    //    public static Action OnSpaceHitEvent;
    //    public static Action<Material> OnSHitEvent;
    //    [SerializeField] private Material material;

    //    private void Update()
    //    {
    //        if(Input.GetKeyDown(KeyCode.Space))
    //        {
    //            OnSpaceHitEvent?.Invoke();
    //        }
    //        if (Input.GetKeyDown(KeyCode.S))
    //        {
    //            OnSHitEvent?.Invoke(material);
    //        }
    //    }
}
