using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalRuby.Tween;
namespace DigitalRuby.Tween
{


    public class FadeController : MonoBehaviour
    {
        public Material material;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void fadeOutSphere()
        {

            System.Action<ITween<Color>> updateColor = (t) =>
                  {
                      Debug.Log("Tweening");
                      Debug.Log(t.CurrentValue);
                      material.SetColor("_BaseColor", t.CurrentValue);
                  };
            TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 1f), new Color(1f, 1f, 1f, 0f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);

        }

        public void fadeInSphere()
        {

            System.Action<ITween<Color>> updateColor = (t) =>
                  {
                      Debug.Log("Tweening");
                      Debug.Log(t.CurrentValue);
                      material.SetColor("_BaseColor", t.CurrentValue);
                  };
            TweenFactory.Tween("Base Map", new Color(1f, 1f, 1f, 0f), new Color(1f, 1f, 1f, 1f), 1.0f, TweenScaleFunctions.QuadraticEaseOut, updateColor);

        }
    }
}