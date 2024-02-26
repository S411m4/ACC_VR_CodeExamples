using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptmizationTest : MonoBehaviour
{

    private float accumulator = 0f;
    private const float CHANGE_COLOR_TIME = 1f;

    private Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };

    [SerializeField] private MeshRenderer obj;

    private void Update()
    {
        accumulator += Time.deltaTime;

        if (accumulator > CHANGE_COLOR_TIME)
        {
            accumulator = 0f;

            obj.material.color = colors[Random.Range(0, colors.Length)];
        }
        
    }

    //private void Update()
    //{
    //    accumulator += Time.deltaTime;

    //    if(accumulator > CHANGE_COLOR_TIME)
    //    {
    //        accumulator = 0f;
    //        GameObject obj = GameObject.Find("MyCube");
    //        obj.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
    //    }
    //}
}
