using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{
    public float Sensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    Controller610 Controls;

    Vector2 rotate;
    // Start is called before the first frame update
    void Start()
    {
        Controls = new Controller610();
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Awake()
    {
        

       Controls.Gameplay.Rotate.performed += ctx => rotate = ctx.ReadValue<Vector2>();
       Controls.Gameplay.Rotate.performed += ctx => rotate = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
         float MouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
         float MouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

         xRotation -= MouseY;
         xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * MouseX);

        Vector2 r = new Vector2(-rotate.y, rotate.x) * Sensitivity * Time.deltaTime;
        transform.Rotate(r, Space.World);

    }
}