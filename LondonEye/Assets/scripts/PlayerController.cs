using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("left"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.05f);
        }
        if (Input.GetKey("right"))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.05f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        }
    }
}
