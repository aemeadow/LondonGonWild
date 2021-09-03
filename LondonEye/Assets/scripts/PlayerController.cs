using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey("left")){
            //transform.Rotate(new Vector3(0, 0, 10) * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.05f);
        }
        if(Input.GetKey("right")){
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.05f);
            //transform.Rotate(new Vector3(0, 0, -10) * Time.deltaTime);
        }
    }
}
