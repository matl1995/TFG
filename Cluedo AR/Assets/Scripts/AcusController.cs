using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore.Examples.AugmentedImage;

public class AcusController : MonoBehaviour {

	void OnMouseDown()
	{
		if(AugmentedImageExampleController.scan)
		{
			AugmentedImageExampleController.scan=false;
			AugmentedImageExampleController.borrar=true;
		}
		else
		{
			BoardVisualizer.scanwrong=false;
			AugmentedImageExampleController.scan=true;
		}
	}
}
