﻿using UnityEngine;
using System.Collections;

public class Player_camera : MonoBehaviour {
  public GameObject player;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
	}
}
