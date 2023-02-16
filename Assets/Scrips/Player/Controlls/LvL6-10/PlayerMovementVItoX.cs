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

    private Rigidbody _rigidbody;

    private Transform _transform;


    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
        spawnPoint = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
        _transform = transform;

          for (int i = 0; i < Gamepad.all.Count; i++)
          {
             Debug.Log(Gamepad.all[i].name);
          }
        
    }

    void Update()
    {

        // Keyboard
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forward = _transform.forward * 25;
            Vector3 upward = _transform.up * 10;
            _rigidbody.velocity = forward + upward;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Vector3 forward = _transform.forward * 25;
            Vector3 downward = _transform.up * -25;
            _rigidbody.velocity = forward + downward;
        }


        // Kontroller kommer snart

        /*
        if (Gamepad.all.Count > 0)
        {
            if (Gamepad.all[0].dpad.up.wasPressedThisFrame)
            {
                Vector3 forward = _transform.forward * 25;
                Vector3 upward = _transform.up * 10;
                _rigidbody.velocity = forward + upward;
            }
            if (Gamepad.all[0].dpad.down.isPressed)
            {
                Vector3 forward = _transform.forward * 25;
                Vector3 downward = _transform.up * -25;
                _rigidbody.velocity = forward + downward;
            }
        }*/ 
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