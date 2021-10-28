using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float SpawnTimer { get; set; }
    public float SpawnRate { get; set; }
    public GameObject Pipes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer -= SpawnRate;
        Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f));
        Instantiate(Pipes, spawnPos, Quaternion.identity);
    }
}
