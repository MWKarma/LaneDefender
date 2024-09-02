using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _livesAI;
    [SerializeField] private GameObject _scoreAI;
    [SerializeField] private GameObject _highscoreAI;
    [SerializeField] private TextMeshProUGUI _livesText;
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;
    [SerializeField] private static int _lives;
    [SerializeField] private static int _score;
    [SerializeField] private static int _highscore;

    private void Start()
    {
        _lives = 3;
        _score = 0;
        _highscore = 0;
    }
    private void FixedUpdate()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 0)
        {
            _livesText.text = "Lives: " + _lives.ToString();
        }
        else
        {
            _livesText.text = " ";
        }
        if (index == 0)
        {
            _scoreText.text = "Score: " + _score.ToString();
        }
        else
        {
            _scoreText.text = " ";
        }
    }

}
