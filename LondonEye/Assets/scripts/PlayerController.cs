using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey("left")&&gameObject.transform.rotation.z<45){
            transform.Rotate(new Vector3(0, 0, 5) * Time.deltaTime);
        }
        if(Input.GetKey("right")&&gameObject.transform.rotation.z>-45){
            transform.Rotate(new Vector3(0, 0, -5) * Time.deltaTime);
        }
    }
}
