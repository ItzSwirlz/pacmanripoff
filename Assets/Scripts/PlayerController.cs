using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class PlayerController : MonoBehaviour
{
    public Sprite stationary;
    public Sprite spriteUp;
    public Sprite spriteDown;
    public Sprite spriteRight;
    public Sprite spriteLeft;

    public Rigidbody2D rb;
    public float velocity = 3;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

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
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ghost"))
        {
            SceneManager.LoadScene("EndScreen");
        }
        else if (other.CompareTag("Pacgum"))
        {
            GameManager.Instance.AddScore(5);
            Destroy(other.gameObject);
        }
    }
}
