using UnityEngine;

public class moveCano : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        ScoreScript.instance.IncreaseScore();
    }
}
