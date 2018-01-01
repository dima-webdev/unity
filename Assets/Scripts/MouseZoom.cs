using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseZoom : MonoBehaviour {

    public float scrollSpeed = 50.0f;
    public float zoomMin = 30f;
    public float zoomMax = 90f;

    void LateUpdate()
    {
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            if (Camera.main.fieldOfView >= zoomMin || Camera.main.fieldOfView <= zoomMax)
            {
                Camera.main.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * scrollSpeed;
            }
            if (Camera.main.fieldOfView < zoomMin)
            {
                Camera.main.fieldOfView = zoomMin;
            }
            if (Camera.main.fieldOfView > zoomMax)
            {
                Camera.main.fieldOfView = zoomMax;
            }
        }
    }
}
