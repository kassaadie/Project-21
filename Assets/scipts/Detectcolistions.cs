using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detectcollsions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}       Privite void OnTriggerEnter(collider other)
    {
	     {
		    Destroy(gameObgect);
		    Destroy(other.gameObect);
	     }
