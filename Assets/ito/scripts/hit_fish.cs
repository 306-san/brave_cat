using UnityEngine;
using System.Collections;

public class hit_fish : MonoBehaviour {
  PlayerControlScript playerControlScript;
  public GameObject Player;
	// Use this for initialization
	void Start () {
      Player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update () {

	}
  void OnTriggerEnter2D(Collider2D collision)
  {
          if (collision.CompareTag("Player")) {
            Player.SendMessage("recovery_hungry");
            Destroy(gameObject);
          }
  }
}
