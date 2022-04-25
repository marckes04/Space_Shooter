using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem instance;

    public Text scoreText;
    public Text HighScoreText;

    public float score;
    public float highscore;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("Highscore");

    }

    void Update()
    {
        scoreText.text = score.ToString();
        HighScoreText.text = highscore.ToString();
        HighScoreText.text = highscore.ToString();

        if (highscore < score)
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }
    }


    public void AddPoint()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
