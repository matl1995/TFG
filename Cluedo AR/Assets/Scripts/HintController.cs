using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.AugmentedImage;

public class HintController : MonoBehaviour {

	void OnMouseDown()
	{
		GameLogic.hint=false;
		BoardVisualizer.primeraVezHint=true;
	}
}
