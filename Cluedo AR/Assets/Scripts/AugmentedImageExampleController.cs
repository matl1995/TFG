//-----------------------------------------------------------------------
// <copyright file="AugmentedImageExampleController.cs" company="Google">
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
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using UnityEngine;
    using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    /// <summary>
    /// Controller for AugmentedImage example.
    /// </summary>
    public class AugmentedImageExampleController : MonoBehaviour
    {
        public static bool borrar;

        public int oldRoom;
        public int oldCharacter;
        public int oldGun;

        public int room;
        public int character;
        public int gun;

        public static bool scan;


        /// <summary>
        /// A prefab for visualizing the board.
        /// </summary>
        public BoardVisualizer AugmentedBoardVisualizerPrefab;

        /// <summary>
        /// A prefab for visualizing the cards
        /// </summary>
        public CardsVisualizer AugmentedCardsVisualizerPrefab;

        /// <summary>
        /// The overlay containing the fit to scan user guide.
        /// </summary>
        public GameObject FitToScanOverlay;

        private Dictionary<int, AugmentedImageVisualizer> m_Visualizers
            = new Dictionary<int, AugmentedImageVisualizer>();

        private List<AugmentedImage> m_TempAugmentedImages = new List<AugmentedImage>();

        /// <summary>
        /// The Unity Start method.
        /// </summary>
        void Start () {
            oldRoom=-1;
            oldCharacter=-1;
            oldGun=-1;

            room=-1;
            character=-1;
            gun=-1;

            borrar=false;

            scan=false;
        }

        /// <summary>
        /// The Unity Update method.
        /// </summary>
        public void Update()
        {
            // Exit the app when the 'back' button is pressed.
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }

            // Check that motion tracking is tracking.
            if (Session.Status != SessionStatus.Tracking)
            {
                return;
            }

            if(borrar)
            {
                oldRoom=-1;
                room=-1;

                oldCharacter=-1;
                character=-1;

                oldGun=-1;
                gun=-1;

                GameLogic.sol.SetRoom(GameLogic.Hab.Emp);
                GameLogic.sol.SetCharacter(GameLogic.Car.Emp);
                GameLogic.sol.SetGun(GameLogic.Arm.Emp);

                if(BoardVisualizer.scanwrong)
                    GameLogic.turnFinished=true;

                borrar=false;

                ButtonsController.primeraVezScan=false;

                Scene scene=SceneManager.GetActiveScene();
                SceneManager.LoadScene(scene.name);
            }

            if(!scan)
            {
                GameLogic.sol.SetRoom(GameLogic.Hab.Emp);
                GameLogic.sol.SetCharacter(GameLogic.Car.Emp);
                GameLogic.sol.SetGun(GameLogic.Arm.Emp);
            }

            // Get updated augmented images for this frame.
            Session.GetTrackables<AugmentedImage>(m_TempAugmentedImages, TrackableQueryFilter.Updated);

            // Create visualizers and anchors for updated augmented images that are tracking and do not previously
            // have a visualizer. Remove visualizers for stopped images.
            foreach (AugmentedImage image in m_TempAugmentedImages)
            {
                AugmentedImageVisualizer visualizer = null;
                m_Visualizers.TryGetValue(image.DatabaseIndex, out visualizer);
                if (image.TrackingState == TrackingState.Tracking && visualizer == null)
                {
                    // Create an anchor to ensure that ARCore keeps tracking this augmented image.
                    Anchor anchor = image.CreateAnchor(image.CenterPose);
                    if(image.Name=="tablero")
                        visualizer = (BoardVisualizer)Instantiate(AugmentedBoardVisualizerPrefab, anchor.transform);
                    else if(scan)
                    {
                        visualizer = (CardsVisualizer)Instantiate(AugmentedCardsVisualizerPrefab, anchor.transform);

                        if(image.Name=="rojo" || image.Name=="amarillo" || image.Name=="azul" || image.Name=="verde" || image.Name=="morado" || image.Name=="rosa")
                        {
                            oldCharacter=character;
                            character=image.DatabaseIndex;

                            if(oldCharacter!=-1)
                            {
                                AugmentedImageVisualizer tmp=m_Visualizers[oldCharacter];
                                GameObject.Destroy(tmp.gameObject);
                                m_Visualizers.Remove(oldCharacter);
                            }
                        }
                        else if(image.Name=="candelabro" || image.Name=="cuerda" || image.Name=="herramienta" || image.Name=="knife" || image.Name=="pistola" || image.Name=="tuberia")
                        {
                            oldGun=gun;
                            gun=image.DatabaseIndex;

                            if(oldGun!=-1)
                            {
                                AugmentedImageVisualizer tmp=m_Visualizers[oldGun];
                                GameObject.Destroy(tmp.gameObject);
                                m_Visualizers.Remove(oldGun);
                            }
                        }
                        else if(image.Name=="cocina" || image.Name=="comedor" || image.Name=="vestibulo" || image.Name=="estudio" || image.Name=="invernadero" || image.Name=="salabaile" || image.Name=="salabillar" || image.Name=="biblioteca" || image.Name=="salon")
                        {
                            oldRoom=room;
                            room=image.DatabaseIndex;

                            if(oldRoom!=-1)
                            {
                                AugmentedImageVisualizer tmp=m_Visualizers[oldRoom];
                                GameObject.Destroy(tmp.gameObject);
                                m_Visualizers.Remove(oldRoom);
                            }
                        }

                    }
                    visualizer.Image = image;
                    m_Visualizers.Add(image.DatabaseIndex, visualizer);
                }
                else if (image.TrackingState == TrackingState.Stopped && visualizer != null)
                {
                    m_Visualizers.Remove(image.DatabaseIndex);
                    GameObject.Destroy(visualizer.gameObject);
                }
            }

            // Show the fit-to-scan overlay if there are no images that are Tracking.
            foreach (var visualizer in m_Visualizers.Values)
            {
                if (visualizer.Image.TrackingState == TrackingState.Tracking)
                {
                    FitToScanOverlay.SetActive(false);
                    return;
                }
            }

            FitToScanOverlay.SetActive(true);
        }
    }
}
