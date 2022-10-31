using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void SettingsGame()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("CreditsScene");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
