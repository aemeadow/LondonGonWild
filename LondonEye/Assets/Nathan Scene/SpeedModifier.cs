using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Accelerator")) 
        {
            Debug.Log("Touched Speed");
        }
        if (other.gameObject.CompareTag("Decelerator")) 
        {
            Debug.Log("Touched Slow");
        }
    }
}
