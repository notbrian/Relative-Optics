
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerVideoControl : MonoBehaviour
{
    public InputDevice LeftController;
    public InputDevice RightController;

    private DigitalRuby.Tween.MasterVideoController masterV;


    // Start is called before the first frame update
    void Start()
    {
        masterV = GetComponent<DigitalRuby.Tween.MasterVideoController>();
        var inputDevices = new List<InputDevice>();
        InputDevices.GetDevices(inputDevices);

        foreach (var device in inputDevices)
        {
            if (device.characteristics.HasFlag(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Left))
            {
                Debug.Log("Found Left Controller");
                LeftController = device;
            }

            if (device.characteristics.HasFlag(InputDeviceCharacteristics.Controller | InputDeviceCharacteristics.Right))
            {
                Debug.Log("Found Right Controller");
                RightController = device;
            }

            //Debug.Log(string.Format("Device found with name '{0}' and role '{1}'", device.name, deviceChar.ToString()));
        }
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 RightJoystick;
        bool RightJoystickTouch;
        bool RightTriggerBool;

        RightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxisTouch, out RightJoystickTouch);
        RightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out RightJoystick);
        RightController.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out RightTriggerBool);

        if (RightJoystick.x > 0.8)
        {

            masterV.playVideo("right");
        }

        if (RightJoystick.x < -0.8)
        {
            masterV.playVideo("left");
        }

        if (RightJoystick.y < -0.8)
        {
            masterV.playVideo("return");
        }

        if (RightJoystick.y > 0.8)
        {
            masterV.playVideo("security");
        }

        if (RightTriggerBool)
        {

            Debug.Log("YOOOOOOO");
            // masterV.playVideo("start");

        }



    }
}
