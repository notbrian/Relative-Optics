using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.Tween;

namespace DigitalRuby.Tween {

public class moveRig : MonoBehaviour
{   
    private UnityEngine.Video.VideoPlayer Video;
    public GameObject XRig;
    public Material material;

    public GameObject bloom;
    // Start is called before the first frame update
    void Start()
    {
        Video = GetComponent<UnityEngine.Video.VideoPlayer>();
        // Debug.Log("/" + Video.clip.originalPath + "/");
        Debug.Log(material.GetColor("_BaseColor"));
        material.SetColor("_BaseColor", Color.white);
        Video.loopPointReached += EndReached;
        // Debug.Log(bloom.GetComponent<Volume>());
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
      {

            System.Action<ITween<Color>> updateColor = (t) =>
            {
                Debug.Log("Tweening");
                Debug.Log(t.CurrentValue);
                material.SetColor("_BaseColor", t.CurrentValue);
            };
          Debug.Log("Ended");
          if(vp.clip.originalPath == "Assets/Moving through the hallway.MP4") {
            Debug.Log("Move Rig");
            XRig.transform.position = new Vector3(0f,0f,-19.5f);
            // Circle.gameObject.Tween("ColorCircle", spriteRenderer.color, endColor, 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
            TweenFactory.Tween("Base Map",  new Color(1f, 1f, 1f, 1f), new Color(1f, 1f, 1f, 0f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);
          }
      }

  
}
}