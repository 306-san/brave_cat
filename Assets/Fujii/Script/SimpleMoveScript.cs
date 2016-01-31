using UnityEngine;
using System.Collections;

public class SimpleMoveScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
		
	// Update is called once per frame
	public const float SPEED = 10.0f;
	public int Enter = 0;
	public int Ans = 0;

	public int cnt = 0;

	void Update () {
		float axisHorizontal = Input.GetAxisRaw("Horizontal");
		float axisVertical = Input.GetAxisRaw ("Vertical");

		if (axisHorizontal == -1 || axisHorizontal == 1 ||
		    axisVertical == -1 || axisVertical == 1) {
			Vector3 move = new Vector3 (axisHorizontal, 0, axisVertical);
			GetComponent<Rigidbody> ().velocity = move * SPEED;
			cnt++;
		} else {

		}
	}
}