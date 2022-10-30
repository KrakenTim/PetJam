using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddTime : MonoBehaviour
{
    public float TimeAdded = 10f;
    public PlayerHealth PlayerHP;
    
    void Start()
    {
        PlayerHP = GameObject.Find("PlayerFischi").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerHP.AddHealth(TimeAdded);
            Destroy(gameObject);
        }
    }
}
