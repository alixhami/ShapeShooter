using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shapes {
  public class Bullet : MonoBehaviour {
    // Use this for initialization
    void Start () {
      Invoke("selfDestruct", 2f);
    }
    
    void OnCollisionEnter (Collision c) {
      Destroy(c.gameObject);
    }

    void selfDestruct () {
      Destroy(gameObject);
    }
  }  
}

