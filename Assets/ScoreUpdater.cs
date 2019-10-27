using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public static int score;
    public static GUIText scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = $"  Score: {score}";
    }

    public static void UpdateScore()
    {
        score++;
        scoreText.GetComponent<Text>().text = $"{score}";
        scoreText.text = $"  Score: {score}";
    }
}