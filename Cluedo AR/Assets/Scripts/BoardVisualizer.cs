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
        public GameObject Indicator;

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

        public GameObject NextTurnText;
        public GameObject NextTurnButton;

        public GameObject ThrowButton;
        public GameObject NotesButton;
        public GameObject NextButton;
        public GameObject FinishButton;

        /*********************************************** HINT *****************************************************/
        public GameObject HintButton;
        public GameObject HintCard;
        public GameObject HintText;

        public Sprite HintSprite;

        public static bool primeraVezHint;

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
            Indicator.SetActive(true);
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

            NextTurnText.SetActive(false);
            NextTurnButton.SetActive(false);

            HintText.SetActive(false);
            HintCard.SetActive(false);
            HintButton.SetActive(false);
            primeraVezHint=true;

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

                NextTurnText.SetActive(false);
                NextTurnButton.SetActive(false);

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

                ThrowButton.SetActive(false);
                NotesButton.SetActive(false);
                NextButton.SetActive(false);
                FinishButton.SetActive(false);

                PlayerDef1.SetActive(false);
                PlayerDef2.SetActive(false);
                Indicator.SetActive(false);

                HintText.SetActive(false);
                HintCard.SetActive(false);
                HintButton.SetActive(false);

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
                textObject.text="Resultado del lanzamiento: "+GameLogic.Dice1.currentValue.ToString();

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
                textObject.text="Resultado del lanzamiento: "+GameLogic.Dice1.currentValue.ToString();

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


            /*************************************************SI TURNO TERMINADO*******************************************/
            if(GameLogic.turnFinished)
            {
                TextMesh textObject=NextTurnText.GetComponent<TextMesh>();
                if(GameLogic.turn%2!=0)
                    textObject.text="Turno del Jugador 2";
                else
                    textObject.text="Turno del Jugador 1";

                ThrowButton.SetActive(false);
                NotesButton.SetActive(false);
                NextButton.SetActive(false);
                FinishButton.SetActive(false);

                CharacterBlue.SetActive(false);
                CharacterRed.SetActive(false);
                CharacterGreen.SetActive(false);
                CharacterYellow.SetActive(false);
                CharacterPurple.SetActive(false);
                CharacterPink.SetActive(false);
                Gun.SetActive(false);
                Knife.SetActive(false);
                Candle.SetActive(false);
                Rope.SetActive(false);
                Pipeline.SetActive(false);
                Wrench.SetActive(false);
                Dice.SetActive(false);
                PlayerDef1.SetActive(false);
                PlayerDef2.SetActive(false);
                Indicator.SetActive(false);

                GameLogic.Dice1.finished=true;
                GameLogic.Dice1.thrown=false;

                NextTurnText.SetActive(true);
                NextTurnButton.SetActive(true);
            }


            /*************************************************SI PISTA*******************************************/
            if(GameLogic.hint && primeraVezHint)
            {
                ThrowButton.SetActive(false);
                NotesButton.SetActive(false);
                NextButton.SetActive(false);
                FinishButton.SetActive(false);

                ChangeHintSprite();

                if(GameLogic.hint)
                {
                    HintCard.GetComponent<SpriteRenderer>().sprite=HintSprite;
                    tmp=HintCard.GetComponent<SpriteRenderer>().color;
                    tmp.a=1f;
                    HintCard.GetComponent<SpriteRenderer>().color=tmp;
                
                    HintText.SetActive(true);
                    HintCard.SetActive(true);
                    HintButton.SetActive(true);

                    primeraVezHint=false;
                }

                GameLogic.Player1.Hint=GameLogic.Hin.Emp;
                GameLogic.Player2.Hint=GameLogic.Hin.Emp;
            }


            /*************************************************CARTAS NOTAS**************************************************/
            if(GameLogic.turn%2!=0)
            {
                if(GameLogic.Player1.Notes && !GameLogic.turnFinished)
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(true);
                    }

                    for(int i=0;i<21;i++)
                    {
                        if(GameLogic.Player1.Cards[i]==0)
                        {
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=0.45f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteNormal[i];
                        }
                        else if(GameLogic.Player1.Cards[i]==1)
                        {
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=0.45f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                        }
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
                if(GameLogic.Player2.Notes && !GameLogic.turnFinished)
                {
                    for(int i=0;i<21;i++)
                    {
                        cardsNotes[i].SetActive(true);
                    }

                    for(int i=0;i<21;i++)
                    {
                        if(GameLogic.Player2.Cards[i]==0)
                        {
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=0.45f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteNormal[i];
                        }
                        else if(GameLogic.Player2.Cards[i]==1)
                        {
                            tmp=cardsNotes[i].GetComponent<SpriteRenderer>().color;
                            tmp.a=0.45f;
                            cardsNotes[i].GetComponent<SpriteRenderer>().color=tmp;
                            cardsNotes[i].GetComponent<SpriteRenderer>().sprite=cardsNotesSpriteCross[i];
                        }
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

            if(!GameLogic.turnFinished && !GameLogic.hint)
            {
                ThrowButton.SetActive(true);
                NotesButton.SetActive(true);
                NextButton.SetActive(true);
                FinishButton.SetActive(true);

                HintButton.SetActive(false);
                HintCard.SetActive(false);
                HintText.SetActive(false);

                NextTurnText.SetActive(false);
                NextTurnButton.SetActive(false);

                Dice.SetActive(true);

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

                if(GameLogic.turn%2!=0)
                {
                    Indicator.transform.localPosition = (GameLogic.Player1.GetElementPositionX() * Vector3.left + new Vector3(-0.05f,0f,0f)) + (GameLogic.Player1.GetElementPositionZ() * Vector3.back) + (2f * Vector3.up);
                    Indicator.SetActive(true);
                }
                else
                {
                    Indicator.transform.localPosition = (GameLogic.Player2.GetElementPositionX() * Vector3.left + new Vector3(-0.05f,0f,0f)) + (GameLogic.Player2.GetElementPositionZ() * Vector3.back) + (2f * Vector3.up);
                    Indicator.SetActive(true);
                }
            }
            else if(!GameLogic.turnFinished)
            {
                PlayerDef1.transform.localPosition = (GameLogic.Player1.GetElementPositionX() * Vector3.left) + (GameLogic.Player1.GetElementPositionZ() * Vector3.back);
                PlayerDef1.SetActive(true);

                PlayerDef2.transform.localPosition = (GameLogic.Player2.GetElementPositionX() * Vector3.left) + (GameLogic.Player2.GetElementPositionZ() * Vector3.back);
                PlayerDef2.SetActive(true);

                if(GameLogic.turn%2!=0)
                {
                    Indicator.transform.localPosition = (GameLogic.Player1.GetElementPositionX() * Vector3.left + new Vector3(-0.05f,0f,0f)) + (GameLogic.Player1.GetElementPositionZ() * Vector3.back) + (2f * Vector3.up);
                    Indicator.SetActive(true);
                }
                else
                {
                    Indicator.transform.localPosition = (GameLogic.Player2.GetElementPositionX() * Vector3.left + new Vector3(-0.05f,0f,0f)) + (GameLogic.Player2.GetElementPositionZ() * Vector3.back) + (2f * Vector3.up);
                    Indicator.SetActive(true);
                }
            }
        }
        
        private void ChangeHintSprite()
        {
            GameLogic.Hin Hint;

            if(GameLogic.turn%2!=0)
            {
                Hint=GameLogic.Player1.Hint;

                switch (Hint)
                {
                    case GameLogic.Hin.Kit:
                        if(GameLogic.Kitchen.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Kit)
                            {
                                HintSprite=cardsNotesSpriteCross[13];
                                GameLogic.Player1.Cards[13]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Kitchen.HintTimePlayer1++;
                        }
                        else if(GameLogic.Kitchen.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Gun)
                            {
                                HintSprite=cardsNotesSpriteCross[1];
                                GameLogic.Player1.Cards[1]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Kitchen.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Off:
                        if(GameLogic.Office.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Off)
                            {
                                HintSprite=cardsNotesSpriteCross[15];
                                GameLogic.Player1.Cards[15]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Office.HintTimePlayer1++;
                        }
                        else if(GameLogic.Office.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Kni)
                            {
                                HintSprite=cardsNotesSpriteCross[0];
                                GameLogic.Player1.Cards[0]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Office.HintTimePlayer1++;
                        }
                        else if(GameLogic.Office.HintTimePlayer1==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Red)
                            {
                                HintSprite=cardsNotesSpriteCross[6];
                                GameLogic.Player1.Cards[6]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Office.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Dan:
                        if(GameLogic.DanceRoom.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Dan)
                            {
                                HintSprite=cardsNotesSpriteCross[17];
                                GameLogic.Player1.Cards[17]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.DanceRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.DanceRoom.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Rop)
                            {
                                HintSprite=cardsNotesSpriteCross[5];
                                GameLogic.Player1.Cards[5]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DanceRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.DanceRoom.HintTimePlayer1==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Yel)
                            {
                                HintSprite=cardsNotesSpriteCross[9];
                                GameLogic.Player1.Cards[9]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DanceRoom.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Din:
                        if(GameLogic.DinningRoom.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Din)
                            {
                                HintSprite=cardsNotesSpriteCross[14];
                                GameLogic.Player1.Cards[14]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.DinningRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.DinningRoom.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Pin)
                            {
                                HintSprite=cardsNotesSpriteCross[11];
                                GameLogic.Player1.Cards[11]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DinningRoom.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Gam:
                        if(GameLogic.GamesRoom.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Gam)
                            {
                                HintSprite=cardsNotesSpriteCross[18];
                                GameLogic.Player1.Cards[18]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.GamesRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.GamesRoom.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Blu)
                            {
                                HintSprite=cardsNotesSpriteCross[7];
                                GameLogic.Player1.Cards[7]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GamesRoom.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Liv:
                        if(GameLogic.LivingRoom.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Liv)
                            {
                                HintSprite=cardsNotesSpriteCross[19];
                                GameLogic.Player1.Cards[19]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.LivingRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.LivingRoom.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Pip)
                            {
                                HintSprite=cardsNotesSpriteCross[3];
                                GameLogic.Player1.Cards[3]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.LivingRoom.HintTimePlayer1++;
                        }
                        else if(GameLogic.LivingRoom.HintTimePlayer1==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Gree)
                            {
                                HintSprite=cardsNotesSpriteCross[8];
                                GameLogic.Player1.Cards[8]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.LivingRoom.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Lib:
                        if(GameLogic.Library.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Lib)
                            {
                                HintSprite=cardsNotesSpriteCross[12];
                                GameLogic.Player1.Cards[12]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Library.HintTimePlayer1++;
                        }
                        else if(GameLogic.Library.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Can)
                            {
                                HintSprite=cardsNotesSpriteCross[2];
                                GameLogic.Player1.Cards[2]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Library.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Lob:
                        if(GameLogic.Lobby.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Lob)
                            {
                                HintSprite=cardsNotesSpriteCross[20];
                                GameLogic.Player1.Cards[20]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Lobby.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Gre:
                        if(GameLogic.GreenHouse.HintTimePlayer1==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Gre)
                            {
                                HintSprite=cardsNotesSpriteCross[16];
                                GameLogic.Player1.Cards[16]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.GreenHouse.HintTimePlayer1++;
                        }
                        else if(GameLogic.GreenHouse.HintTimePlayer1==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Wre)
                            {
                                HintSprite=cardsNotesSpriteCross[4];
                                GameLogic.Player1.Cards[4]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GreenHouse.HintTimePlayer1++;
                        }
                        else if(GameLogic.GreenHouse.HintTimePlayer1==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Pur)
                            {
                                HintSprite=cardsNotesSpriteCross[10];
                                GameLogic.Player1.Cards[10]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GreenHouse.HintTimePlayer1++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                }
            }
            else
            {
                Hint=GameLogic.Player2.Hint;

                switch (Hint)
                {
                    case GameLogic.Hin.Kit:
                        if(GameLogic.Kitchen.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Kit)
                            {
                                HintSprite=cardsNotesSpriteCross[13];
                                GameLogic.Player2.Cards[13]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Kitchen.HintTimePlayer2++;
                        }
                        else if(GameLogic.Kitchen.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Gun)
                            {
                                HintSprite=cardsNotesSpriteCross[1];
                                GameLogic.Player2.Cards[1]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Kitchen.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Off:
                        if(GameLogic.Office.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Off)
                            {
                                HintSprite=cardsNotesSpriteCross[15];
                                GameLogic.Player2.Cards[15]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Office.HintTimePlayer2++;
                        }
                        else if(GameLogic.Office.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Kni)
                            {
                                HintSprite=cardsNotesSpriteCross[0];
                                GameLogic.Player2.Cards[0]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Office.HintTimePlayer2++;
                        }
                        else if(GameLogic.Office.HintTimePlayer2==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Red)
                            {
                                HintSprite=cardsNotesSpriteCross[6];
                                GameLogic.Player2.Cards[6]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Office.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Dan:
                        if(GameLogic.DanceRoom.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Dan)
                            {
                                HintSprite=cardsNotesSpriteCross[17];
                                GameLogic.Player2.Cards[17]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.DanceRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.DanceRoom.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Rop)
                            {
                                HintSprite=cardsNotesSpriteCross[5];
                                GameLogic.Player2.Cards[5]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DanceRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.DanceRoom.HintTimePlayer2==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Yel)
                            {
                                HintSprite=cardsNotesSpriteCross[9];
                                GameLogic.Player2.Cards[9]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DanceRoom.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Din:
                        if(GameLogic.DinningRoom.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Din)
                            {
                                HintSprite=cardsNotesSpriteCross[14];
                                GameLogic.Player2.Cards[14]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.DinningRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.DinningRoom.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Pin)
                            {
                                HintSprite=cardsNotesSpriteCross[11];
                                GameLogic.Player2.Cards[11]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.DinningRoom.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Gam:
                        if(GameLogic.GamesRoom.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Gam)
                            {
                                HintSprite=cardsNotesSpriteCross[18];
                                GameLogic.Player2.Cards[18]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.GamesRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.GamesRoom.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Blu)
                            {
                                HintSprite=cardsNotesSpriteCross[7];
                                GameLogic.Player2.Cards[7]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GamesRoom.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Liv:
                        if(GameLogic.LivingRoom.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Liv)
                            {
                                HintSprite=cardsNotesSpriteCross[19];
                                GameLogic.Player2.Cards[19]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.LivingRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.LivingRoom.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Pip)
                            {
                                HintSprite=cardsNotesSpriteCross[3];
                                GameLogic.Player2.Cards[3]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.LivingRoom.HintTimePlayer2++;
                        }
                        else if(GameLogic.LivingRoom.HintTimePlayer2==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Gree)
                            {
                                HintSprite=cardsNotesSpriteCross[8];
                                GameLogic.Player2.Cards[8]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.LivingRoom.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Lib:
                        if(GameLogic.Library.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Lib)
                            {
                                HintSprite=cardsNotesSpriteCross[12];
                                GameLogic.Player2.Cards[12]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Library.HintTimePlayer2++;
                        }
                        else if(GameLogic.Library.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Can)
                            {
                                HintSprite=cardsNotesSpriteCross[2];
                                GameLogic.Player2.Cards[2]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.Library.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Lob:
                        if(GameLogic.Lobby.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Lob)
                            {
                                HintSprite=cardsNotesSpriteCross[20];
                                GameLogic.Player2.Cards[20]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.Lobby.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                    case GameLogic.Hin.Gre:
                        if(GameLogic.GreenHouse.HintTimePlayer2==0)
                        {
                            if(GameLogic.sol.solRoom!=GameLogic.Hab.Gre)
                            {
                                HintSprite=cardsNotesSpriteCross[16];
                                GameLogic.Player2.Cards[16]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }

                            GameLogic.GreenHouse.HintTimePlayer2++;
                        }
                        else if(GameLogic.GreenHouse.HintTimePlayer2==1)
                        {
                            if(GameLogic.sol.solGun!=GameLogic.Arm.Wre)
                            {
                                HintSprite=cardsNotesSpriteCross[4];
                                GameLogic.Player2.Cards[4]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GreenHouse.HintTimePlayer2++;
                        }
                        else if(GameLogic.GreenHouse.HintTimePlayer2==2)
                        {
                            if(GameLogic.sol.solCharacter!=GameLogic.Car.Pur)
                            {
                                HintSprite=cardsNotesSpriteCross[10];
                                GameLogic.Player2.Cards[10]=2;
                            }
                            else
                            {
                                GameLogic.hint=false;
                                primeraVezHint=true;
                            }
                            
                            GameLogic.GreenHouse.HintTimePlayer2++;
                        }
                        else
                        {
                            GameLogic.hint=false;
                            primeraVezHint=true;
                        }
                        break;
                }
            }
        }
    }
}
