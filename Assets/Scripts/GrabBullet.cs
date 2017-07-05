using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBullet : MonoBehaviour {

  void OnTriggerEnter (Collider c) {
    if (c.gameObject.tag == "Bullet") {
      Debug.Log("I'm a bullet!");
      c.transform.SetParent(transform);
      c.transform.GetComponent<Rigidbody>().isKinematic = true;
    }
  }
}
