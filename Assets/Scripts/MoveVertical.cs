using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New VerticalMovement", menuName = "VerticalMovement")]
public class MoveVertical : GhostMovement
{
    private bool movingUp = true;
    public override void Move(Transform transform, SpriteRenderer spriteRenderer, Rigidbody2D rb, Sprite sprite1, Sprite sprite2, float velocity)
    {
        if (movingUp)
        {
            rb.velocity = new Vector2(0, velocity);
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            rb.velocity = new Vector2(0, -velocity);
            spriteRenderer.sprite = sprite2;
        }

        if (transform.position.y >= 3f)
        {
            movingUp = false;
        }
        else if (transform.position.y <= -4f)
        {
            movingUp = true;
        }
    }
}
