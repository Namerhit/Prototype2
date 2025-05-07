using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;
    private float _rangeX = 20;
    private float _posZ = 20;
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
            yield return new WaitForSeconds(1.5f);

            Vector3 spawnPosition = new Vector3(Random.Range(-_rangeX, _rangeX), gameObject.transform.position.y, _posZ);

            Instantiate(animalPrefabs[Random.Range(0, animalPrefabs.Length)], spawnPosition, gameObject.transform.rotation);
            
        }
    }
}
