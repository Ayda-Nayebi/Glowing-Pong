using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallController : MonoBehaviour
{
    public float startSpeed;
    public float increaseSpeed;
    public float maxSpeed;

    private int hitCounter;

    public Rigidbody2D Rigidbody;

    public bool LeftPlayerStart = true;

    private void Start()
    {
        StartCoroutine(Launch());
    }


    public IEnumerator Launch()
    {
        RestartBall();

        hitCounter = 0;
        yield return new WaitForSeconds(1);

        SetBallPosition();
    }

    private void RestartBall()
    {
        Rigidbody.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);

    }

    private void SetBallPosition()
    {
        if (LeftPlayerStart == true)
        {
            MoveBall(new Vector2(-1, 0));

        }

        else
        {
            MoveBall(new Vector2(1, 0));
        }
    }

    public void MoveBall(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed + hitCounter * increaseSpeed;
        Rigidbody.velocity = direction * ballSpeed;
    }

    public void IncreaseHitCounter()
    {
        if (hitCounter* increaseSpeed < maxSpeed)
        {
            hitCounter++;
        }
    }
}

