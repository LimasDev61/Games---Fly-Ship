using UnityEngine;

public class canoRespawn : MonoBehaviour
{

    [SerializeField] private float maxTime;
    [SerializeField] private float heightRange;
    [SerializeField] private GameObject canos;

    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        criarCano();

    }

    // Update is called once per frame
    void Update()
    {

        if (timer > maxTime)
        {
            criarCano();
            timer = 0;
        }

        timer += Time.captureDeltaTime;
    }

    private void criarCano() {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject cano = Instantiate(canos, spawnPos, Quaternion.identity);
        Destroy(cano, 10f);
    }
}
