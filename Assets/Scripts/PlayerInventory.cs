using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public TextMeshProUGUI scoreTextUI;
    public TextMeshProUGUI bombTextUI;
    public TextMeshProUGUI blastRadiusTextUI;
    public TextMeshProUGUI speedTextUI;

    private int score = 0;
    private int bombCount = 0;
    private int blastRadiusCount = 0;
    private int speedCount = 0;
    [SerializeField] private string playerName = "Player";
    public int Score => score;
    public int BombCount => bombCount;
    public int BlastRadiusCount => blastRadiusCount;
    public int SpeedCount => speedCount;
    public string PlayerName => playerName;
    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreTextUI();
    }
    public void AddBombCount(int amount)
    {
        bombCount += amount;
        UpdateBombTextUI();
    }

    public void AddBlastRadiusCount(int amount)
    {
        blastRadiusCount += amount;
        UpdateBlastRadiusTextUI();
    }

    public void AddSpeedCount(int amount)
    {
        speedCount += amount;
        UpdateSpeedTextUI();
    }
    private void UpdateScoreTextUI()
    {
        string scoreText = string.Format("{0:000000}", score);
        scoreTextUI.text = scoreText;
    }
    private void UpdateBombTextUI()
    {
        bombTextUI.text = bombCount.ToString();
    }

    private void UpdateBlastRadiusTextUI()
    {
        blastRadiusTextUI.text = blastRadiusCount.ToString();
    }

    private void UpdateSpeedTextUI()
    {
        speedTextUI.text = speedCount.ToString();
    }
}
