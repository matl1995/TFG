using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesController : MonoBehaviour {

	void OnMouseDown()
	{
		if(GameLogic.turn%2==1)
		{
			GameLogic.Player1.Notes ^= true;
		}
		else
		{
			GameLogic.Player2.Notes ^= true;
		}
	}
}
