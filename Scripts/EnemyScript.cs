using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    
    public int health;

    //Basic AI for enemy to chase the player
    [HideInInspector] public Transform player;
    public float speed;


    // if the hralth is less than 0, it will be killed 
    public void TakeDamage( int damageAmount)
    {
        health -= damageAmount;
        if(health <=0 )
        { 
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
