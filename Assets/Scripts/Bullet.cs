using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour {
  
  void OnCollisionEnter (Collision c) {
    transform.SetParent(c.gameObject.transform);
    GetComponent<Rigidbody>().isKinematic = true;
  }

  void selfDestruct () {
    Destroy(gameObject);
  }
}

