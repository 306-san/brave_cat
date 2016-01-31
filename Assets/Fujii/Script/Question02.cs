using UnityEngine;
using System.Collections;

public class Question02: MonoBehaviour {

	public int Enter = 0;
	public int Ans = 0;
	public int Size = 2;
	public float Time = 1.3f;

	private bool isQuestion = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		GameObject player2 = GameObject.Find("Player");
		Vector2 forward = player2.transform.position - transform.position;


		if (forward.x < Size && forward.x > -Size && forward.y < Size && forward.y > -Size) {
			isQuestion = true;
			if (Input.GetKeyDown(KeyCode.Return)) {
				Enter++;
			}
		} else {
			isQuestion = false;
		}

		if (Enter == 1 && Ans == 0) {
			if (text == "またたび" || text == "マタタビ") {
				Ans = 2;
			} else {
				Ans = 1;
			}
		}
	}

	private string text = "";
	private string But = "残念" +
		"回答が間違っています。やり直してください。";
	private string Yes = "正解です。" +
		"次のステージへ移動します。";

	void OnGUI()
	{
		if (isQuestion) {
			Rect rect1 = new Rect (10, 10, 400, 30);
			if(Ans==0){
				text = GUI.PasswordField (rect1, text, '●', 24);
			}

			Rect rect2 = new Rect (10, 20, 400, 30);
			if (Enter == 1 && Ans != 2) {
				GUI.Label (rect2, text);
			}
			if (Ans == 1) {
				Rect rect3 = new Rect (10, 50, 400, 30);
				GUI.Label (rect3, But);
				StartCoroutine ("WaitForAns");
			}
			if (Ans == 2) {
				Rect rect4 = new Rect (10, 50, 400, 30);
				GUI.Label (rect4, Yes);
				StartCoroutine ("WaitForYes");
			}
		}
	}
	IEnumerator WaitForAns()
	{
		yield return new WaitForSeconds(Time);
		Ans = 0;
		Enter = 0;
	}
	IEnumerator WaitForYes()
	{
		yield return new WaitForSeconds(Time);
		Application.LoadLevel ("Story03");
		Ans = 0;
		Enter = 0;
	}
}
