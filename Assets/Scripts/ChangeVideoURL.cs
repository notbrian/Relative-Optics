using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ChangeVideoURL : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEngine.Video.VideoPlayer VideoP;

    void Start()
    {
        VideoP = GetComponent<UnityEngine.Video.VideoPlayer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void changeVideoURL(string URL)
    {
        VideoP.url = Path.Combine(Application.streamingAssetsPath, URL);
    }
}
