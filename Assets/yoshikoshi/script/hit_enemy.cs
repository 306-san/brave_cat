using UnityEngine;
using System.Collections;

public class hit_enemy: MonoBehaviour {
    private AudioSource sound;
	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(GameObject.Find("Player"));
            sound.PlayOneShot(sound.clip);
        }
    }

}
