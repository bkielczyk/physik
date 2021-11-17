using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareScript : MonoBehaviour
{
    public Rigidbody2D body;
    private void FixedUpdate()
    {
        float val = Random.Range(-1000.0f, 100000.0f);
        if (val <= 1000.0f)
        {
            float impulse = val * Mathf.Deg2Rad * body.inertia;
            body.AddTorque(impulse, ForceMode2D.Impulse);
        }
    }
}
