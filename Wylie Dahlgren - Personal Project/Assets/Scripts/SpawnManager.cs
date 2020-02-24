using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xSpawnRange = 15.0f;
    private float zSpawnRange = 15.0f;
    public GameObject enemy;
    public GameObject powerup;
    public GameObject obstacle;
    private float enemySpawnTime = 10.0f;
    private float powerupSpawnTime = 11.0f;
    private float obstacleSpawnTime = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, enemySpawnTime);
        InvokeRepeating("SpawnPowerup", 1, powerupSpawnTime);
        InvokeRepeating("SpawnObstacle", 1, obstacleSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, 0, randomZ);
        Instantiate(enemy, spawnPos, enemy.gameObject.transform.rotation);
    }

    void SpawnPowerup()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, 0, randomZ);
        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);
    }

    void SpawnObstacle()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zSpawnRange, zSpawnRange);
        Vector3 spawnPos = new Vector3(randomX, 0, randomZ);
        Instantiate(obstacle, spawnPos, obstacle.gameObject.transform.rotation);
    }
}
