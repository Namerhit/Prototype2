using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {

            float spawnInterval = Random.Range(3, 6);

            yield return new WaitForSeconds(spawnInterval);

            SpawnRandomBall();
            Debug.Log(spawnInterval);
        }

        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int randomPrefab = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomPrefab], spawnPos, ballPrefabs[randomPrefab].transform.rotation);
    }

}
