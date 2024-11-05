using UnityEngine;
using TMPro;

public class WinScreen : MonoBehaviour
{
    public TextMeshProUGUI winNameText;
    public TextMeshProUGUI winScoreText;
    public TextMeshProUGUI winBombText;
    public TextMeshProUGUI winBlastRadiusText;
    public TextMeshProUGUI winSpeedText;

    private void Start()
    {
        string winnerName = PlayerPrefs.GetString("WinnerName", "Winner");
        int score = PlayerPrefs.GetInt("WinnerScore", 0);
        int bombCount = PlayerPrefs.GetInt("WinnerBombCount", 0);
        int blastRadiusCount = PlayerPrefs.GetInt("WinnerBlastRadiusCount", 0);
        int speedCount = PlayerPrefs.GetInt("WinnerSpeedCount", 0);

        winNameText.text = winnerName;
        winScoreText.text = score.ToString("000000");
        winBombText.text = "" + bombCount;
        winBlastRadiusText.text = "" + blastRadiusCount;
        winSpeedText.text = "" + speedCount;
    }
}
