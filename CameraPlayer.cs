using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    public int camCount;
    void Start()
    {
        camCount = 0;
    }

    void Update()
    {
        ChangeCameraPosition();

        if (Input.GetMouseButtonDown(1)) 
        {
            camCount++;
        }

        if (camCount > 5)
        {
            camCount = 0;
        }
    }

    void ChangeCameraPosition()
    {
        if (camCount == 0)
        {
            transform.position = new Vector3(-12.297f, 6.89f, 0.13f);
            transform.eulerAngles = new Vector3(28, 90, 0);
        }
        else if (camCount == 1)
        {
            transform.position = new Vector3(-8.9f, 8.2f, -11.6f);
            transform.eulerAngles = new Vector3(31.69f, 38.9f, 0);
        }
        else if (camCount == 2)
        {
            transform.position = new Vector3(-11.85f, 8.2f, 11.6f);
            transform.eulerAngles = new Vector3(32, 135, 0);
        }
        else if (camCount == 3)
        {
            transform.position = new Vector3(11.85f, 8.2f, 11.6f);
            transform.eulerAngles = new Vector3(32, 225, 0);
        }
        else if (camCount == 4)
        {
            transform.position = new Vector3(10, 8.2f, -10.36f);
            transform.eulerAngles = new Vector3(32, 315, 0);
        }
        else
        {
            transform.position = new Vector3(12.15f, 6.89f, 0.13f);
            transform.eulerAngles = new Vector3(29, 270, 0);
        }
    }
}
