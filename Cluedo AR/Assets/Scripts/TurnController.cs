using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {
	
	void OnMouseDown()
	{
		GameLogic.turn++;
		GameLogic.Dice1.ActivateColl();
	}
}
