using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {
	
	void OnMouseDown()
	{
		GameLogic.turnFinished=true;
	}
}
