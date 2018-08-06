using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnController : MonoBehaviour {
	
	void OnMouseDown()
	{
		GameLogic.turnFinished=true;
	}
}
