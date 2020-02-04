using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformation : MonoBehaviour
{
    public float x = 0f;
    public float y = 0f;
    public float z = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate (x, y, z);
        // if(transform.position (0.0, 2.05, -17)){
        //     transform.Translate (0, 0, 0);
        // }

        //output to log the position change
        Debug.Log(transform.position);
    }
}
