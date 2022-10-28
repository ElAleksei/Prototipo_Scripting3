using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = FindObjectOfType<Camera>();
    }


    void Update()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            cam.orthographicSize -= 0.2f;
        }

        if (Input.mouseScrollDelta.y < 0)
        {
            cam.orthographicSize += 0.2f;
        }
    }
}
