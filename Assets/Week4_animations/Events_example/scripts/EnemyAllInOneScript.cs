using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//<summary>
//simple example of using animation events to trigger actions
//</summary>

public class EnemyAllInOneScript : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] ParticleSystem particleSystem;
 
    private float timer;
    private bool isDead = false;

    [SerializeField] private float EnemyDieTime = 1f;
    
    private void Awake()
    {
        particleSystem.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool("die", true);
        isDead = true;
    }


    //without events
    // private void Update()
    // {
    //     if(isDead)
    //     {
    //         timer +=  Time.deltaTime;

    //         if(timer >= EnemyDieTime)
    //         {
    //             timer = 0;
    //             Destroy(gameObject);
    //         }
    //     }
    // }


    // //with events
    public void Die()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        particleSystem.transform.position = this.transform.position;
        particleSystem.Play();
    }
}
