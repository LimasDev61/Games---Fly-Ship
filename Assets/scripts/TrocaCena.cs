using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{

    public void TrocaCenas(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}
