using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
    [SerializeField] private float min = -10f;
    [SerializeField] private float max = 10f;
    [SerializeField] private float speed = 0.5f;
    private bool moveUp = true;
    private void Update()
    {
        if (moveUp && transform.position.y < max)
        {
            this.transform.position += new Vector3(0, 1f, 0) * speed * Time.deltaTime;
        } 
        else if(moveUp && transform.position.y > max)
        {
            moveUp = false;
        }
        else if(!moveUp && transform.position.y > min)
        {
            this.transform.position -= new Vector3(0, 1f, 0) * speed * Time.deltaTime;

        }
        else
        {
            moveUp = true;

        }


    }
}
