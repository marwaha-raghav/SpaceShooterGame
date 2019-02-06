using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

	
        // How high above the player each platform is
        float genHeight = 3.0f;
        //Initialize varibles
        bool upr = false;
        bool upl = false;
        bool ri = false;
        bool le = false;
        public  GameObject uprCube;
        public GameObject uplCube;
        public  GameObject riCube;
        public  GameObject leCube;
        public GameObject thePlayer;
        //Find the player if he wasnt set in te inspector
        void Start()
        {
            if (thePlayer == null)
            {
                thePlayer = GameObject.Find("Player");
            }
        }
        void Update()
        {
            //Check if we nedd to generate a platform in the top right
            if (upr == false)
            {
                        uprCube=GameObject.CreatePrimitive(PrimitiveType.Cube);
                uprCube.transform.position = thePlayer.transform.position + new Vector3(1, genHeight, 0);
                upr = true;
            }
            if (uprCube != null)
            {
                if (uprCube.transform.position.y <= thePlayer.transform.position.y)
                {
                    upr = false;
                    ri = false;
                }
            }
            //Check if we nedd to generate a platform in the top left
            if (upl == false)
            {
                uplCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                uplCube.transform.position = thePlayer.transform.position + new Vector3(-1, genHeight, 0);
                upl = true;
            }
            if (uplCube != null)
            {
                if (uplCube.transform.position.y <= thePlayer.transform.position.y)
                {
                    upl = false;
                    le = false;
                }
            }
            //Check if we nedd to generate a platform in the below the player to the right
            if (ri == false)
            {
                riCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                riCube.transform.position = thePlayer.transform.position + new Vector3(1, -1, 0);
                ri = true;
            }
            if (riCube != null)
            {
                if (riCube.transform.position.x <= thePlayer.transform.position.x)
                {
                    ri = false;
                }
            }
            //Check if we nedd to generate a platform in the below the player to the left
            if (le == false)
            {
                leCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                leCube.transform.position = thePlayer.transform.position + new Vector3(-1, -1, 0);
                le = true;
            }
            if (leCube != null)
            {
                if (leCube.transform.position.x >= thePlayer.transform.position.x)
                {
                    le = false;
                }
            }

        }
    }

