using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public PlatformSpawnerScript platformSpawnerScript;

    void Update()
    {
        if (playerScore >= 50)
        {
            platformSpawnerScript.spawnRate = 1.5f;
        }
        else if (playerScore >= 100)
        {
            platformSpawnerScript.spawnRate = 1f;
            platformSpawnerScript.heightOffset = 4f;
        }
    }

    public void addScore(int toAdd)
    {
        playerScore += toAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
