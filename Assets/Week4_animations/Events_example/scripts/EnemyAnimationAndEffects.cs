using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationAndEffects : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private ParticleSystem particleSystem;

    [SerializeField] private Enemy enemy;



    private void Start()
    {
        particleSystem.Stop();


        //subscribing to enemy events
        enemy.onEnemyDie += Enemy_OnEnemyDie;


        enemy.onEnemyHit += Enemy_OnEnemyHit;
    }

    private void Enemy_OnEnemyDie(object sender, System.EventArgs e)
    {
        particleSystem.transform.position = this.transform.position;
        particleSystem.Play();
    }

    private void Enemy_OnEnemyHit(object sender, System.EventArgs e)
    {
        animator.SetBool("die", true);

    }
}
