using UnityEngine;

public class canoRespawn : MonoBehaviour
{

    [SerializeField] private float maxTime = 3.5f;
    [SerializeField] private float heightRange = 2f;
    [SerializeField] private GameObject canos;

    private float timer;
    void Start()
    {

        criarCano();

    }

    void Update()
    {

        if (timer > maxTime)
        {
            criarCano();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void criarCano() {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject cano = Instantiate(canos, spawnPos, Quaternion.identity);
        Destroy(cano, 6f);
    }
}
