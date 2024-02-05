using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] ParticleSystem bloodEffect;

    private void OnTriggerEnter()
    {
        animator.SetBool("die", true);
    }

    public void DeathEffect()
    {
        bloodEffect.Play();
        Destroy(this.gameObject);
    }


}
