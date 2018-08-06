namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;

    /// <summary>
    /// Uses 4 frame corner objects to visualize an AugmentedImage.
    /// </summary>
    public class BoardVisualizer : AugmentedImageVisualizer
    {
        public GameObject Scene;
        public GameObject Dice;

        /*************************************************CARTAS HABITACIONES**************************************************/
        public GameObject[] cardsNotes=new GameObject[21];
        public Sprite[] cardsNotesSpriteNormal=new Sprite[21];
        public Sprite[] cardsNotesSpriteCross=new Sprite[21];

        //Seleccion habitacion

        public GameObject TextRooms;
        public GameObject Kitchen;
        public GameObject LivingRoom;
        public GameObject Office;
        public GameObject GreenHouse;
        public GameObject DinningRoom;
        public GameObject Library;
        public GameObject Lobby;
        public GameObject DanceRoom;
        public GameObject GamesRoom;


        //Personajes

        public GameObject CharacterBlue;
        public GameObject CharacterRed;
        public GameObject CharacterGreen;
        public GameObject CharacterYellow;
        public GameObject CharacterPurple;
        public GameObject CharacterPink;

        //Armas

        public GameObject Knife;
        public GameObject Candle;
        public GameObject Rope;
        public GameObject Gun;
        public GameObject Wrench;
        public GameObject Pipeline;

        //Jugadores

        public GameObject Player1;
        public GameObject Player2;
        public GameObject Player3;
        public GameObject Player4;
        public GameObject Player5;
        public GameObject Player6;
        public GameObject PlayerDef1=null;
        public GameObject PlayerDef2=null;

        /*************************************************START**************************************************/
        public virtual void Start()
        {
            if(ButtonsController.Character1.Equals("Toggle1"))
                PlayerDef1=Player1;
            else if(ButtonsController.Character2.Equals("Toggle1"))
                PlayerDef2=Player1;
            else
                Player1.SetActive(false);

            if(ButtonsController.Character1.Equals("Toggle2"))
                PlayerDef1=Player2;
            else if(ButtonsController.Character2.Equals("Toggle2"))
                PlayerDef2=Player2;
            else
                Player2.SetActive(false);

            if(ButtonsController.Character1.Equals("Toggle3"))
                PlayerDef1=Player3;
            else if(ButtonsController.Character2.Equals("Toggle3"))
                PlayerDef2=Player3;
            else
                Player3.SetActive(false);

            if(ButtonsController.Character1.Equals("Toggle4"))
                PlayerDef1=Player4;
            else if(ButtonsController.Character2.Equals("Toggle4"))
                PlayerDef2=Player4;
            else
                Player4.SetActive(false);

            if(ButtonsController.Character1.Equals("Toggle5"))
                PlayerDef1=Player5;
            else if(ButtonsController.Character2.Equals("Toggle5"))
                PlayerDef2=Player5;
            else
                Player5.SetActive(false);

            if(ButtonsController.Character1.Equals("Toggle6"))
                PlayerDef1=Player6;
            else if(ButtonsController.Character2.Equals("Toggle6"))
                PlayerDef2=Player6;
            else
                Player6.SetActive(false);

            PlayerDef1.SetActive(true);
            PlayerDef2.SetActive(true);
            Dice.SetActive(true);

            TextRooms.SetActive(false);
            Kitchen.SetActive(false);
            LivingRoom.SetActive(false);
            Office.SetActive(false);
            GreenHouse.SetActive(false);
            DinningRoom.SetActive(false);
            Library.SetActive(false);
            Lobby.SetActive(false);
            DanceRoom.SetActive(false);
            GamesRoom.SetActive(false);

            for(int i=0;i<21;i++)
            {
                cardsNotes[i].SetActive(false);
            }
        }

        /*************************************************UPDATE**************************************************/
        public virtual void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                Scene.SetActive(false);

                TextRooms.SetActive(false);
                Kitchen.SetActive(false);
                LivingRoom.SetActive(false);
                Office.SetActive(false);
                GreenHouse.SetActive(false);
                DinningRoom.SetActive(false);
                Library.SetActive(false);
                Lobby.SetActive(false);
                DanceRoom.SetActive(false);
                GamesRoom.SetActive(false);

                CharacterBlue.SetActive(false);
                CharacterRed.SetActive(false);
                CharacterGreen.SetActive(false);
                CharacterYellow.SetActive(false);
                CharacterPurple.SetActive(false);
                CharacterPink.SetActive(false);

                Knife.SetActive(false);
                Rope.SetActive(false);
                Gun.SetActive(false);
                Pipeline.SetActive(false);
                Candle.SetActive(false);
                Wrench.SetActive(false);

                PlayerDef1.SetActive(false);
                PlayerDef2.SetActive(false);

                for(int i=0;i<21;i++)
                {
                    cardsNotes[i].SetActive(false);
                }

                Dice.SetActive(false);
                return;
            }

            /*************************************************SI DADO LANZADO**************************************************/
            Color tmp;

            if(GameLogic.Dice1.thrown)
            {
                TextMesh textObject=TextRooms.GetComponent<TextMesh>();
                textObject.text=GameLogic.Dice1.currentValue.ToString();

                TextRooms.SetActive(true);
                Kitchen.SetActive(true);
                LivingRoom.SetActive(true);
                Office.SetActive(true);
                GreenHouse.SetActive(true);
                DinningRoom.SetActive(true);
                Library.SetActive(true);
                Lobby.SetActive(true);
                DanceRoom.SetActive(true);
                GamesRoom.SetActive(true);

                int dicevalue=GameLogic.Dice1.currentValue;
                GameLogic.Room r;

                if(GameLogic.turn%2!=0)
                {
                    r=GameLogic.Player1.Room;
                }
                else
                {
                    r=GameLogic.Player2.Room;
                }

                GameLogic.Hab[] roomsArray={GameLogic.Hab.Off, GameLogic.Hab.Lib, GameLogic.Hab.Liv, GameLogic.Hab.Din, GameLogic.Hab.Dan, GameLogic.Hab.Gam, GameLogic.Hab.Gre, GameLogic.Hab.Lob, GameLogic.Hab.Kit};

                GameObject[] habs={Office,Library,LivingRoom,DinningRoom,DanceRoom,GamesRoom,GreenHouse,Lobby,Kitchen};

                for(int i=0;i<9;i++)
                {
                    bool inside=false;
                    for(int j=0;j<dicevalue && inside==false;j++)
                    {
                        if(roomsArray[i]==r.Distances[j])
                        {
                            habs[i].GetComponent<Collider>().enabled=true;
                            tmp = habs[i].GetComponent<SpriteRenderer>().color;
                            tmp.a = 1f;
                            habs[i].GetComponent<SpriteRenderer>().color = tmp;
                            inside=true;
                        }
                    }
                    if(inside==false)
                    {
                        habs[i].GetComponent<Collider>().enabled=false;
                        tmp = habs[i].GetComponent<SpriteRenderer>().color;
                        tmp.a = 0.5f;
                        habs[i].GetComponent<SpriteRenderer>().color = tmp;
                    }
                }
            }

            /*************************************************SI MOVIDO DE HABITACION*******************************************/
            if(GameLogic.Dice1.finished)
            {
                TextMesh textObject=TextRooms.GetComponent<TextMesh>();
                textObject.text=GameLogic.Dice1.currentValue.ToString();

                TextRooms.SetActive(false);
                Kitchen.SetActive(false);
                LivingRoom.SetActive(false);
                Office.SetActive(false);
                GreenHouse.SetActive(false);
                DinningRoom.SetActive(false);
                Library.SetActive(false);
                Lobby.SetActive(false);
                DanceRoom.SetActive(false);
                GamesRoom.SetActive(false);

                GameLogic.Dice1.finished=false;
            }

            /*************************************************CARTAS NOTAS**************************************************/
            if(GameLogic.turn%2!=0)
            {
                if(GameLogic.Player1.Notes)
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(true);
                    }

                    for(int i=0;i<21;i++)
                    {
                        if(GameLogic.Player1.Cards[i]==0)
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteNormal[i];
                        else if(GameLogic.Player1.Cards[i]==1)
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                        else
                        {
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                            cardsNotes[i].GetComponent<Collider>().enabled=false;
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=1f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                        }
                    }
                }
                else
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(false);
                    }
                }
            }
            else
            {
                if(GameLogic.Player2.Notes)
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(true);
                    }

                    for(int i=0;i<21;i++)
                    {
                        if(GameLogic.Player2.Cards[i]==0)
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteNormal[i];
                        else if(GameLogic.Player2.Cards[i]==1)
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                        else
                        {
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                            cardsNotes[i].GetComponent<Collider>().enabled=false;
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=1f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                        }
                    }
                }
                else
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(false);
                    }
                }
            }


            /*************************************************ELEMENTOS DE TABLERO**************************************************/
            float height=0f;
            Scene.transform.localPosition = (height * Vector3.up);
            Scene.SetActive(true);

            
            CharacterBlue.transform.localPosition = (GameLogic.Blue.GetElementPositionX() * Vector3.left) + (GameLogic.Blue.GetElementPositionZ() * Vector3.back);
            CharacterBlue.SetActive(true);

            CharacterRed.transform.localPosition = (GameLogic.Red.GetElementPositionX() * Vector3.left) + (GameLogic.Red.GetElementPositionZ() * Vector3.back);
            CharacterRed.SetActive(true);

            CharacterGreen.transform.localPosition = (GameLogic.Green.GetElementPositionX()* Vector3.left) + (GameLogic.Green.GetElementPositionZ() * Vector3.back);
            CharacterGreen.SetActive(true);

            CharacterYellow.transform.localPosition = (GameLogic.Yellow.GetElementPositionX() * Vector3.left) + (GameLogic.Yellow.GetElementPositionZ() * Vector3.back);
            CharacterYellow.SetActive(true);

            CharacterPurple.transform.localPosition = (GameLogic.Purple.GetElementPositionX() * Vector3.left) + (GameLogic.Purple.GetElementPositionZ() * Vector3.back);
            CharacterPurple.SetActive(true);

            CharacterPink.transform.localPosition = (GameLogic.Pink.GetElementPositionX() * Vector3.left) + (GameLogic.Pink.GetElementPositionZ() * Vector3.back);
            CharacterPink.SetActive(true);


            Gun.transform.localPosition = (GameLogic.Gun.GetElementPositionX() * Vector3.left) + (GameLogic.Gun.GetElementPositionZ() * Vector3.back) + (0.1f * Vector3.up);
            Gun.SetActive(true);

            Knife.transform.localPosition = (GameLogic.Knife.GetElementPositionX() * Vector3.left) + (GameLogic.Knife.GetElementPositionZ() * Vector3.back) + (0.5f * Vector3.up);
            Knife.SetActive(true);

            Candle.transform.localPosition = (GameLogic.Candle.GetElementPositionX() * Vector3.left) + (GameLogic.Candle.GetElementPositionZ() * Vector3.back) + (0.2f * Vector3.up);
            Candle.SetActive(true);

            Rope.transform.localPosition = (GameLogic.Rope.GetElementPositionX() * Vector3.left) + (GameLogic.Rope.GetElementPositionZ() * Vector3.back) + (0.5f * Vector3.up);
            Rope.SetActive(true);

            Pipeline.transform.localPosition = (GameLogic.Pipeline.GetElementPositionX() * Vector3.left) + (GameLogic.Pipeline.GetElementPositionZ() * Vector3.back) + (0.5f * Vector3.up);
            Pipeline.SetActive(true);

            Wrench.transform.localPosition = (GameLogic.Wrench.GetElementPositionX() * Vector3.left) + (GameLogic.Wrench.GetElementPositionZ() * Vector3.back) + (0.5f * Vector3.up);
            Wrench.SetActive(true);

            PlayerDef1.transform.localPosition = (GameLogic.Player1.GetElementPositionX() * Vector3.left) + (GameLogic.Player1.GetElementPositionZ() * Vector3.back);
            PlayerDef1.SetActive(true);

            PlayerDef2.transform.localPosition = (GameLogic.Player2.GetElementPositionX() * Vector3.left) + (GameLogic.Player2.GetElementPositionZ() * Vector3.back);
            PlayerDef2.SetActive(true);
        }
    }
}
