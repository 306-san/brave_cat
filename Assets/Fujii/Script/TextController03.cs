﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController03 : MonoBehaviour {

	public string[] scenarios;
	public Text uiText;
	int currentLine = 0;

	void Start()
	{
		TextUpdate();
	}

	void Update ()
	{
		if(currentLine < scenarios.Length && Input.GetMouseButtonDown(0) || currentLine < scenarios.Length && Input.GetKeyDown(KeyCode.Return))
		{
			TextUpdate();
		}else if(currentLine >= scenarios.Length && Input.GetMouseButtonDown(0) || currentLine >= scenarios.Length && Input.GetKeyDown(KeyCode.Return))
			Application.LoadLevel("Quest03");
	}

	void TextUpdate()
	{
		uiText.text = scenarios[currentLine];
		currentLine ++;
	}
}
