using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    float SpawnTimer;
    float SpawnRate = 15f;
    public GameObject Cloud;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 spawnPos = new Vector2(6f, Random.Range(1f, 4f));
        Instantiate(Cloud, spawnPos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;
        if (SpawnTimer >= SpawnRate)
        {
            SpawnTimer -= SpawnRate;
            Vector2 spawnPos = new Vector2(6f, Random.Range(1f, 4f));
            Instantiate(Cloud, spawnPos, Quaternion.identity);
        }
    }
}
