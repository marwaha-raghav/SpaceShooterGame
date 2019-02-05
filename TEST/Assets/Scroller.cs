using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {

    private Rigidbody2D Rigid;
    private float speed=-0.002f;
    [SerializeField]private bool SetStop;

	// Use this for initialization
	void Start () {
        Rigid = GetComponent<Rigidbody2D>();
        Rigid.velocity = new Vector2 (0, speed);
		
	}
	
	// Update is called once per frame
	void Update () {
		if(SetStop)
        {
            Rigid.velocity = new Vector2(0, 0);
        }
        else
        {
            Rigid.velocity = new Vector2(0, speed);
        }
	}
}
