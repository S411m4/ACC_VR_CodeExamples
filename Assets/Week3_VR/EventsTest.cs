using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class EventsTest : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<XRDirectInteractor>().hoverEntered.AddListener(DebugTest);
    }
    
    private void DebugTest(HoverEnterEventArgs args)
    {
        Debug.Log(args.interactableObject);
    }
}

