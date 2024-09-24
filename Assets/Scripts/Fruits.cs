using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Fruits : MonoBehaviour
{
    public int fruitIndex;

    private void Update()
    {
        // If the fruit leaves the screen
        if (transform.position.y <= -7)
        {
            FindAnyObjectByType<Score>().RemoveScore(1);
            Destroy(gameObject);
        }
    }
}
