using UnityEngine;
using System.Collections;

public class hit_wall : MonoBehaviour {

// Use this for initialization
void Start () {

}

// Update is called once per frame
void Update () {

}

void OnTriggerEnter2D(Collider2D collision)
{
         Debug.Log ("hit!!!");
        if (collision.CompareTag("enemy")) {
                Destroy(gameObject);
        }
}

}
