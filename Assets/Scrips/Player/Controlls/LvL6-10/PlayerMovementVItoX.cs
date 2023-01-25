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
    Controller610 Controls;

    
   

    void Awake()
    {
        Controls = new Controller610();

        Controls.Gameplay.MoveUp.performed += ctx => MoveUp();

        Controls.Gameplay.MoveDown.performed += ctx => MoveDown();

      
    }

    void MoveUp()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(-15, 10, 0);
    }

  
    void MoveDown()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, -25, 0);
    }

    void OnEnable()
    {
        Controls.Gameplay.Enable();
        
    }

    void OnDisable()
    {
        Controls.Gameplay.Disable();
        
    }

    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;

        spawnPoint = transform.position;
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            Debug.Log(Gamepad.all[i].name);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
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