using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonsControler : MonoBehaviour {

	void OnMouseDown()
	{
		SceneManager.LoadScene("MenuScene");
		GameLogic.Restart();
	}

	public void Cambiar(string scene)
	{
		SceneManager.LoadScene(scene);
		GameLogic.Restart();
	}
}
