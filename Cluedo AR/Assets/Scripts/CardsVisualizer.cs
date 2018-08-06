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
    public class CardsVisualizer : AugmentedImageVisualizer
    {
        //Habitaciones
        /*public GameObject Kitchen;
        public GameObject LivingRoom;
        public GameObject Office;
        public GameObject GreenHouse;
        public GameObject DinningRoom;
        public GameObject Library;
        public GameObject Lobby;
        public GameObject DanceRoom;
        public GameObject GamesRoom;*/


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

        public virtual void Start()
        {
            /*Kitchen.SetActive(false);
            LivingRoom.SetActive(false);
            DinningRoom.SetActive(false);
            Lobby.SetActive(false);
            GamesRoom.SetActive(false);
            DanceRoom.SetActive(false);
            Office.SetActive(false);
            Library.SetActive(false);
            GreenHouse.SetActive(false);*/

            CharacterPink.SetActive(false);
            CharacterPurple.SetActive(false);
            CharacterYellow.SetActive(false);
            CharacterGreen.SetActive(false);
            CharacterRed.SetActive(false);
            CharacterBlue.SetActive(false);

            Rope.SetActive(false);
            Candle.SetActive(false);
            Wrench.SetActive(false);
            Knife.SetActive(false);
            Gun.SetActive(false);
            Pipeline.SetActive(false);
        }

        public virtual void Update()
        {
            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                /*Kitchen.SetActive(false);
                LivingRoom.SetActive(false);
                DinningRoom.SetActive(false);
                Lobby.SetActive(false);
                GamesRoom.SetActive(false);
                DanceRoom.SetActive(false);
                Office.SetActive(false);
                Library.SetActive(false);
                GreenHouse.SetActive(false);*/

                CharacterPink.SetActive(false);
                CharacterPurple.SetActive(false);
                CharacterYellow.SetActive(false);
                CharacterGreen.SetActive(false);
                CharacterRed.SetActive(false);
                CharacterBlue.SetActive(false);

                Rope.SetActive(false);
                Candle.SetActive(false);
                Wrench.SetActive(false);
                Knife.SetActive(false);
                Gun.SetActive(false);
                Pipeline.SetActive(false);

                return;
            }

            float height=0.2f;
            switch(Image.Name)
            {
                case "amarillo":
                    CharacterYellow.transform.localPosition = (height * Vector3.up);
                    CharacterYellow.SetActive(true);
                    break;
                case "azul":
                    CharacterBlue.transform.localPosition = (height * Vector3.up);
                    CharacterBlue.SetActive(true);
                    break;
                case "rojo":
                    CharacterRed.transform.localPosition = (height * Vector3.up);
                    CharacterRed.SetActive(true);
                    break;
                case "verde":
                    CharacterGreen.transform.localPosition = (height * Vector3.up);
                    CharacterGreen.SetActive(true);
                    break;
                case "morado":
                    CharacterPurple.transform.localPosition = (height * Vector3.up);
                    CharacterPurple.SetActive(true);
                    break;
                case "rosa":
                    CharacterPink.transform.localPosition = (height * Vector3.up);
                    CharacterPink.SetActive(true);
                    break;
            }
        }
    }
}