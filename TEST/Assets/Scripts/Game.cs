﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Game : MonoBehaviour
{
    private float pos_x;
    private float pos_y;
    private float pos_z=-1;
    public float velocity = 0.01f;
    public GameObject obj;
    public ParticleSystem leftbullet;
    public ParticleSystem rightbullet;



    private void Start()
    
    {
        pos_x=GetComponent<Transform>().position.x;
        pos_y = GetComponent<Transform>().position.y;

    }
    public void Movement()
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
    public void Shooting()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            leftbullet.Play();
            rightbullet.Play();
            if (hit)
            {
                float HPoints = obj.GetComponent<ObstacleBehaviour>().ObstacleHealth();
                Debug.Log("health" + HPoints);
                HPoints = HPoints - 10f;
                Debug.Log("hit" + hit.collider.name);
                if (HPoints == 0)
                {
                    Destroy(hit.collider.gameObject);
                }

            }

        }
        else if (Input.GetKeyUp(KeyCode.Space))
            {
            leftbullet.Stop();
            rightbullet.Stop();
        }
    
    }
    private void Update()
    {
        Shooting();
        Movement();

    }
}