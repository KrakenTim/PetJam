using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TextMeshProUGUI text;

    public void AddScore(int ScoretoAdd)
    {
        score += ScoretoAdd;
        text.text = score.ToString();
    }
}
