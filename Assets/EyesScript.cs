using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyesScript : MonoBehaviour
{
    bool flip = false;
    public SpriteRenderer sprite;
    void Update()
    {
        float val = Random.Range(0.0f, 500.0f);
        if (val <= 1.0f)
        {
            flip = !flip;
            sprite.flipX = flip;
        }
    }
}
