using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour {
    
    public  GameObject Rock;
    private Vector3 obstaclePos;
    public Transform[] ObstacleLocList;
    private float ObstX, ObstcY, ObstcZ;
    private float clock = 0;

    // Use this for initialization
    void Start () {
        ObstcZ = -1;
        ObstX= GetComponent<Transform>().position.x;
        ObstcY = GetComponent<Transform>().position.y;
        obstaclePos = new Vector3(ObstX, ObstcY, ObstcZ);
       
       
    }
    Vector3 ReturnRandomLocation(Transform[] ObstacleLocList)
    {
        
        int Index=Random.Range(0, 4);
        obstaclePos=ObstacleLocList[Index].position;
        return obstaclePos;
        
    }
    float ObstacleTimer()
    {
        
        clock = clock + Time.deltaTime;
        clock = Mathf.FloorToInt(clock);
        clock++;
            return clock;

    }
	
	// Update is called once per frame
	void Update () {
      

        float clk = ObstacleTimer();
        Debug.Log("clock" + clk);
        if (clk%2==0 && clk%3==0 &&clk>200)
        {
            Instantiate(Rock, ReturnRandomLocation(ObstacleLocList), Quaternion.identity);
            
        }
    }
}
