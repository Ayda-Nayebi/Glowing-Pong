using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public BallController ballController;
    public ScoreManager scoreManager;
    public GameObject hitSFX;

    private void BallBounce(Collision2D collision)
    {
        Vector3 ballposion = transform.position;
        Vector3 rocketposin = collision.transform.position;

        float rocketHeight = collision.collider.bounds.size.y;
        float posistionX;


        if (collision.gameObject.name == "Left Rocket")
        {
            posistionX = 1;
        }

        else
        {
            posistionX = -1;
        }

        float positionY = (ballposion.y - rocketposin.y) / rocketHeight;

        ballController.IncreaseHitCounter();
        ballController.MoveBall(new Vector2(posistionX, positionY));
    }

  

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Left Rocket")
        {
            BallBounce(collision);
        }
        else if (collision.gameObject.name == "Right Rocket")
        {
            BallBounce(collision);
        }

        else if (collision.gameObject.name == "Right Border")
        {
            scoreManager.LeftRocketScore();
            ballController.LeftPlayerStart = false;
            StartCoroutine(ballController.Launch());
        }

        else if (collision.gameObject.name == "Left Border")
        {
            scoreManager.RightRocketScore();
            ballController.LeftPlayerStart = true;
            StartCoroutine(ballController.Launch());

        }

        Instantiate(hitSFX, transform.position, transform.rotation);
    }

}
