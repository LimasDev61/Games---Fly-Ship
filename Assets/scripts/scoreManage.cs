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
        currentScoreTxt.text = score.ToString();
        highScoreTxt.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            highScoreTxt.text = score.ToString();
        }
    }

    public void IncreaseScore()
    {
        score++;
        currentScoreTxt.text = score.ToString();
        UpdateHighScore();
    }
}
