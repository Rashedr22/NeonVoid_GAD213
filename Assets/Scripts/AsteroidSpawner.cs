using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnRate = 2f;
    public float spawnRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnAsteroid", 1f, spawnRate);
    }

    void SpawnAsteroid()
    {
        float randomX = Random.Range(-spawnRange, spawnRange);

        int randomIndex = Random.Range(0, asteroidPrefabs.Length);

        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);

        Instantiate(asteroidPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
