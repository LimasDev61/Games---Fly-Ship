using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public static ScoreScript instance;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    public int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        currentScoreTxt.text = $"Pontos: {score}";
        highScoreTxt.text = $"Recorde: {PlayerPrefs.GetInt("highScore", 0)}";
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreTxt.text = "Recorde: " + score.ToString();
        }
    }

    public void IncreaseScore()
    {
        score += 100;
        currentScoreTxt.text = "Pontos: " + score.ToString();
        UpdateHighScore();
    }
}
