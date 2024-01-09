using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // assign your meteor prefab in the inspector
    public float spawnRate = 5f; // meteors per second

    private void Start()
    {
        StartCoroutine(SpawnMeteors());
    }

    private IEnumerator SpawnMeteors()
    {
        while (true)
        {
            Instantiate(meteorPrefab, GenerateRandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(1f / spawnRate);
        }
    }

    private Vector2 GenerateRandomPosition()
    {
        // generate a random position within a certain radius
        // adjust this to fit your game
        float x = Random.Range(-11f, 11f);
        float y = 5.75f;

        return new Vector2(x, y);
    }
}
