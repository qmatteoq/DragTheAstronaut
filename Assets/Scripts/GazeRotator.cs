using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeRotator : MonoBehaviour, IFocusable
{
    private bool isRotating;

    public void OnFocusEnter()
    {
        isRotating = true;
    }

    public void OnFocusExit()
    {
        isRotating = false;
    }

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up, 30 * Time.deltaTime);
        }
    }
}
