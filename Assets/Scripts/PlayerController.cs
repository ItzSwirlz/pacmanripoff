using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Sprite stationary;
    public Sprite spriteUp;
    public Sprite spriteDown;
    public Sprite spriteRight;
    public Sprite spriteLeft;
    
    public Rigidbody2D rb;
    public float velocity = 5;
    private float border = 11;

    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            rb.velocity = new Vector2(0, velocity);
            spriteRenderer.sprite = spriteUp;
        }
        if (Input.GetKeyDown("down"))
        {
            rb.velocity = new Vector2(0, -velocity);
            spriteRenderer.sprite = spriteDown;
        }
        if (Input.GetKeyDown("right"))
        {
            rb.velocity = new Vector2(velocity, 0);
            spriteRenderer.sprite = spriteRight;
        }
        if (Input.GetKeyDown("left"))
        {
            rb.velocity = new Vector2(-velocity, 0);
            spriteRenderer.sprite = spriteLeft;
        }

        if (transform.position.x > border)
        {
            transform.position = new Vector3(-border + 1, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -border)
        {
            transform.position = new Vector3(border - 1, transform.position.y, transform.position.z);
        }
    }
}
