using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {
    public GameObject Player;
    public float RotateSpeed = 30f;


    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
        transform.Rotate(-Vector3.Cross(Vector3.up, Vector3.right) * RotateSpeed * Time.deltaTime);
        //transform.position = transform.position + new Vector3(0, 0.02f,0); //to give vertical velocity to player
    }
    
}
