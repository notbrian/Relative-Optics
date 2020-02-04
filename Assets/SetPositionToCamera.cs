using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionToCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Camera cam = GameObject.Find("Main Camera").GetComponent<Camera>();
         transform.SetPositionAndRotation(cam.transform.position, transform.rotation);
    }
}
