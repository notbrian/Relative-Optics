using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotationCorrection : MonoBehaviour
{

    public void setYRotation(int yRot)
    {
        Vector3 newRotation = transform.eulerAngles;
        newRotation.y = yRot;
        transform.eulerAngles = newRotation;
    }
}
