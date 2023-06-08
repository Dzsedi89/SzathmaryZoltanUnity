using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    [SerializeField] CameraController cameraController;

    [SerializeField] float horizontalSensitivity = 1;
    [SerializeField] float verticalSensitivity = 1;
    [SerializeField] bool inverMouseVercitcal = true;

    
    void Update()
    {
        float mouseMovementX = Input.GetAxis("Mouse X");
        float mouseMovementY = Input.GetAxis("Mouse Y");

        cameraController.horizontalAngle += mouseMovementX * horizontalSensitivity;

        float verticalM = inverMouseVercitcal ? -1 : 1;
        cameraController.verticalAngle += mouseMovementY * verticalSensitivity * verticalM;

    }
}
