using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private float pos_x;
    private float pos_y;
    private float pos_z=-1;
    public float velocity = 0.01f;
    private void Start()
    {
        pos_x=GetComponent<Transform>().position.x;
        pos_y = GetComponent<Transform>().position.y;

    }
    void Movement()
    {
        if (Input.GetKey(KeyCode.D))
        {
           float pos =transform.position.x + velocity;
            Vector3 posi = new Vector3(pos, pos_y, pos_z);
            transform.position = posi;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            float pos = transform.position.x - velocity;
            Vector3 posi = new Vector3(pos, pos_y, pos_z);
            transform.position = posi;
        }

    }
    private void Update()
    {
        Movement();

    }
}