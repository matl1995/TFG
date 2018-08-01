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
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[1]==0)
						GameLogic.Player1.Cards[1]=1;
					else if(GameLogic.Player1.Cards[1]==1)
						GameLogic.Player1.Cards[1]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[1]==0)
						GameLogic.Player2.Cards[1]=1;
					else if(GameLogic.Player2.Cards[1]==1)
						GameLogic.Player2.Cards[1]=0;
				}
		        break;
		    case Card.Can:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[2]==0)
						GameLogic.Player1.Cards[2]=1;
					else if(GameLogic.Player1.Cards[2]==1)
						GameLogic.Player1.Cards[2]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[2]==0)
						GameLogic.Player2.Cards[2]=1;
					else if(GameLogic.Player2.Cards[2]==1)
						GameLogic.Player2.Cards[2]=0;
				}
		        break;
		    case Card.Pip:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[3]==0)
						GameLogic.Player1.Cards[3]=1;
					else if(GameLogic.Player1.Cards[3]==1)
						GameLogic.Player1.Cards[3]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[3]==0)
						GameLogic.Player2.Cards[3]=1;
					else if(GameLogic.Player2.Cards[3]==1)
						GameLogic.Player2.Cards[3]=0;
				}
		        break;
		    case Card.Wre:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[4]==0)
						GameLogic.Player1.Cards[4]=1;
					else if(GameLogic.Player1.Cards[4]==1)
						GameLogic.Player1.Cards[4]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[4]==0)
						GameLogic.Player2.Cards[4]=1;
					else if(GameLogic.Player2.Cards[4]==1)
						GameLogic.Player2.Cards[4]=0;
				}
		        break;
		    case Card.Rop:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[5]==0)
						GameLogic.Player1.Cards[5]=1;
					else if(GameLogic.Player1.Cards[5]==1)
						GameLogic.Player1.Cards[5]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[5]==0)
						GameLogic.Player2.Cards[5]=1;
					else if(GameLogic.Player2.Cards[5]==1)
						GameLogic.Player2.Cards[5]=0;
				}
		        break;
		    case Card.Red:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[6]==0)
						GameLogic.Player1.Cards[6]=1;
					else if(GameLogic.Player1.Cards[6]==1)
						GameLogic.Player1.Cards[6]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[6]==0)
						GameLogic.Player2.Cards[6]=1;
					else if(GameLogic.Player2.Cards[6]==1)
						GameLogic.Player2.Cards[6]=0;
				}
		        break;
		    case Card.Blu:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[7]==0)
						GameLogic.Player1.Cards[7]=1;
					else if(GameLogic.Player1.Cards[7]==1)
						GameLogic.Player1.Cards[7]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[7]==0)
						GameLogic.Player2.Cards[7]=1;
					else if(GameLogic.Player2.Cards[7]==1)
						GameLogic.Player2.Cards[7]=0;
				}
		        break;
		    case Card.Gree:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[8]==0)
						GameLogic.Player1.Cards[8]=1;
					else if(GameLogic.Player1.Cards[8]==1)
						GameLogic.Player1.Cards[8]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[8]==0)
						GameLogic.Player2.Cards[8]=1;
					else if(GameLogic.Player2.Cards[8]==1)
						GameLogic.Player2.Cards[8]=0;
				}
		        break;
		    case Card.Yell:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[9]==0)
						GameLogic.Player1.Cards[9]=1;
					else if(GameLogic.Player1.Cards[9]==1)
						GameLogic.Player1.Cards[9]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[9]==0)
						GameLogic.Player2.Cards[9]=1;
					else if(GameLogic.Player2.Cards[9]==1)
						GameLogic.Player2.Cards[9]=0;
				}
		        break;
		    case Card.Pur:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[10]==0)
						GameLogic.Player1.Cards[10]=1;
					else if(GameLogic.Player1.Cards[10]==1)
						GameLogic.Player1.Cards[10]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[10]==0)
						GameLogic.Player2.Cards[10]=1;
					else if(GameLogic.Player2.Cards[10]==1)
						GameLogic.Player2.Cards[10]=0;
				}
		        break;
		    case Card.Pin:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[11]==0)
						GameLogic.Player1.Cards[11]=1;
					else if(GameLogic.Player1.Cards[11]==1)
						GameLogic.Player1.Cards[12]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[12]==0)
						GameLogic.Player2.Cards[12]=1;
					else if(GameLogic.Player2.Cards[12]==1)
						GameLogic.Player2.Cards[12]=0;
				}
		        break;
		    case Card.Lib:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[13]==0)
						GameLogic.Player1.Cards[13]=1;
					else if(GameLogic.Player1.Cards[13]==1)
						GameLogic.Player1.Cards[13]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[13]==0)
						GameLogic.Player2.Cards[13]=1;
					else if(GameLogic.Player2.Cards[13]==1)
						GameLogic.Player2.Cards[13]=0;
				}
		        break;
		    case Card.Kit:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[14]==0)
						GameLogic.Player1.Cards[14]=1;
					else if(GameLogic.Player1.Cards[14]==1)
						GameLogic.Player1.Cards[14]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[14]==0)
						GameLogic.Player2.Cards[14]=1;
					else if(GameLogic.Player2.Cards[14]==1)
						GameLogic.Player2.Cards[14]=0;
				}
		        break;
		    case Card.Din:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[15]==0)
						GameLogic.Player1.Cards[15]=1;
					else if(GameLogic.Player1.Cards[15]==1)
						GameLogic.Player1.Cards[15]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[15]==0)
						GameLogic.Player2.Cards[15]=1;
					else if(GameLogic.Player2.Cards[15]==1)
						GameLogic.Player2.Cards[15]=0;
				}
		        break;
		    case Card.Off:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[16]==0)
						GameLogic.Player1.Cards[16]=1;
					else if(GameLogic.Player1.Cards[16]==1)
						GameLogic.Player1.Cards[16]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[16]==0)
						GameLogic.Player2.Cards[16]=1;
					else if(GameLogic.Player2.Cards[16]==1)
						GameLogic.Player2.Cards[16]=0;
				}
		        break;
		    case Card.Gre:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[17]==0)
						GameLogic.Player1.Cards[17]=1;
					else if(GameLogic.Player1.Cards[17]==1)
						GameLogic.Player1.Cards[17]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[17]==0)
						GameLogic.Player2.Cards[17]=1;
					else if(GameLogic.Player2.Cards[17]==1)
						GameLogic.Player2.Cards[17]=0;
				}
		        break;
		    case Card.Dan:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[18]==0)
						GameLogic.Player1.Cards[18]=1;
					else if(GameLogic.Player1.Cards[18]==1)
						GameLogic.Player1.Cards[18]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[18]==0)
						GameLogic.Player2.Cards[18]=1;
					else if(GameLogic.Player2.Cards[18]==1)
						GameLogic.Player2.Cards[18]=0;
				}
		        break;
		    case Card.Gam:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[19]==0)
						GameLogic.Player1.Cards[19]=1;
					else if(GameLogic.Player1.Cards[19]==1)
						GameLogic.Player1.Cards[19]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[19]==0)
						GameLogic.Player2.Cards[19]=1;
					else if(GameLogic.Player2.Cards[19]==1)
						GameLogic.Player2.Cards[19]=0;
				}
		        break;
		    case Card.Liv:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[20]==0)
						GameLogic.Player1.Cards[20]=1;
					else if(GameLogic.Player1.Cards[20]==1)
						GameLogic.Player1.Cards[20]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[20]==0)
						GameLogic.Player2.Cards[20]=1;
					else if(GameLogic.Player2.Cards[20]==1)
						GameLogic.Player2.Cards[20]=0;
				}
		        break;
		    case Card.Lob:
		    	if(GameLogic.turn%2==1)
				{
					if(GameLogic.Player1.Cards[21]==0)
						GameLogic.Player1.Cards[21]=1;
					else if(GameLogic.Player1.Cards[21]==1)
						GameLogic.Player1.Cards[21]=0;
				}
				else
				{
					if(GameLogic.Player2.Cards[21]==0)
						GameLogic.Player2.Cards[21]=1;
					else if(GameLogic.Player2.Cards[21]==1)
						GameLogic.Player2.Cards[21]=0;
				}
		        break;
		}
	}
}
