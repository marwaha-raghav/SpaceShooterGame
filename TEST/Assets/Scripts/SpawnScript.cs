using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject[] obj;
    public  Vector2 positione; 
    float max = 5f;
    float  min = 1f;

    
    // Use this for initialization
    void Start()
    {
        
        Spawn();
    }

    void Spawn()
    {
        int i;
        i = 0;
        Instantiate(obj[i], transform.position, Quaternion.identity);
        i = i + 1;
        
        Invoke("Spawn", 5.3f);
        

    }
    Vector2 Positions()

    {
        
        int i = 0;
        

        positione = obj[i].transform.position;
        i = i + 1;
        return positione;
        
    }

    public void OnTriggerStay2D(Collider2D collision)

    {


        if (Input.GetMouseButtonDown(0))//||moveLeft.HitTest(touch.position))
       {

            if (collision.CompareTag("Player"))
            {
              

                
                player.transform.localPosition = Positions();
                // player.transform.parent = obstacle.transform;
                Vector3.Slerp(player.transform.position, player.transform.localPosition, Time.time*2f );

                

                print("coll");
              

            }
            
        



        }


    }
}



