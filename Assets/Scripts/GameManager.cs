using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameUI gameUI;
    public int scorePlayer1, scorePlayer2;
    public int maxScore = 3;
    public Action onReset;

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            gameUI.onStartGame += OnStartGame;
        }
    }

    private void OnDestroy()
    {
        gameUI.onStartGame -= OnStartGame;
    }
    public void OnScoreZoneReached(int id)
    {

        if (id == 1)
        {
            scorePlayer2++;
        }
        if (id == 2)
        {
            scorePlayer1++;
        }
        gameUI.UpdateScores(scorePlayer1, scorePlayer2);
        id = id == 1 ? 2 : 1;
        gameUI.HighlightScore(id);
        CheckWin();
    }
    private void CheckWin()
    {
        int winnerId = scorePlayer1 == maxScore ? 1 : scorePlayer2 == maxScore ? 2 : 0;
        if (winnerId != 0)
        {
            gameUI.OnGameEnds(winnerId);
            Time.timeScale = 0f;

        }
        else
        {
            onReset?.Invoke();
        }
    }
    private void OnStartGame()
    {
        Time.timeScale = 1f;
        scorePlayer1 = 0;
        scorePlayer2 = 0;
        gameUI.UpdateScores(scorePlayer1, scorePlayer2);
    }
}
