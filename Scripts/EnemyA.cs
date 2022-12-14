using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyA : EnemyScript //to be able to use all functions of EnemyScript   //A simple extention 
{
    public float stopDistance;

    private void Update()
    {
        if(player !=null)
        {
            if(Vector2.Distance(transform.position, player.position) > stopDistance)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, speed*Time.deltaTime);
            }
        }
    }
}
