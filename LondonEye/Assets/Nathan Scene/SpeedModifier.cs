using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpeedModifier : MonoBehaviour
{
    public Rigidbody rb;
    public TextMeshProUGUI Score;
    public static int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        Score.text = "Score:" + count;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Accelerator")) 
        {
            rb.velocity = rb.velocity*1.2f;
            Debug.Log("Touched Speed");
            count = count + 1;
        }
        if (other.gameObject.CompareTag("Decelerator")) 
        {
            rb.velocity = rb.velocity/2;
            Debug.Log("Touched Slow");
            count = count - 1;
        }
    }
}
