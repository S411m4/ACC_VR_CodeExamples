using System;
using UnityEngine;

public class StaticInvoker_Example : MonoBehaviour
{
    public static Action OnSpaceHitEvent;
    public static Action<Material> OnSHitEvent;
    [SerializeField] private Material material;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            OnSpaceHitEvent?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnSHitEvent?.Invoke(material);
        }
    }
}
