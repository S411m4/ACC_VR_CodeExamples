using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlModelAnimtor : MonoBehaviour
{
    [SerializeField] private float value = 0;

    [SerializeField] private Animator animator;

    private void Update()
    {
        animator.SetFloat("walk", value);

        //animator.SetFloat("Walk", value);
    }

}
