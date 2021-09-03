using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SpeedModifier : MonoBehaviour
{
    public Rigidbody rb;
    public TextMeshProUGUI Score;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        Score.text = "Score:" + count.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Accelerator")) 
        {
            rb.velocity = rb.velocity*1.2f;
            Debug.Log("Touched Speed");
            count = count + 1;
            Score.text = "Score:" + count.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Decelerator")) 
        {
            rb.velocity = rb.velocity/2;
            Debug.Log("Touched Slow");
            count = count - 1;
            Score.text = "Score:" + count.ToString();
            Destroy(other.gameObject);
        }
    }
}
