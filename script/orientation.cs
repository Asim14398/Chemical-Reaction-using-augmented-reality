using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientation : MonoBehaviour
{
    void Start()
    {
        // Lock the screen orientation to the current device orientation
        Screen.orientation = ScreenOrientation.AutoRotation;
    }

    void Update()
    {
        // Check if the device's orientation has changed
        DeviceOrientation deviceOrientation = Input.deviceOrientation;
        if (deviceOrientation != DeviceOrientation.Unknown &&
            deviceOrientation != DeviceOrientation.FaceUp &&
            deviceOrientation != DeviceOrientation.FaceDown)
        {
            // Update the screen orientation
            Screen.orientation = GetScreenOrientationFromDeviceOrientation(deviceOrientation);
        }
    }

    private ScreenOrientation GetScreenOrientationFromDeviceOrientation(DeviceOrientation deviceOrientation)
    {
        switch (deviceOrientation)
        {
            case DeviceOrientation.Portrait:
                return ScreenOrientation.Portrait;
            case DeviceOrientation.PortraitUpsideDown:
                return ScreenOrientation.PortraitUpsideDown;
            case DeviceOrientation.LandscapeLeft:
                return ScreenOrientation.LandscapeLeft;
            case DeviceOrientation.LandscapeRight:
                return ScreenOrientation.LandscapeRight;
            default:
                return Screen.orientation; // Keep the current orientation for unknown or unsupported orientations
        }
    }
}
