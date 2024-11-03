using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public static ScoreManager Instance;

    private Player player;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        player = FindObjectOfType<Player>();
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + player.score;
    }

    public void AddPoints(int points)
    {
        player.AddScore(points);
    }
}
