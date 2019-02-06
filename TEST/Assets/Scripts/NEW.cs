using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEW : MonoBehaviour {
    public GameObject[] Obstacle;
    private Vector3 position;
    public int index=0;
    private int Flag;
    
	// Use this for initialization
	void Start () {
        GetComponent<NEW>().GetLocation();

    }
      Vector3 GetLocation()


      {
        Flag= UnityEngine.Random.Range(0, 3);
        print("range" + Flag); 
        
       Obstacle = GameObject.FindGameObjectsWithTag("rock");

        
        
        

            for (int i = 0; i <= Flag; i++)
            {
            position = Obstacle[Flag].transform.position;
            
            print("position" + position);
            Instantiate(Resources.Load("CratePink"), position,Quaternion.identity);
                
                
                
            }
        return Vector3.zero;





        //index = index + 1;
    }

  
    // Update is called once per frame
    void Update () {
       
		
	}
}
