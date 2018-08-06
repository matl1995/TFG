using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnEndController : MonoBehaviour {

	void OnMouseDown()
	{
		GameLogic.turn++;
		GameLogic.Dice1.ActivateColl();
		GameLogic.turnFinished=false;
	}
}
