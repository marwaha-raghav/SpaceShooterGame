using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerStay2D(Collider2D other)
        {
            if (other.tag == "Player")

            {
                
             
                
                    
                    SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
                
            }
        }
    }
}
