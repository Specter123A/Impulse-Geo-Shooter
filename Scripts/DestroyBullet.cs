using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    public int damage;
    //if the object is out of view, destroy it
    private void OnBecameInvisible ()
    {
        Destroy(gameObject);
    }

    //if the object collides with Enemy, destroy it
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag.Equals("Enemy"))
        {
        //The enemy can take 3 bullets
        //Each bullet increases the damage, and decreases the health by 3
        other.GetComponent<EnemyScript>().TakeDamage(damage);        //if health is less or equal to 0, it's killed
        VFXController.Instance.InstantiateBulletEffects(other.transform);  //Play particle system on each hit
        Destroy(gameObject); //after 3 hits, destroy
        }
    }
}

