using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerRight : MonoBehaviour
{
    public GameObject[] animalPrifabRight;
    public GameObject[] animalPrifabLeft;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Left and Right Spawn
    private float spawnBigZ = 15f;
    private float spawnSmallZ = 9f;
    private float spawnX = 28f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSideAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomSideAnimal()
    {
        int animalIndex = Random.Range(0, animalPrifabRight.Length);
        Vector3 spawnSidePos = new Vector3(spawnX, 0, Random.Range(spawnBigZ, spawnSmallZ));
        Instantiate(animalPrifabRight[animalIndex], spawnSidePos, animalPrifabRight[animalIndex].transform.rotation);
    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrifabLeft.Length);
        Vector3 spawnSidePos = new Vector3(-spawnX, 0, Random.Range(spawnBigZ, spawnSmallZ));
        Instantiate(animalPrifabLeft[animalIndex], spawnSidePos, animalPrifabLeft[animalIndex].transform.rotation);
    }
}
