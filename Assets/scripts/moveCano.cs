using UnityEngine;

public class moveCano : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
