using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    public float tempoSpeed = 3f;
    public GameObject knifePrefab;

    // Repeat the method Spawn()
    void Start()
    {
        InvokeRepeating("Spawn", 0, tempoSpeed);
    }

    // Instatiate knifes with a random range on the y axis
    void Spawn()
    {
        Vector3 spawnPosition = transform.position;
        spawnPosition.y = Random.Range(0f, 4f);
        Instantiate(knifePrefab, spawnPosition, Quaternion.identity);
    }
}
