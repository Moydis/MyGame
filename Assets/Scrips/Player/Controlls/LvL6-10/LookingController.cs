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

    public GameObject controller;
    public Rigidbody controllerRigidbody;
    

    


    void Start()
    {
        controllerRigidbody = controller.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        Vector3 targetPosition = controllerRigidbody.position + controllerRigidbody.transform.TransformDirection(direction) * sensitivity;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime);
    }

}

