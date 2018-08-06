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

            float height=0.2f;
            switch(Image.Name)
            {
                case "amarillo":
                    CharacterYellow.transform.localPosition = (height * Vector3.up);
                    CharacterYellow.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Yel;
                    GameLogic.sol.SetCharacter(CharacterYellow);
                    break;
                case "azul":
                    CharacterBlue.transform.localPosition = (height * Vector3.up);
                    CharacterBlue.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Blu;
                    GameLogic.sol.SetCharacter(CharacterBlue);
                    break;
                case "rojo":
                    CharacterRed.transform.localPosition = (height * Vector3.up);
                    CharacterRed.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Red;
                    GameLogic.sol.SetCharacter(CharacterRed);
                    break;
                case "verde":
                    CharacterGreen.transform.localPosition = (height * Vector3.up);
                    CharacterGreen.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Gree;
                    GameLogic.sol.SetCharacter(CharacterGreen);
                    break;
                case "morado":
                    CharacterPurple.transform.localPosition = (height * Vector3.up);
                    CharacterPurple.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Pur;
                    GameLogic.sol.SetCharacter(CharacterPurple);
                    break;
                case "rosa":
                    CharacterPink.transform.localPosition = (height * Vector3.up);
                    CharacterPink.SetActive(true);
                    GameLogic.sol.character=GameLogic.Car.Pin;
                    GameLogic.sol.SetCharacter(CharacterPink);
                    break;
                case "candelabro":
                    Candle.transform.localPosition = (height * Vector3.up);
                    Candle.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Can;
                    GameLogic.sol.SetGun(Candle);
                    break;
                case "cuerda":
                    Rope.transform.localPosition = (height * 3 * Vector3.up);
                    Rope.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Rop;
                    GameLogic.sol.SetGun(Rope);
                    break;
                case "herramienta":
                    Wrench.transform.localPosition = (height * Vector3.up);
                    Wrench.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Wre;
                    GameLogic.sol.SetGun(Wrench);
                    break;
                case "knife":
                    Knife.transform.localPosition = (height * Vector3.up);
                    Knife.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Kni;
                    GameLogic.sol.SetGun(Knife);
                    break;
                case "pistola":
                    Gun.transform.localPosition = (height * Vector3.up);
                    Gun.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Gun;
                    GameLogic.sol.SetGun(Gun);
                    break;
                case "tuberia":
                    Pipeline.transform.localPosition = (height * Vector3.up);
                    Pipeline.SetActive(true);
                    GameLogic.sol.gun=GameLogic.Arm.Pip;
                    GameLogic.sol.SetGun(Pipeline);
                    break;
                case "cocina":
                    Kitchen.transform.localPosition = (height * 3 * Vector3.up);
                    Kitchen.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Kit;
                    GameLogic.sol.SetRoom(Kitchen);
                    break;
                case "comedor":
                    DinningRoom.transform.localPosition = (height * 3 * Vector3.up);
                    DinningRoom.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Din;
                    GameLogic.sol.SetRoom(DinningRoom);
                    break;
                case "estudio":
                    Office.transform.localPosition = (height * 3 * Vector3.up);
                    Office.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Off;
                    GameLogic.sol.SetRoom(Office);
                    break;
                case "invernadero":
                    GreenHouse.transform.localPosition = (height * 3 * Vector3.up);
                    GreenHouse.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Gre;
                    GameLogic.sol.SetRoom(GreenHouse);
                    break;
                case "salabaile":
                    DanceRoom.transform.localPosition = (height * 3 * Vector3.up);
                    DanceRoom.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Dan;
                    GameLogic.sol.SetRoom(DanceRoom);
                    break;
                case "salabillar":
                    GamesRoom.transform.localPosition = (height * 3 * Vector3.up);
                    GamesRoom.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Gam;
                    GameLogic.sol.SetRoom(GamesRoom);
                    break;
                case "salon":
                    LivingRoom.transform.localPosition = (height * 3 * Vector3.up);
                    LivingRoom.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Liv;
                    GameLogic.sol.SetRoom(LivingRoom);
                    break;
                case "vestibulo":
                    Lobby.transform.localPosition = (height * 3 * Vector3.up);
                    Lobby.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Lob;
                    GameLogic.sol.SetRoom(Lobby);
                    break;
                case "biblioteca":
                    Library.transform.localPosition = (height * 3 * Vector3.up);
                    Library.SetActive(true);
                    GameLogic.sol.room=GameLogic.Hab.Liv;
                    GameLogic.sol.SetRoom(Library);
                    break;
            }
        }
    }
}