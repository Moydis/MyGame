using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{

    public float Sensititvity = 100f;
    public Joystick joystick;
    public Transform playerBody;

    float xRotation = 0f;
    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }



    void Update()
    {

        // Mus (virker veldig bra) 
        float mouseX = Input.GetAxis("Mouse X") * Sensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensititvity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        // Kontroller (virker greit men kameraet beveger av seg selv når denne leggest til)
        float stickX = Input.GetAxis("Right Joystick X") * Sensititvity * Time.deltaTime;
        float stickY = Input.GetAxis("Right Joystick Y") * Sensititvity * Time.deltaTime;

        xRotation -= stickY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * stickX);

       

    }


}

