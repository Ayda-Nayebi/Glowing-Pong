using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRocketManager : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public float rocketSpeed;
    private Vector2 rocketDirection;

    private void Update()
    {
        RocketDirection();
    }

    private void FixedUpdate()
    {
        RocketVelocity();
    }

    private void RocketDirection()
    {
        float directionY = Input.GetAxisRaw("Vertical Right Player");
        rocketDirection = new Vector2(0, directionY).normalized;
    }

    private void RocketVelocity()
    {
        Rigidbody2D.velocity = rocketDirection * rocketSpeed;
    }
}
