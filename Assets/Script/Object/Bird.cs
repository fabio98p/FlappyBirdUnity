using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D Rb { get; set; }
    public GameObject gameover;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameoverController.gameover)
        {
            Rb.velocity = new Vector2(0f, 6f);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameoverController.gameover = true;
        gameover.SetActive(true);
        button.SetActive(true);
    }
}
