using UnityEngine;
using System.Collections;

public class hit_enemy: MonoBehaviour {
    
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
            Destroy(GameObject.Find("Player"));
            Application.LoadLevel("sample1");
        }
    }

}
