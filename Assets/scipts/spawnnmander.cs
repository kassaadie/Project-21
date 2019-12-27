using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnmander : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
      InvokeRepeating("spawnRandomAnimal , startDelay, spawnInterval");  
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}    
     void SpawnRandomAnimal()
     {
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangX, spawnRangX), 0, spawnPosZ );

          Intantiate(animalPrefabs[animalIndex].transfrom.rotation);
      
     }
