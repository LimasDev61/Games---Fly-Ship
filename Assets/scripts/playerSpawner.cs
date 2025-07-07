using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    void Start()
    {
        Instantiate(gameManager.instance.currentCharacters.prefab, transform.position, Quaternion.identity);
    }
}
