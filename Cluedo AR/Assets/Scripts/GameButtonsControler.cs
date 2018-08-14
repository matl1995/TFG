using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleARCore.Examples.AugmentedImage;

public class GameButtonsControler : MonoBehaviour {

	void OnMouseDown()
	{
		SceneManager.LoadScene("MenuScene");
		GameLogic.Restart();
		AugmentedImageExampleController.scan=false;
	}

	public void Cambiar(string scene)
	{
		SceneManager.LoadScene(scene);
		GameLogic.Restart();
		AugmentedImageExampleController.scan=false;
	}
}
