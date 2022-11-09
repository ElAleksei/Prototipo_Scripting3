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

    /// <summary>
    /// Se hace zoom dependiendo de hacia donde se haga el scroll
    /// </summary>
    void Update()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            if (cam.orthographicSize > 1)
            {
                cam.orthographicSize -= 0.2f;
            }       
        }

        if (Input.mouseScrollDelta.y < 0)
        {
            if (cam.orthographicSize < 3)
            {
                cam.orthographicSize += 0.2f;
            }            
        }
    }
}
