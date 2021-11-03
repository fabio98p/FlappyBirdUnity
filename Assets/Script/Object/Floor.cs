using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public Vector2 PosIniziale { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        PosIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5f)
        {
            transform.position = PosIniziale;
        }
        else
        {
            transform.position = new Vector2(transform.position.x - 2f * Time.deltaTime, transform.position.y);
        }
    }
}
