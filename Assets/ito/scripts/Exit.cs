﻿using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {
        if (Input.GetButtonDown("Fire2")){
                Application.Quit();

              }
        if(Input.GetKeyDown(KeyCode.Return)){
          Application.LoadLevel("Title");
        }
}
}
