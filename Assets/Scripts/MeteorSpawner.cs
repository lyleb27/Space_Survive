using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public float spawnRate = 1f; 

    private void Start()
    {
        StartCoroutine(SpawnMeteors());
    }

    private IEnumerator SpawnMeteors()
    {
        while (true)
        {
            Debug.Log("Spawning meteor at " + Time.time);
            Instantiate(meteorPrefab, GenerateRandomPosition(), Quaternion.identity);
            yield return new WaitForSeconds(1f / spawnRate);
        }
    }

    private Vector2 GenerateRandomPosition()
    {

        float x = Random.Range(-11f, 11f);
        float y = 5.75f;

        return new Vector2(x, y);
    }

}
