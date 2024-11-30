using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost2Controller : MonoBehaviour
{
    public Sprite stationary;
    public Sprite spriteLeft;
    public Sprite spriteRight;

    public Rigidbody2D rb;
    public float velocity = 3;

    private SpriteRenderer spriteRenderer;
    private bool movingRight = true;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        MoveLeftAndRight();
    }

    private void MoveLeftAndRight()
    {
        if (movingRight)
        {
            rb.velocity = new Vector2(velocity, 0);
            spriteRenderer.sprite = spriteRight;
        }
        else
        {
            rb.velocity = new Vector2(-velocity, 0);
            spriteRenderer.sprite = spriteLeft;
        }

        if (transform.position.x >= -5.5f)
        {
            movingRight = false;
        }
        else if (transform.position.x <= -9f)
        {
            movingRight = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
