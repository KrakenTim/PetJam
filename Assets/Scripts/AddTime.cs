using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public float TimeAdded = 10f;
    public PlayerHealth PlayerHP;
    
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Player")
        {
            PlayerHP.AddHealth(TimeAdded);
            Destroy(gameObject);
        }
    }
}
