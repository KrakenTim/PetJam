using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int ScoreAmount = 1;
    
    void OnTriggerEnter(Collider other)
    {
      if(other.name=="Player")
        {
            other.GetComponent<Score>().score++;
            Destroy(gameObject);
        }
      
        
    }
}
