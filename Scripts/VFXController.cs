using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXController : MonoBehaviour
{
    public static VFXController Instance;
    public GameObject bulletEffects;
    
    private void Awake()
    {
         if(Instance == null)
        {
            Instance=this;
        }
    }
   


    public void InstantiateBulletEffects(Transform other)
    {
        var temp = Instantiate(bulletEffects, other.transform.position, Quaternion.identity);
        Destroy(temp, 0.5f);
    }

   

     
}
