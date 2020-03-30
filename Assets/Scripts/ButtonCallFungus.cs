using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
public class ButtonCallFungus : MonoBehaviour
{
    // Start is called before the first frame update
    public string FungusBlock;
    public Flowchart flowchart;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CallFungus()
    {
        flowchart.ExecuteBlock(FungusBlock);

    }
}
