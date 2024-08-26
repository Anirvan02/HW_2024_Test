using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static int scoreCount;

    void Start()
    {
        scoreCount = -1;
        UpdateScoreText();
    }

    void Update()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + scoreCount;
    }

    public void AddScore(int points)
    {
        scoreCount += points;
        UpdateScoreText();
    }
}
