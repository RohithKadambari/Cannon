using UnityEngine;

public class SaucerSpawner : MonoBehaviour
{
    public GameObject saucerPrefab;
    public float spawnInterval = 2f;
    public float xRange = 8f;
    public float ySpawn = 6f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnSaucer), 1f, spawnInterval);
    }

    void SpawnSaucer()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), ySpawn, 0f);
        Instantiate(saucerPrefab, spawnPos, Quaternion.identity);
    }
}
