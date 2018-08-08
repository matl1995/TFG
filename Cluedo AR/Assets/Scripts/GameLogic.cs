using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleARCore.Examples.AugmentedImage;

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

	public enum Hab {Emp, Off, Lib, Liv, Din, Dan, Gam, Gre, Lob, Kit};
	public enum Car {Emp, Red, Blu, Gree, Yel, Pur, Pin};
	public enum Arm {Emp, Gun, Kni, Can, Pip, Wre, Rop};

	public class Solution
	{
		public Hab solRoom;
		public Car solCharacter;
		public Arm solGun;

		public Hab room;
		public Car character;
		public Arm gun;

		public Solution()
		{
			solRoom=Hab.Dan;
			solCharacter=Car.Gree;
			solGun=Arm.Wre;

			room=Hab.Emp;
			character=Car.Emp;
			gun=Arm.Emp;
		}

		public void Restart()
		{
			room=Hab.Emp;
			character=Car.Emp;
			gun=Arm.Emp;
		}

		public void SetRoom(Hab value)
		{
			room=value;
		}

		public void SetCharacter(Car value)
		{
			character=value;
		}

		public void SetGun(Arm value)
		{
			gun=value;
		}
	}

	public class Dice
	{
		public int currentValue;

		public bool thrown;

		public bool finished;

		public Collider c;

		public Dice()
		{
			currentValue=0;
			thrown=false;
			finished=false;
		}

		public void Restart()
		{
			currentValue=0;
			thrown=false;
			finished=false;
		}

		public void SetCollider(Collider value)
		{
			c=value;
		}

		public void ActivateColl()
		{
			c.enabled=true;
		}

		public void DeactivateColl()
		{
			c.enabled=false;
		}
	}

	public class Room
	{
		public float PositionX;
		public float PositionZ;
		public int Elementos;

		public Hab[] Distances=new Hab[6];

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

	    public void Restart()
	    {
	    	Elementos=0;
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

	    public void Restart(Room room)
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

	    public float GetElementPositionX()
	    {
	    	return PositionX+Room.PositionX;
	    }

	    public float GetElementPositionZ()
	    {
	    	return PositionZ+Room.PositionZ;
	    }
	}

	public class Player
	{
		public float PositionX;
		public float PositionZ;
		public Room Room;
		public bool Notes;

		//This array contains one integer per each card, 0 means is not marked, 1 means marked, and 2 means hint
		public int[] Cards;

		public Player(Room room)
	    {
	    	Notes=false;
	        Room=room;

	        Cards=new int[21]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

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

	    public void Restart(Room room)
	    {
	    	Notes=false;
	        Room=room;

	        Cards=new int[21]{0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};

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

	static public bool turnFinished=false;

	static public Dice Dice1=new Dice();

	static public Solution sol=new Solution();

	static public Room Kitchen=new Room("Kitchen",3.3f,-3.5f,Hab.Din,Hab.Dan,Hab.Liv,Hab.Gre,Hab.Lob,Hab.Gam);
	static public Room Office=new Room("Office",-3.1f,3.7f,Hab.Lib,Hab.Lob,Hab.Liv,Hab.Gam,Hab.Din,Hab.Gre);
	static public Room LivingRoom=new Room("LivingRoom",3.1f,3.5f,Hab.Din,Hab.Lob,Hab.Off,Hab.Kit,Hab.Lib,Hab.Dan);
	static public Room GreenHouse=new Room("GreenHouse",-3.3f,-3.5f,Hab.Gam,Hab.Dan,Hab.Lib,Hab.Kit,Hab.Din,Hab.Off);
	static public Room DinningRoom=new Room("DinningRoom",3.1f,0f,Hab.Liv,Hab.Kit,Hab.Dan,Hab.Lob,Hab.Gre,Hab.Gam);
	static public Room Library=new Room("Library",-3.1f,1.3f,Hab.Gam,Hab.Off,Hab.Lob,Hab.Gre,Hab.Dan,Hab.Liv);
	static public Room Lobby=new Room("Lobby",0f,3.5f,Hab.Liv,Hab.Off,Hab.Lib,Hab.Din,Hab.Gam,Hab.Gre);
	static public Room GamesRoom=new Room("GamesRoom",-3.3f,-1.3f,Hab.Lib,Hab.Gre,Hab.Dan,Hab.Off,Hab.Kit,Hab.Lob);
	static public Room DanceRoom=new Room("DanceRoom",0f,-3.2f,Hab.Gre,Hab.Kit,Hab.Gam,Hab.Din,Hab.Lib,Hab.Liv);


	static public Element Red=new Element(Office);
	static public Element Blue=new Element(GamesRoom);
	static public Element Green=new Element(LivingRoom);
	static public Element Purple=new Element(GreenHouse);
	static public Element Pink=new Element(DinningRoom);
	static public Element Yellow=new Element(DanceRoom);

	static public Element Knife=new Element(Office);
	static public Element Gun=new Element(Kitchen);
	static public Element Pipeline=new Element(LivingRoom);
	static public Element Wrench=new Element(GreenHouse);
	static public Element Candle=new Element(Library);
	static public Element Rope=new Element(DanceRoom);

	static public Player Player1=new Player(Lobby);
	static public Player Player2=new Player(Lobby);

	public static void Restart()
	{
		Player1.Restart(Lobby);
		Player2.Restart(Lobby);
		turn=1;
		turnFinished=false;
		Dice1.Restart();
		sol.Restart();

		Kitchen.Restart();
		Office.Restart();
		LivingRoom.Restart();
		GreenHouse.Restart();
		DinningRoom.Restart();
		Library.Restart();
		Lobby.Restart();
		GamesRoom.Restart();
		DanceRoom.Restart();

		Red.Restart(Office);
		Blue.Restart(GamesRoom);
		Green.Restart(LivingRoom);
		Purple.Restart(GreenHouse);
		Pink.Restart(DinningRoom);
		Yellow.Restart(DanceRoom);

		Knife.Restart(Office);
		Gun.Restart(Kitchen);
		Pipeline.Restart(LivingRoom);
		Wrench.Restart(GreenHouse);
		Candle.Restart(Library);
		Rope.Restart(DanceRoom);
	}

	public virtual void Update()
	{
		if(sol.room!=Hab.Emp && sol.character!=Car.Emp && sol.gun!=Arm.Emp)
		{
			if(sol.room==sol.solRoom && sol.character==sol.solCharacter && sol.gun==sol.solGun)
			{
				SceneManager.LoadScene("EndScene");
			}
			else
			{
				AugmentedImageExampleController.borrar=true;
			}
		}
	}
}
