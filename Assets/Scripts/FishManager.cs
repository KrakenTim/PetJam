using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    public AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Coin")
            {
                audioSource.Play();
                Debug.Log("audiosource: " + audioSource.isPlaying);
            }
          
            
        }
}
