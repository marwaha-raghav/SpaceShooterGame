using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BH : MonoBehaviour
{
    private int index = 0;
    public Transform[] positions;




    /*public Vector3 GetNextPosition()
    {
        Vector3 result = positions[index].localPosition;
        index = index + 1;
        return result;
    }*/
    public GameObject obstacle;
    private bool rotating = true;
    // Update is called once per frame
    void Update()
    {

        if (rotating)
        {
            Vector3 to = obstacle.transform.position;

            if (Vector3.Distance(transform.eulerAngles, to) > 0.01f)
            {
                //transform.eulerAngles = Vector3.Slerp(transform.rotation.eulerAngles, to, Time.deltaTime);

                if (Input.GetKeyDown(KeyCode.LeftArrow))

                {


                    //To place objects into position, make a script that stores the positions and then assign the objects to them.
                    transform.localPosition = obstacle.transform.position;
                    transform.parent = obstacle.transform;







                }

                else
                {
                    transform.eulerAngles = to;
                    rotating = false;
                }
            }


        }
    }
}
