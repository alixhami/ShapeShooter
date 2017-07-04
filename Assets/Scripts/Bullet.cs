using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shapes {
  public class Bullet : MonoBehaviour {

    void Start () {
      
    }
    
    void OnCollisionEnter (Collision c) {
      transform.SetParent(c.gameObject.transform);
      GetComponent<Rigidbody>().isKinematic = true;
    }

    void selfDestruct () {
      Destroy(gameObject);
    }
  }  
}

