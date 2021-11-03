using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 posIniziale;
    void Start()
    {
        posIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -5f)
        {
            transform.position = posIniziale;
        }
        else
        {
            transform.position = new Vector2(transform.position.x - 0.5f * Time.deltaTime, transform.position.y);
        }
    }
}
