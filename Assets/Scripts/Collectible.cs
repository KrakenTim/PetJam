using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    public int ScoreAmount = 1;
    public Score ScoreManager;
    public AudioSource audioSource;

    private void Awake()
    {
        ScoreManager = GameObject.Find("Score").GetComponent<Score>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            ScoreManager.AddScore(ScoreAmount);
            audioSource.Play();
            //TODO: Add VFX here
            Destroy(gameObject);
        }
      
        
    }
}
