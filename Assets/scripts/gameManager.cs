using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class gameManager : MonoBehaviour
{
    public static gameManager instance;

    public ClassCharaters[] characters;
    public ClassCharaters currentCharacters;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        Time.timeScale = 1f;
        currentCharacters ??= characters[0];
    }

    private void Start()
    {
        if (characters.Length > 0)
        {
            currentCharacters = characters[0];
        }
    }

    public void SetCharacter(ClassCharaters character)
    {
        currentCharacters = character;
    }

    public void gameOverS()
    {
        SceneManager.LoadScene("GameOver");
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}