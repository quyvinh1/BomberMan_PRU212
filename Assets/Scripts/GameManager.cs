using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private GameObject[] players;
    [Header("GameObject")]
    public GameObject TimeCounterGo;

    private GameObject winner;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Start()
    {
        TimeCounterGo.GetComponent<TimeCounter>().StartTimeCounter();
        players = GameObject.FindGameObjectsWithTag("Player");
    }

    public void CheckWinState()
    {
        int aliveCount = 0;
        winner = null;

        for (int i = 0; i < players.Length; i++)
        {
            if (players[i].activeSelf)
            {
                aliveCount++;
                winner = players[i];
            }
        }

        if (aliveCount == 1 && winner != null)
        {
            Invoke(nameof(ShowWinScreen), 3f);
        }
    }

    private void ShowWinScreen()
    {
        PlayerInventory winnerInventory = winner.GetComponent<PlayerInventory>();
        if (winnerInventory != null)
        {
            PlayerPrefs.SetString("WinnerName", winnerInventory.PlayerName);
            PlayerPrefs.SetInt("WinnerScore", winnerInventory.Score);
            PlayerPrefs.SetInt("WinnerBombCount", winnerInventory.BombCount);
            PlayerPrefs.SetInt("WinnerBlastRadiusCount", winnerInventory.BlastRadiusCount);
            PlayerPrefs.SetInt("WinnerSpeedCount", winnerInventory.SpeedCount);
        }
        SceneManager.LoadScene("GameWin");
    }
}
