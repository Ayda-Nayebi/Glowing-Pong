using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    public static BackGroundMusic backGroundMusic;

    private void Awake()
    {
        PlayBackgroundMusic();
    }

    

    private void PlayBackgroundMusic()
    {
        if (backGroundMusic == null)
        {
            backGroundMusic = this;
            DontDestroyOnLoad(backGroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

   
}