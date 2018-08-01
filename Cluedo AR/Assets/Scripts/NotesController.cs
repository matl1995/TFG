using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesController : MonoBehaviour {

	void OnMouseDown()
	{
		if(GameLogic.turn%2!=0)
		{
			if(GameLogic.Player1.Notes==true)
				GameLogic.Player1.Notes=false;
			else
				GameLogic.Player1.Notes=true;
		}
		else
		{
			if(GameLogic.Player2.Notes==true)
				GameLogic.Player2.Notes=false;
			else
				GameLogic.Player2.Notes=true;
		}
	}
}
