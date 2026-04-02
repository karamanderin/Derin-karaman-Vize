using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount = 1)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
    public int GetHighScore()
    {
        int highScore = Mathf.Max(score, PlayerPrefs.GetInt("HighScore", 0));
        PlayerPrefs.SetInt("HighScore", highScore);
        return highScore;
    }
    public int GetScore()
    {
        return score;
    }
}
