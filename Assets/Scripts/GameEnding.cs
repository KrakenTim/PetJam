using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnding : MonoBehaviour
{
    public PlayerHealth PlayerTime;

    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    bool PlayerhasnoHealth;
    float m_Timer;

    
    void Update()
    {
        if (PlayerTime.currentHealth<1)
        {
            PlayerhasnoHealth = true;
        }
        if (PlayerhasnoHealth)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        m_Timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            SceneManager.LoadScene("MainMenu"); 
        }
    }
}