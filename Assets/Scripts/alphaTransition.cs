using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alphaTransition : MonoBehaviour
{
    bool alpha;
    // Start is called before the first frame update
    void Start()
    {
        alpha = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))

        if (alpha)
        {
            GetComponent<Renderer>().enabled = false;
            alpha = false;
            Debug.Log("alpha is off");
        }

        else if(Input.GetKeyDown(KeyCode.Space))

        if(!alpha)
        {
            GetComponent<Renderer>().enabled = true;
            alpha = true;
            Debug.Log("alpha is on");
        }

    }
}
