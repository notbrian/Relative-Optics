using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class setText : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject[] TextLabels = new GameObject[4];
    public string ActionName = "";
    void Start()
    {
        Transform Canvas = this.gameObject.transform.GetChild(0);
        int length = this.gameObject.transform.GetChild(0).childCount;

        for (int i = 0; i < length; i++)
        {
            TextLabels[i] = Canvas.GetChild(i).gameObject;
        }

    }

    // Update is called once per frame
    void Update()
    {
        int length = this.gameObject.transform.GetChild(0).childCount;
        for (int i = 0; i < length; i++)
        {
            TextLabels[i].GetComponent<Text>().text = ActionName;
        }
    }
}
