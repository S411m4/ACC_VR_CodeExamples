using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCubeMaterialOnCollision : MonoBehaviour
{
    [SerializeField] private Material newMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        this.GetComponent<MeshRenderer>().material = newMaterial;
    }
}
