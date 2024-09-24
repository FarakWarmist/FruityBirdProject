using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public float speed = 10f;
    bool mirror = false;

    // Flip the sprite according to their spawn
    private void Start()
    {
        if (transform.position.x >= 10f)
        {
            mirror = false;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            mirror = true;
        }
    }
    void Update()
    {
        // Defined the direction according to their spawn
        if (!mirror)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }

        // Object is destroyed if too far
        if (transform.position.x >= 14f || transform.position.x <= -14f)
        {
            Destroy(gameObject);
        }
        
    }
}
