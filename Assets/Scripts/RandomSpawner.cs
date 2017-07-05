﻿using System.Collections;
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
    Vector3 randomPos = spawnPos.position;
    randomPos.x = Random.Range(-5f ,5f);

    GameObject newSpawn = Instantiate(spawnees[randomInt], randomPos, spawnPos.rotation)as GameObject;
    newSpawn.GetComponent<Rigidbody>().AddForce(transform.forward * 20f, ForceMode.VelocityChange);
  }
}
