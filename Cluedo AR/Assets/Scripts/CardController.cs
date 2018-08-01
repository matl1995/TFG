using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour {

	public enum Card {Off, Lib, Liv, Din, Dan, Gam, Gre, Lob, Kit, Red, Yell, Pin, Pur, Gree, Blu, Wre, Pip, Can, Rop, Gun, Kni};

	public Card c;

	void OnMouseDown()
	{
		switch (c)
		{
		    case Card.Kni:
		        if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[0]==0)
						GameLogic.Player1.Cards[0]=1;
					else if(GameLogic.Player1.Cards[0]==1)
						GameLogic.Player1.Cards[0]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[0]==0)
						GameLogic.Player2.Cards[0]=1;
					else if(GameLogic.Player2.Cards[0]==1)
						GameLogic.Player2.Cards[0]=0;
				}
		        break;
		    case Card.Gun:
		        break;
		}
	}
}
