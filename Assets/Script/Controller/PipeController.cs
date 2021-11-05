using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    float SpawnTimer;
    float SpawnRate = 3f;
    public GameObject Pipes;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameoverController.gameover)
        {
            SpawnTimer += Time.deltaTime;
            if (SpawnTimer >= SpawnRate)
            {
                SpawnTimer -= SpawnRate;
                Vector2 spawnPos = new Vector2(5f, Random.Range(-1f, 2f));
                Instantiate(Pipes, spawnPos, Quaternion.identity);
            }
        }
    }
}
