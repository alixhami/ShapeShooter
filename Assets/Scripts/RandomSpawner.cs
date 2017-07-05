using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

	public GameObject[] spawnees;
  public Transform spawnPos;

  int randomInt;
	
	// Update is called once per frame
	void Update () {
		SpawnRandom();
	}

  void SpawnRandom () {
    randomInt = Random.Range(0, spawnees.Length);
    GameObject newSpawn = Instantiate(spawnees[randomInt], spawnPos.position, spawnPos.rotation)as GameObject;
    newSpawn.GetComponent<Rigidbody>().AddForce(transform.forward * 20f, ForceMode.VelocityChange);
  }
}
