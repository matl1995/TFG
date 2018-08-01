using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

	public class Tuple<T1, T2>
	{
	    public T1 First { get; private set; }
	    public T2 Second { get; private set; }
	    internal Tuple(T1 first, T2 second)
	    {
	        First = first;
	        Second = second;
	    }
	}

	public enum Hab {Off, Lib, Liv, Din, Dan, Gam, Gre, Lob, Kit};

	public class Dice
	{
		public int currentValue;

		public bool thrown;

		public bool finished;

		public Dice()
		{
			currentValue=0;
			thrown=false;
			finished=false;
		}

		public void SetValue(int value)
		{
			currentValue=value;
		}

		public int GetValue()
		{
			return currentValue;
		}

		public void SetThrown(bool value)
		{
			thrown=value;
		}

		public bool GetThrown()
		{
			return thrown;
		}

		public void Restart()
		{
			currentValue=0;
			thrown=false;
		}

		public void SetFinished(bool value)
		{
			finished=value;
		}

		public bool GetFinished()
		{
			return finished;
		}
	}

	public class Room
	{
		public float PositionX;
		public float PositionZ;
		public int Elementos;
		public string name;

		public Hab[] Distances=new Hab[8]; 

		public Room(string name,float positionx, float positionz, Hab h1, Hab h2, Hab h3, Hab h4, Hab h5, Hab h6)
	    {
	        PositionX=positionx;
	        PositionZ=positionz;
	        Distances[0]=h1;
	        Distances[1]=h2;
	        Distances[2]=h3;
	        Distances[3]=h4;
	        Distances[4]=h5;
	        Distances[5]=h6;
	        Elementos=0;
	    }

	    public string GetName()
	    {
	    	return name;
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
	        	PositionX=-0.5f;
	        	PositionZ=-0.2f;
	        }
	        else if(Room.Elementos==1)
	        {
	        	PositionX=0.5f;
	        	PositionZ=-0.2f;
	        }
	        else if(Room.Elementos==2)
	        {
	        	PositionX=-0.5f;
	        	PositionZ=0.7f;
	        }
	        else
	        {
	        	PositionX=0.5f;
	        	PositionZ=0.7f;
	        }

	        Room.Elementos++;
	    }

	    public void ChangeRoom(Room room)
	    {
	    	Room.Elementos--;

	    	Room=room;

	    	if(Room.Elementos==0)
	        {
	        	PositionX=-0.5f;
	        	PositionZ=-0.2f;
	        }
	        else if(Room.Elementos==1)
	        {
	        	PositionX=0.5f;
	        	PositionZ=-0.2f;
	        }
	        else if(Room.Elementos==2)
	        {
	        	PositionX=-0.5f;
	        	PositionZ=0.7f;
	        }
	        else
	        {
	        	PositionX=0.5f;
	        	PositionZ=0.7f;
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

	static public int turn=1;

	static public Dice Dice1=new Dice();

	static public Room Kitchen=new Room("Kitchen",3.1f,-3.5f,Hab.Din,Hab.Dan,Hab.Liv,Hab.Gre,Hab.Lob,Hab.Gam);

	static public Room Office=new Room("Office",-3.1f,3.5f,Hab.Lib,Hab.Lob,Hab.Liv,Hab.Gam,Hab.Din,Hab.Gre);

	static public Room LivingRoom=new Room("LivingRoom",3.1f,3.5f,Hab.Din,Hab.Lob,Hab.Off,Hab.Kit,Hab.Lib,Hab.Dan);

	static public Room GreenHouse=new Room("GreenHOuse",-3.1f,-3.5f,Hab.Gam,Hab.Dan,Hab.Lib,Hab.Kit,Hab.Din,Hab.Off);

	static public Room DinningRoom=new Room("DinningRoom",3.1f,0f,Hab.Liv,Hab.Kit,Hab.Dan,Hab.Lob,Hab.Gre,Hab.Gam);

	static public Room Library=new Room("Library",-3.1f,1.5f,Hab.Gam,Hab.Off,Hab.Lob,Hab.Gre,Hab.Dan,Hab.Liv);

	static public Room Lobby=new Room("Lobby",0f,3.5f,Hab.Liv,Hab.Off,Hab.Lib,Hab.Din,Hab.Gam,Hab.Gre);

	static public Room GamesRoom=new Room("GamesRoom",-3.1f,-1.2f,Hab.Lib,Hab.Gre,Hab.Dan,Hab.Off,Hab.Kit,Hab.Lob);

	static public Room DanceRoom=new Room("DanceRoom",0f,-3.5f,Hab.Gre,Hab.Kit,Hab.Gam,Hab.Din,Hab.Lib,Hab.Liv);


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
