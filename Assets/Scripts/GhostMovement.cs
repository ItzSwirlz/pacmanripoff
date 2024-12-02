using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GhostMovement : ScriptableObject
{
    public abstract void Move(Transform transform, SpriteRenderer spriteRenderer, Rigidbody2D rb, Sprite sprite1, Sprite sprite2, float velocity);
}
