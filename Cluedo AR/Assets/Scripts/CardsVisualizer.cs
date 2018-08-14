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
        private bool firstTime;

        //Habitaciones
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

        public virtual void Start()
        {
            firstTime=true;

            Kitchen.SetActive(false);
            LivingRoom.SetActive(false);
            DinningRoom.SetActive(false);
            Lobby.SetActive(false);
            GamesRoom.SetActive(false);
            DanceRoom.SetActive(false);
            Office.SetActive(false);
            Library.SetActive(false);
            GreenHouse.SetActive(false);

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
                switch(Image.Name)
                {
                    case "amarillo":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "azul":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "rojo":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "verde":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "morado":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "rosa":
                        GameLogic.sol.character=GameLogic.Car.Emp;
                        break;
                    case "candelabro":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "cuerda":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "herramienta":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "knife":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "pistola":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "tuberia":
                        GameLogic.sol.gun=GameLogic.Arm.Emp;
                        break;
                    case "cocina":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "comedor":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "estudio":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "invernadero":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "salabaile":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "salabillar":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "salon":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "vestibulo":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                    case "biblioteca":
                        GameLogic.sol.room=GameLogic.Hab.Emp;
                        break;
                }

                Kitchen.SetActive(false);
                LivingRoom.SetActive(false);
                DinningRoom.SetActive(false);
                Lobby.SetActive(false);
                GamesRoom.SetActive(false);
                DanceRoom.SetActive(false);
                Office.SetActive(false);
                Library.SetActive(false);
                GreenHouse.SetActive(false);

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

            if(firstTime)
            {
                float height=0.2f;
                switch(Image.Name)
                {
                    case "amarillo":
                        CharacterYellow.transform.localPosition = (height * Vector3.up);
                        CharacterYellow.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Yel);
                        break;
                    case "azul":
                        CharacterBlue.transform.localPosition = (height * Vector3.up);
                        CharacterBlue.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Blu);
                        break;
                    case "rojo":
                        CharacterRed.transform.localPosition = (height * Vector3.up);
                        CharacterRed.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Red);
                        break;
                    case "verde":
                        CharacterGreen.transform.localPosition = (height * Vector3.up);
                        CharacterGreen.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Gree);
                        break;
                    case "morado":
                        CharacterPurple.transform.localPosition = (height * Vector3.up);
                        CharacterPurple.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Pur);
                        break;
                    case "rosa":
                        CharacterPink.transform.localPosition = (height * Vector3.up);
                        CharacterPink.SetActive(true);
                        GameLogic.sol.SetCharacter(GameLogic.Car.Pin);
                        break;
                    case "candelabro":
                        Candle.transform.localPosition = (height * Vector3.up);
                        Candle.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Can);
                        break;
                    case "cuerda":
                        Rope.transform.localPosition = (height * 3 * Vector3.up);
                        Rope.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Rop);
                        break;
                    case "herramienta":
                        Wrench.transform.localPosition = (height * Vector3.up);
                        Wrench.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Wre);
                        break;
                    case "knife":
                        Knife.transform.localPosition = (height * Vector3.up);
                        Knife.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Kni);
                        break;
                    case "pistola":
                        Gun.transform.localPosition = (height * Vector3.up);
                        Gun.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Gun);
                        break;
                    case "tuberia":
                        Pipeline.transform.localPosition = (height * Vector3.up);
                        Pipeline.SetActive(true);
                        GameLogic.sol.SetGun(GameLogic.Arm.Pip);
                        break;
                    case "cocina":
                        Kitchen.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        Kitchen.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Kit);
                        break;
                    case "comedor":
                        DinningRoom.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        DinningRoom.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Din);
                        break;
                    case "estudio":
                        Office.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        Office.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Off);
                        break;
                    case "invernadero":
                        GreenHouse.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        GreenHouse.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Gre);
                        break;
                    case "salabaile":
                        DanceRoom.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        DanceRoom.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Dan);
                        break;
                    case "salabillar":
                        GamesRoom.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        GamesRoom.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Gam);
                        break;
                    case "salon":
                        LivingRoom.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        LivingRoom.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Liv);
                        break;
                    case "vestibulo":
                        Lobby.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        Lobby.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Lob);
                        break;
                    case "biblioteca":
                        Library.transform.localPosition = (height * 6.0f * Vector3.up) + (0.9f * Vector3.left);
                        Library.SetActive(true);
                        GameLogic.sol.SetRoom(GameLogic.Hab.Liv);
                        break;
                }

                firstTime=false;
            }
        }
    }
}