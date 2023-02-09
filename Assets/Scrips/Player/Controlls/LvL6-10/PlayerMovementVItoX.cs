using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class PlayerMovementVItoX : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 spawnPoint;

    public Scene Level6;
    
    
   

   

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        spawnPoint = transform.position;

      //  for (int i = 0; i < Gamepad.all.Count; i++)
      //  {
       //     Debug.Log(Gamepad.all[i].name);
      //  }

    }

    void Update()
    {

        // Keyboard
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-25, 10, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-25, -25, 0);
        }


        // Kontroller kommer snart


       // if (Gamepad.all.Count > 0)
       // {
         //   if (Gamepad.all[0].dpad.up.wasPressedThisFrame)
          //  {

          //      GetComponent<Rigidbody>().velocity = new Vector3(-25, 10, 0);
         //   }


        //    if (Gamepad.all[0].dpad.down.isPressed)
       //    {
       //         GetComponent<Rigidbody>().velocity = new Vector3(-25, -25, 0);
       //     }
     //   }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstical2")
        {
            Debug.Log("Hit an obstical");
            //transform.position = spawnPoint;
            Debug.Log(Level6.ToString());

            SceneManager.LoadScene("Level6");
        }


    }
}