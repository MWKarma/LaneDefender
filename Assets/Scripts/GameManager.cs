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
    [SerializeField] private int _lives;
    [SerializeField] private int _score;
    [SerializeField] private static int _highscore;
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        _lives = 3;
        _score = 0;
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
    private void EnemiesKilledScore() //Once an enemy is killed you gain more score
    {
        //if ()
        //{
        //    _score += 100;
        //    _scoreText.text = "Score: " + _score.ToString();
        //}
    }

}
