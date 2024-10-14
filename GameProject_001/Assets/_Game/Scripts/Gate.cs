using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public bool isPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Someone Win
            if (isPlayer) GameManager.instance.computerScore++;
            else GameManager.instance.playerScore++;

            GameManager.instance.UpdateScore();
            GameManager.instance.StartGame();
        }
    }
}
