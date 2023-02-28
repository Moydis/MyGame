using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static Cinemachine.DocumentationSortingAttribute;
using Cursor = UnityEngine.Cursor;
public class LookingController : MonoBehaviour
{

    public float sensitivity = 5.0f;


    public Transform playerBody;

    float xRotation = 0f;


    void Start()
    {
        
       
        
    }


    void Update()
    {




        // Kontroller (kommer snart)
        float rightstickX = Input.GetAxis("Right Joystick X") * sensitivity * Time.deltaTime;
        float rightstickY = Input.GetAxis("Right Joystick Y") * sensitivity * Time.deltaTime;

        xRotation += rightstickY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, -90f, 0f);
        playerBody.Rotate(Vector3.up * rightstickX);
        



       
    }

}

