using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour {

	public GameLogic.Hab r;

	void OnMouseDown()
	{
		switch (r)
	    {
	        case GameLogic.Hab.Kit:
	        	if(GameLogic.turn%2!=0)
	            	GameLogic.Player1.ChangeRoom(GameLogic.Kitchen);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.Kitchen);
	            break;
	        case GameLogic.Hab.Off:
	        	if(GameLogic.turn%2!=0)
	            	GameLogic.Player1.ChangeRoom(GameLogic.Office);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.Office);
	            break;
	        case GameLogic.Hab.Din:
	        	if(GameLogic.turn%2!=0)
	            	GameLogic.Player1.ChangeRoom(GameLogic.DinningRoom);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.DinningRoom);
	            break;
	        case GameLogic.Hab.Liv:
	        	if(GameLogic.turn%2!=0)
	            	GameLogic.Player1.ChangeRoom(GameLogic.LivingRoom);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.LivingRoom);
	            break;
	        case GameLogic.Hab.Lob:
	            if(GameLogic.turn%2!=0)
	                GameLogic.Player1.ChangeRoom(GameLogic.Lobby);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.Lobby);
	            break;
	        case GameLogic.Hab.Lib:
	            if(GameLogic.turn%2!=0)
	                GameLogic.Player1.ChangeRoom(GameLogic.Library);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.Library);
	            break;
	        case GameLogic.Hab.Gre:
	            if(GameLogic.turn%2!=0)
	                GameLogic.Player1.ChangeRoom(GameLogic.GreenHouse);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.GreenHouse);
	            break;
	        case GameLogic.Hab.Gam:
	            if(GameLogic.turn%2!=0)
	                GameLogic.Player1.ChangeRoom(GameLogic.GamesRoom);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.GamesRoom);
	            break;
	        case GameLogic.Hab.Dan:
	            if(GameLogic.turn%2!=0)
	                GameLogic.Player1.ChangeRoom(GameLogic.DanceRoom);
	            else
	            	GameLogic.Player2.ChangeRoom(GameLogic.DanceRoom);
	            break;
	    }

	    GameLogic.Dice1.SetThrown(false);
	}
}
