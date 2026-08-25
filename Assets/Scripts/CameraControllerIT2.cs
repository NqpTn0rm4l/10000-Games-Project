using UnityEngine;

public class CameraControllerIT2 : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private GameObject[] cameraPresetLocation;

    public void moveCameraToPresetLocation(int presetPosition)
    {
        camera.transform.position = cameraPresetLocation[presetPosition].transform.position;
    }
}
