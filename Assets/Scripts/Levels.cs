using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    [SerializeField] float delayInSeconds = 2f;
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("SelectScene");
        //FindObjectOfType<GameManagerController>().ResetGame();
    }
    public void LoadStage1()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void LoadStage2()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void LoadStage3()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void LoadStage4()
    {
        SceneManager.LoadScene("Stage4");
    }
    public void LoadGameOver()
    {
        //FindObjectOfType<ScoreDisplay>().SaveScore();
        StartCoroutine(WaitAndLoad());
    }


    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game Menu");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
