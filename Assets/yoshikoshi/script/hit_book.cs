using UnityEngine;
using System.Collections;

public class hit_book : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Application.LoadLevel("Story01");
        }
    }
}
