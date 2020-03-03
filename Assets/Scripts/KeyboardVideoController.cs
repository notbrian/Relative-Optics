using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.Tween;
namespace DigitalRuby.Tween
{

    public class KeyboardVideoController : MonoBehaviour
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
 

        // Update is called once per frame
        void Update()
        {

            System.Action<ITween<Color>> updateColor = (t) =>
                {
                    Debug.Log("Tweening");
                    Debug.Log(t.CurrentValue);
                    material.SetColor("_BaseColor", t.CurrentValue);
                };


            if (Input.GetKeyDown("a"))
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                // material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Vidoes/Game Over Left.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (Input.GetKeyDown("d"))
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Vidoes/Going right win.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (Input.GetKeyDown("s"))
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                material.SetColor("_BaseColor", Color.white);
                Video.url = "Assets/Vidoes/Security Cam.MP4";
                XRig.transform.position = new Vector3(0f, 0f, 0f);
            }

            if (Input.GetKeyDown("w"))
            {
                TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 1f), new Color(1f, 1f, 1f, 0f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
                XRig.transform.position = new Vector3(0f, 0f, -19.5f);
            }
        }
    }
}