using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.Tween;
namespace DigitalRuby.Tween
{

    public class MasterVideoController : MonoBehaviour
    {
        public UnityEngine.Video.VideoPlayer Video;
        public GameObject XRig;

        public Material material;

        // private string[] videClips = new string[] {"Assets\Vidoes\Moving through the hallway.MP4", "Assets\Vidoes\Game Over Left.MP4", "Assets\Vidoes\Going right win.MP4"};

        // Start is called before the first frame update
        void Start()
        {
            Video = GetComponent<UnityEngine.Video.VideoPlayer>();
            // Video.url = "Assets/Vidoes/Security Cam.MP4";

        }
        // IEnumerator SetPositionZero()
        // {
        //     yield return new WaitForSeconds(1);
        //     XRig.transform.position = new Vector3(0f, 0f, 0f);
        // }
        public void playVideo(string action)
        {

            System.Action<ITween<Color>> updateColor = (t) =>
               {
                   Debug.Log("Tweening");
                   Debug.Log(t.CurrentValue);
                   material.SetColor("_BaseColor", t.CurrentValue);
               };
            if (action == "left")
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                // material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Videos/Game Over Left.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (action == "right")
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Videos/Going right win.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (action == "security")
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Videos/Security Cam.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (action == "return")
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 1f), new Color(1f, 1f, 1f, 0f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                XRig.transform.position = new Vector3(0f, 0f, -19.5f);
            }

            if (action == "start")
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Videos/Moving through the hallway.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

        }

        // Update is called once per frame
        void Update()
        {



        }
    }
}