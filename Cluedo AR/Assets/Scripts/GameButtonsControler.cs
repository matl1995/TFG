using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameButtonsControler : MonoBehaviour {

	private Button Cube;

	// Use this for initialization
	void Start () {

		Cube=GameObject.Find("PanelSuperior").GetComponent<Button>();

		Cube.onClick.AddListener(delegate {
                ButtonSelected(Cube);
            });
	}

	void ButtonSelected(Button selected)
	{
		SceneManager.LoadScene("MenuScene");
	}
}