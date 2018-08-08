using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.AugmentedImage;

public class TurnEndController : MonoBehaviour {

	void OnMouseDown()
	{
		GameLogic.turnFinished=false;
		AugmentedImageExampleController.borrar=false;
		GameLogic.turn++;
		GameLogic.Dice1.ActivateColl();
	}
}
