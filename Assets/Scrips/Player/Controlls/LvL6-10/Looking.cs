using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{

    public float Sensititvity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }



    void Update()
    {

        // Mus () 
        float mouseX = Input.GetAxis("Mouse X") * Sensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensititvity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);




    }
       
    
}

