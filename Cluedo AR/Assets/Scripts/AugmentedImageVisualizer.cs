//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

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
    public class AugmentedImageVisualizer : MonoBehaviour
    {
        public AugmentedImage Image;

        public GameObject Scene;

        public GameObject Dice;

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
        }

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

                Dice.SetActive(false);
                return;
            }

            if(GameLogic.Dice1.GetThrown())
            {
                TextMesh textObject=TextRooms.GetComponent<TextMesh>();
                textObject.text=GameLogic.Dice1.GetValue().ToString();

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
            }


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


            Gun.transform.localPosition = (GameLogic.Gun.GetElementPositionX() * Vector3.left) + (GameLogic.Gun.GetElementPositionZ() * Vector3.back);
            Gun.SetActive(true);

            Knife.transform.localPosition = (GameLogic.Knife.GetElementPositionX() * Vector3.left) + (GameLogic.Knife.GetElementPositionZ() * Vector3.back);
            Knife.SetActive(true);

            Candle.transform.localPosition = (GameLogic.Candle.GetElementPositionX() * Vector3.left) + (GameLogic.Candle.GetElementPositionZ() * Vector3.back);
            Candle.SetActive(true);

            Rope.transform.localPosition = (GameLogic.Rope.GetElementPositionX() * Vector3.left) + (GameLogic.Rope.GetElementPositionZ() * Vector3.back);
            Rope.SetActive(true);

            Pipeline.transform.localPosition = (GameLogic.Pipeline.GetElementPositionX() * Vector3.left) + (GameLogic.Pipeline.GetElementPositionZ() * Vector3.back);
            Pipeline.SetActive(true);

            Wrench.transform.localPosition = (GameLogic.Wrench.GetElementPositionX() * Vector3.left) + (GameLogic.Wrench.GetElementPositionZ() * Vector3.back);
            Wrench.SetActive(true);

            PlayerDef1.transform.localPosition = (GameLogic.Player1.GetElementPositionX() * Vector3.left) + (GameLogic.Player1.GetElementPositionZ() * Vector3.back);
            PlayerDef1.SetActive(true);

            PlayerDef2.transform.localPosition = (GameLogic.Player2.GetElementPositionX() * Vector3.left) + (GameLogic.Player2.GetElementPositionZ() * Vector3.back);
            PlayerDef2.SetActive(true);
        }
    }
}
