using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{

    private void Start()
    {
        DestroySFX();
    }
    private void DestroySFX()
    {
        Destroy(gameObject, 1);
    }
}