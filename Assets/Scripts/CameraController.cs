using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera[] cameras;
    [SerializeField] private int currentCameraNumber = 0;
    private void Start()
    {
        activeCamera();
    }
    public void switchCamera(int currentCameraNumber)
    {
        if (currentCameraNumber >= cameras.Length)
        {
            currentCameraNumber = 0;
        }
        activeCamera();
    }
    private void activeCamera()
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].enabled = (i == currentCameraNumber);
        }
    }
}
