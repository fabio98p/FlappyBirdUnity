using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float SpawnTimer { get; set; }
    public float SpawnRate { get; set; }
    public GameObject Pipe { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnTimer += Time.deltaTime;

    }
}
