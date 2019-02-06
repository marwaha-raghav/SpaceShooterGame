using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackRepeat : MonoBehaviour {
    private BoxCollider2D BackGroundCollider;
    private float ColliderSize;
	// Use this for initialization
	void Start () {
        BackGroundCollider = GetComponent<BoxCollider2D>();
       ColliderSize = BackGroundCollider.size.y;
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y <(-ColliderSize)/2)
        {
            RepeatBackground();
        }
		
	}

    void RepeatBackground()
    {
        Vector2 Offset = new Vector2(0, ColliderSize);
        transform.position = (Vector2)transform.position + Offset;
            
    }
}
