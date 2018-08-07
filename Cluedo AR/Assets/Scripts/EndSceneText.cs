using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneText : MonoBehaviour {

	void Start () {
		Text textObject=GetComponent<UnityEngine.UI.Text>();
        if(GameLogic.turn%2!=0)
            textObject.text="¡Has ganado Jugador 1!";
        else
            textObject.text="¡Has ganado Jugador 2!";
	}
}
