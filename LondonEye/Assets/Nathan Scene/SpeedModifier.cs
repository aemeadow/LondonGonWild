using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedModifier : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Accelerator")) 
        {
            rb.velocity = rb.velocity*1.2f;
            Debug.Log("Touched Speed");
        }
        if (other.gameObject.CompareTag("Decelerator")) 
        {
            rb.velocity = rb.velocity/2;
            Debug.Log("Touched Slow");
        }
    }
}
