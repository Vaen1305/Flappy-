using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTubo1 : MonoBehaviour
{
    public GameObject pipePairPrefab;
    public float spawnRate = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Instantiate(pipePairPrefab, new Vector3(10, Random.Range(-8.11f, -4.15f), 0), Quaternion.identity);
            timer = 0f;
        }
    }
}
