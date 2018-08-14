using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.AugmentedImage;

public class TurnController : MonoBehaviour {
	
	void OnMouseDown()
	{
		GameLogic.turnFinished=true;
		AugmentedImageExampleController.scan=false;
		BoardVisualizer.scanwrong=false;
	}
}
