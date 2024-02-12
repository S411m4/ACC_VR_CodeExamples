using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeListener : MonoBehaviour
{
    [SerializeField] private UnityEvents_Example sphere;

    private void Start()
    {
        sphere.hitEvent.AddListener(DebugTest);
    }

    private void DebugTest()
    {
        Debug.Log("Test");
    }
}
