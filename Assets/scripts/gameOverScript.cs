using UnityEngine;
using TMPro;

public class gameOverScript : MonoBehaviour
{

    public TMP_Text pontos;

    public TMP_Text recorde;
    void Start()
    {
        pontos.text = PlayerPrefs.GetInt("score").ToString();
        recorde.text = PlayerPrefs.GetInt("highScore").ToString();
    }
}
