using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{

    public float mouseSensititvity = 100f;

    public Transform playerBody;

    float xRotation = 0f;   

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensititvity * Time.deltaTime;

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, -90f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

