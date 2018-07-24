using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public class Room
	{
		public float PositionX;
		public float PositionZ;
		public int Elementos;

		public Room(float positionx, float positionz)
	    {
	        PositionX=positionx;
	        PositionZ=positionz;
	    }
	}

	public class Element
	{
		public float PositionX;
		public float PositionZ;
		public Room Room;

		public Element(Room room)
	    {
	        Room=room;

	        if(Room.Elementos==0)
	        {
	        	PositionX=-0.7f;
	        	PositionZ=0f;
	        }
	        else if(Room.Elementos==1)
	        {
	        	PositionX=0f;
	        	PositionZ=0f;
	        }
	        else
	        {
	        	PositionX=0.7f;
	        	PositionZ=0f;
	        }

	        Room.Elementos++;
	    }

	    public float GetElementPositionX()
	    {
	    	return PositionX+Room.PositionX;
	    }

	    public float GetElementPositionZ()
	    {
	    	return PositionZ+Room.PositionZ;
	    }
	}

	public int turn=0;

	static public Room Kitchen=new Room(3.1f,-3.5f);
	static public Room Office=new Room(-3.1f,3.5f);
	static public Room LivingRoom=new Room(3.1f,3.5f);
	static public Room GreenHouse=new Room(-3.1f,-3.5f);
	static public Room DinningRoom=new Room(3.1f,0f);
	static public Room Library=new Room(-3.1f,1.5f);
	static public Room Lobby=new Room(0f,3.5f);
	static public Room GamesRoom=new Room(-3.1f,-1.2f);
	static public Room DanceRoom=new Room(0f,-3.5f);

	static public Element Red=new Element(Office);
	static public Element Blue=new Element(GamesRoom);
	static public Element Green=new Element(LivingRoom);
	static public Element Purple=new Element(GreenHouse);
	static public Element Pink=new Element(DinningRoom);
	static public Element Yellow=new Element(DanceRoom);

	static public Element Player1=new Element(Lobby);
	static public Element Player2=new Element(Lobby);

	static public Element Knife=new Element(Office);
	static public Element Gun=new Element(Kitchen);
	static public Element Pipeline=new Element(LivingRoom);
	static public Element Wrench=new Element(GreenHouse);
	static public Element Candle=new Element(Library);
	static public Element Rope=new Element(DanceRoom);
}
