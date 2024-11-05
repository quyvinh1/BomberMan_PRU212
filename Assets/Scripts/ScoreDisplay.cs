using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    TextMeshProUGUI scoreTextUI;

    int score = 0;

    public int Score
    {
        get
        {
            return this.score;
        }
        set
        {
            this.score = value;
        }
    }
    void Start()
    {
        scoreTextUI = GetComponent<TextMeshProUGUI>();
    }

    void UpdateScoreTextUI()
    {
        string scoreText = string.Format("{0:000000}", score);
        scoreTextUI.text = scoreText;
    }

    public void AddToScore(int pointsToAdd)
    {
        score += pointsToAdd;
        UpdateScoreTextUI();
    }
    //public void SubtractToScore(int pointsToAdd)
    //{
    //    score -= pointsToAdd;
    //    UpdateScoreTextUI();
    //}
    public void SaveScore()
    {
        PlayerPrefs.SetInt("FinalScore", score);
        PlayerPrefs.Save();
    }
}
