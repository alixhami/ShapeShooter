﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Shapes {
  public class Shooter : MonoBehaviour {

    public Transform crosshair;
    public GameObject projectile;
    private SteamVR_TrackedController controller;

    void Start () {
      controller = GetComponent<SteamVR_TrackedController> ();
      controller.TriggerClicked += Shoot;
    }

    void Shoot (object sender, ClickedEventArgs e) {
      if (projectile) {
        GameObject newProjectile = Instantiate(projectile, crosshair.gameObject.transform.position, transform.rotation)as GameObject;
        newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 20f, ForceMode.VelocityChange);
      }
    }
  }  
}

