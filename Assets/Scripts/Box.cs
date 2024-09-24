using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int boxIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var fruit = collision.GetComponent<Fruits>();
        // If the object to collided is a fruit
        if (fruit != null )
        {
            int score = 0;
            // If the fruit is in the right box
            if (fruit.fruitIndex == boxIndex)
            {
                Debug.Log("Good Fruit ! :)");

                score = 5;
                FindAnyObjectByType<Score>().AddScore(score);
            }
            // If the fruit is in the wrong box
            else if (fruit.fruitIndex != boxIndex)
            {
                Debug.Log("Bad Fruit ! :(");

                score = 1;
                FindAnyObjectByType<Score>().RemoveScore(score);
            }
        }
    }
}
