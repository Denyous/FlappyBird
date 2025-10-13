using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject gameoverScreen;
    [SerializeField] PlayerMovement player;
    private int score = 0;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        PauseGame();

    }
    public void PlayGame()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameoverScreen.SetActive(false);

        player.enabled = true;

        PipesMove[] pipes = FindObjectsOfType<PipesMove>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }

        Time.timeScale = 1;

    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }


    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

    }

    public void GameOver()
    {

        PauseGame();
        gameoverScreen?.SetActive(true);

    }


}
