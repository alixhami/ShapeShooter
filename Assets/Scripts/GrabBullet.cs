using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBullet : MonoBehaviour {

  void OnCollisionEnter (Collision c) {
    if (c.gameObject.tag == "Bullet") {
      c.transform.SetParent(transform);
      c.transform.GetComponent<Rigidbody>().isKinematic = true;
    }
  }
}
