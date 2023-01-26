using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class Looking : MonoBehaviour
{
    public float Sensitivity = 100f;
    public Transform Llama;
    float xRotation = 0f;

   
    // Start is called before the first frame update
    void Start()
    {
        
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Awake()
    {
        

       
    }

    // Update is called once per frame
    void Update()
    {

        // Lar musa gå brrrrrrrrrrr
         float MouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
         float MouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

         xRotation -= MouseY;
         xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Llama.Rotate(Vector3.up * MouseX);

        
    }
}