using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    public GameObject[] fruits;
    private GameObject currentFruit;

    [SerializeField] Transform spawnOffset;

    bool isHolding = true;

    // Start is called before the first frame update
    void Start()
    {
        FruitGrapped();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 nextPos = transform.position;

        nextPos += new Vector3(x, y, 0) * Time.deltaTime * speed;
        nextPos.x = Mathf.Clamp(nextPos.x, -8f, 8f);
        nextPos.y = Mathf.Clamp(nextPos.y, 2.5f, 4.4f);
        transform.position = nextPos;

        // Drop Fruit Button
        if (Input.GetKeyDown(KeyCode.Space) && isHolding)
        {
            isHolding = false;
            currentFruit.transform.parent = null;
            currentFruit.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            currentFruit.GetComponent<Collider2D>().isTrigger = false;

            Invoke("FruitGrapped", 0.5f);
        }
    }

    private void FruitGrapped()
    {
        int randomIndex = Random.Range(0, fruits.Length);
        var fruitSpawn = fruits[randomIndex];
        currentFruit = Instantiate(fruitSpawn, spawnOffset.position, Quaternion.identity, spawnOffset);
        currentFruit.GetComponent<Collider2D>().isTrigger = true;
        isHolding = true;
    }
}
