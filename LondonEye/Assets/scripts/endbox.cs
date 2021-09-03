using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endbox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    { 
        if (other.gameObject.tag == "Player") 
        {
            
                Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
                Debug.Log("end");
        }
        
    }
}