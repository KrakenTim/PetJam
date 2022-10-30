using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{

    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    [SerializeField] private float delay = 1.5f;
    public Image exitBackgroundImageCanvasGroup;

    float m_Timer;

    void Awake()
    {
        exitBackgroundImageCanvasGroup.enabled = false;
    }

    public void EndLevel()
    {
        exitBackgroundImageCanvasGroup.enabled = true;
        m_Timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.CrossFadeAlpha(m_Timer, displayImageDuration, true);
        //= m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            StartCoroutine("DelaySceneTransition");
        }
    }

    private IEnumerator DelaySceneTransition()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
        yield return null;
    }
}