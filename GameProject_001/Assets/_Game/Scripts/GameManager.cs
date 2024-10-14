using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public Transform player;
    public Transform computer;
    public Ball ball;

    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;

    public int playerScore = 0;
    public int computerScore = 0;

    public GameObject winFrame;
    public GameObject loseFrame;
    public GameObject playBtn;

    public bool allowControl = false;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void PlayGame()
    {
        playBtn.SetActive(false);

        allowControl = true;
        StartGame();
    }

    public void StartGame()
    {
        player.position = new Vector2(0, -4.4f);
        computer.position = new Vector2(0, 4.4f);
        ball.transform.position = Vector2.zero;
        ball.rdBody.velocity = Vector2.zero;

        if (playerScore >= 5) winFrame.SetActive(true);
        else if (computerScore >= 5) loseFrame.SetActive(true);
        else ball.Launch();
    }

    public void UpdateScore()
    {
        playerScoreText.text = playerScore.ToString();
        computerScoreText.text = computerScore.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
