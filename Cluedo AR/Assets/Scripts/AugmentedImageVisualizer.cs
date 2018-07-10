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

        public GameObject CharacterBlue;

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
        }

        public virtual void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                Scene.SetActive(false);
                CharacterBlue.SetActive(false);
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
        }
    }
}
