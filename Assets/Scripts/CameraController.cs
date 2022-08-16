using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    float mouseSensitivity;

    [SerializeField]
    Transform player;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSensitivity;
        float rotAmountY = mouseY * mouseSensitivity;

        Vector3 rotPlayer = player.transform.rotation.eulerAngles;

        rotPlayer.x -= rotAmountY;
        rotPlayer.z = 0;
        rotPlayer.y += rotAmountX;
        player.transform.rotation = Quaternion.Euler(rotPlayer);
    }
}
