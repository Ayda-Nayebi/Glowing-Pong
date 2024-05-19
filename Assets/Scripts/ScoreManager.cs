using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
   
    public int ScoreToReach;

    private int leftRocketScore = 0;
    private int rightRocketScore = 0;

    public Text leftRocketScoreText;
    public Text rightRocketScoreText;

    public void LeftRocketScore()
    {
        leftRocketScore++;
        leftRocketScoreText.text = leftRocketScore.ToString();
        ScoreCheck();
    }

    public void RightRocketScore()
    {
        rightRocketScore++;
        rightRocketScoreText.text = rightRocketScore.ToString();
        ScoreCheck();
    }

    public void ScoreCheck()
    {
        if (leftRocketScore == ScoreToReach)
        {
            SceneManager.LoadSceneAsync("Game Over");
        }

        else if (rightRocketScore == ScoreToReach)
        {
            SceneManager.LoadSceneAsync("Game Over");
        }
    }
}
