using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private float _rangeX = 20f;
    
    private float _posZ = 20f;
    private int[] _posX = new[] { -19, 19 };
    
    void Start()
    {
        StartCoroutine(SpawnAnimal());
    }

    void Update()
    {
    }

    IEnumerator SpawnAnimal()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            int isTopSpawn = Random.Range(0, 2);

            Vector3 spawnPosition = (isTopSpawn == 1)
                ? new Vector3(Random.Range(-_rangeX, _rangeX), gameObject.transform.position.y, _posZ)
                : new Vector3(_posX[Random.Range(0, _posX.Length)], gameObject.transform.position.y, Random.Range(-1, 15));

            int rotationY = (isTopSpawn == 1) ? 180 : (spawnPosition.x > 0) ? 270 : 90;
            
            Quaternion rotation = Quaternion.Euler(0, rotationY, 0);

            GameObject animalPrefab = animalPrefabs[Random.Range(0, animalPrefabs.Length)];
            
            Instantiate(animalPrefab, spawnPosition, rotation);
            
        }
    }
}
