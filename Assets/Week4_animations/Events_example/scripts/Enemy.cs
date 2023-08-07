using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


//<summary>
//using C# events to separate enemy logic and enemy animations
//</summary>


//order of animations for enemy death
//1. enemy get hit by player
//2. die animation is triggered
//3. when die animation is done, enemy gameobject gets destroyed
//4. then particle system appears at the destroyed enemy position
public class Enemy : MonoBehaviour
{

    public event EventHandler onEnemyHit;
    public event EventHandler onEnemyDie;

    private void OnTriggerEnter(Collider other)
    {
        onEnemyHit?.Invoke(this, EventArgs.Empty);
    }

    private void OnDestroy()
    {
        onEnemyDie?.Invoke(this, EventArgs.Empty);
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
