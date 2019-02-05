using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attach : MonoBehaviour {
   public  Transform Player;
    public Transform obj;

	// Use this for initialization
	void Start () {
		
	}

    public void OnTriggerStay2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {

            print("blabla");
                Vector3.Slerp(Player.transform.position, obj.transform.position, 2f * Time.deltaTime);

            
        }
    }
}
