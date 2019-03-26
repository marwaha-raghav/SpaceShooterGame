using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour {
   public  Text Score;
    public Text Ammu;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float Scores= PlayerPrefs.GetFloat("Score");
        Score.text = "Score: " + Scores;
        int Ammo = PlayerPrefs.GetInt("AMMO");
        Ammu.text = "AMMUNITION: " + Ammo;
		
	}
}
