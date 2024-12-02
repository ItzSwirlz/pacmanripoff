using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour
{
    public Sprite stationary;
    public Sprite sprite1;
    public Sprite sprite2;

    public Rigidbody2D rb;
    public GhostMovement ghostMovement;
    public float velocity = 3;

    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Move the ghost up and down
        //MoveUpAndDown();
        ghostMovement.Move(transform, spriteRenderer, rb, sprite1, sprite2, velocity);
    }

    //private void MoveUpAndDown()
    //{
    //    if (movingUp)
    //    {
    //        rb.velocity = new Vector2(0, velocity);
    //        spriteRenderer.sprite = spriteUp;
    //    }
    //    else
    //    {
    //        rb.velocity = new Vector2(0, -velocity);
    //        spriteRenderer.sprite = spriteDown;
    //    }

    //    if (transform.position.y >= 3f)
    //    {
    //        movingUp = false;
    //    }
    //    else if (transform.position.y <= -4f)
    //    {
    //        movingUp = true;
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
