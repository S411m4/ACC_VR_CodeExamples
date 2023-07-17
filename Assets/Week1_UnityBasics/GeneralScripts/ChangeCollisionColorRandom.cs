using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//<summary>
//change color of material
//</summary>
public class ChangeCollisionColorRandom : MonoBehaviour
{


    
    [SerializeField] Color[] colorList;

    private void OnCollisionEnter(Collision other)
    {
        this.GetComponent<MeshRenderer>().material.color = colorList[Random.Range(0, colorList.Length)];
    }
}
