using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{

    public float Sensititvity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    

    

    void Update()
    {

        // Mus () 
        float mouseX = Input.GetAxis("Mouse X") * Sensititvity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensititvity * Time.deltaTime;

        xRotation -= mouseY;

        transform.localRotation = Quaternion.Euler(xRotation, -90f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);



        // Kontroller ()
        /*
        float rightstickX = Input.GetAxis("Right Joystick X") * Sensititvity * Time.deltaTime;
        float rightstickY = Input.GetAxis("Right Joystick Y") * Sensititvity * Time.deltaTime;
    
        xRotation += rightstickY;
         

        transform.localRotation = Quaternion.Euler(xRotation, -90f, 0f);
        playerBody.Rotate(Vector3.up * rightstickX); 
        */
     
       




    }
       
    
}

