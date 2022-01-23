using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private DetectCollision detectCollisionScript;
    public GameObject[] obstaclePrefab;
    void Start()
    {
        
        InvokeRepeating("SpawnObstacle", 1, 3);
        detectCollisionScript = GameObject.Find("Player").GetComponent<DetectCollision>();
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(2.8f, 26.6f, 18.86f);
        int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
        if (detectCollisionScript.isGameOver == false)
        Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
    }
}
