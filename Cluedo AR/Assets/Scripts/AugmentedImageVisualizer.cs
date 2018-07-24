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
            Dice.SetActive(false);
        }

        public virtual void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                Scene.SetActive(false);

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
                return;
            }

            float height=0f;
            Scene.transform.localPosition = (height * Vector3.up);
            Scene.SetActive(true);

            
            float CharacterBlueX=3.1f;
            float CharacterBlueZ=3.5f;
            CharacterBlue.transform.localPosition = (CharacterBlueX * Vector3.left) + (CharacterBlueZ * Vector3.back);
            CharacterBlue.SetActive(true);

            CharacterRed.transform.localPosition = (GameLogic.Red.PositionX * Vector3.left) + (GameLogic.Red.PositionZ * Vector3.back);
            CharacterRed.SetActive(true);

            float CharacterGreenX=-3.1f;
            float CharacterGreenZ=-3.5f;
            CharacterGreen.transform.localPosition = (CharacterGreenX * Vector3.left) + (CharacterGreenZ * Vector3.back);
            CharacterGreen.SetActive(true);

            float CharacterYellowX=3.1f;
            float CharacterYellowZ=-3.5f;
            CharacterYellow.transform.localPosition = (CharacterYellowX * Vector3.left) + (CharacterYellowZ * Vector3.back);
            CharacterYellow.SetActive(true);

            float CharacterPurpleX=-3.1f;
            float CharacterPurpleZ=1.5f;
            CharacterPurple.transform.localPosition = (CharacterPurpleX * Vector3.left) + (CharacterPurpleZ * Vector3.back);
            CharacterPurple.SetActive(true);

            float CharacterPinkX=-3.1f;
            float CharacterPinkZ=-1.2f;
            CharacterPink.transform.localPosition = (CharacterPinkX * Vector3.left) + (CharacterPinkZ * Vector3.back);
            CharacterPink.SetActive(true);


            float GunX=1f;
            float GunZ=-3.2f;
            Gun.transform.localPosition = (GunX * Vector3.left) + (GunZ * Vector3.back);
            Gun.SetActive(true);

            float KnifeX=3.1f;
            float KnifeZ=-0.2f;
            Knife.transform.localPosition = (KnifeX * Vector3.left) + (KnifeZ * Vector3.back);
            Knife.SetActive(true);

            float CandleX=0f;
            float CandleZ=3.5f;
            Candle.transform.localPosition = (CandleX * Vector3.left) + (CandleZ * Vector3.back);
            Candle.SetActive(true);

            float Character1X=1f;
            float Character1Z=3.5f;
            PlayerDef1.transform.localPosition = (Character1X * Vector3.left) + (Character1Z * Vector3.back);
            PlayerDef1.SetActive(true);

            float Character2X=-1f;
            float Character2Z=3.5f;
            PlayerDef2.transform.localPosition = (Character2X * Vector3.left) + (Character2Z * Vector3.back);
            PlayerDef2.SetActive(true);
        }
    }
}
