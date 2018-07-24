using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public class Room
	{
		public float PositionX;
		public float PositionZ;

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

		public Element(float positionx,  float positionz, Room room)
	    {
	        PositionX=room.PositionX+positionx;
	        PositionZ=room.PositionZ+positionz;
	        Room=room;
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

	static public Element Red=new Element(-0.3f,-0.3f,Office);
}
