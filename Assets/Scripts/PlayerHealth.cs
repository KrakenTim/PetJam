using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health { get { return currentHealth; } }
    public float maxHealth = 10;

    [SerializeField] private float lifeDropRate = 1f;
    public float currentHealth;
    [SerializeField] private GameEnding ending;
    private bool hasEnded = false;

    void Start()
    {
        currentHealth = maxHealth;
        hasEnded = false;
    }

    // Update is called once per frame
    void Update()
    {
        TickLife();
    }

    public void TickLife()
    {
        currentHealth -= lifeDropRate * Time.deltaTime;
        UIHealthBar.instance.SetValue(currentHealth / (float)maxHealth);
        if (currentHealth <= 0)
        {
            hasEnded = true;
            if (hasEnded)
            {
                ending.EndLevel();
            }
        }
    }

    public void AddHealth(float healthAdded)
    {
        currentHealth += healthAdded;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

}
