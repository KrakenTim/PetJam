using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health { get { return currentHealth; } }
    public float maxHealth = 10;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        currentHealth -= 1f * Time.deltaTime;
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
    }
}
