﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{    
   public GameObject[] animePerfab;
    public int animaIndex;
    private float spawnRangeX = 20;
    private float spawnPosZ =20;
    // Start is called before the first frame update
    void Start()
    {


    

    // Update is called once per frame
    void Update() { 
    {
       if (Input.GetKeyDown(KeyCode.S)) { 
	  
		int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], new Vector3 (0,0,20)
	    animal prefabs[animalIndex].transform.rotation);

	    Instantiate(animalPrefabs[animalIndex]), spawnPos, animalPrefabs[animalIndex].transform.rotation);

      }
}
