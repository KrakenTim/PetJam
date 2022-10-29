using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int ScoreAmount = 1;
    public Score ScoreManager;

    private void Awake()
    {
        ScoreManager = GameObject.Find("Score").GetComponent<Score>();
        Debug.Log(ScoreManager);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if(other.name=="Player")
        {
            ScoreManager.AddScore(ScoreAmount);
            Destroy(gameObject);
        }
      
        
    }
}
