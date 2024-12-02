using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New HorizontalMovement", menuName = "HorizontalMovement")]
public class MoveHorizontal : GhostMovement
{
    private bool movingRight = true;
    public override void Move(Transform transform, SpriteRenderer spriteRenderer, Rigidbody2D rb, Sprite sprite1, Sprite sprite2, float velocity)
    {
        if (movingRight)
        {
            rb.velocity = new Vector2(velocity, 0);
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            rb.velocity = new Vector2(-velocity, 0);
            spriteRenderer.sprite = sprite2;
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
}
