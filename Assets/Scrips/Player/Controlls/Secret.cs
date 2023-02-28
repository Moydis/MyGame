using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static Cinemachine.DocumentationSortingAttribute;
using Cursor = UnityEngine.Cursor;

public class Secret : MonoBehaviour
{
    public Vector3 spawnPoint;

    public Scene Level9;

    private Rigidbody _rigidbody;

    private Transform _transform;

    

    

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        spawnPoint = transform.position;
        _rigidbody = GetComponent<Rigidbody>();
        _transform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = _transform.forward * 10;
            _rigidbody.velocity = forward;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Vector3 left = -_transform.right * 10;
            _rigidbody.velocity = left;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 backward = -_transform.forward * 10;
            _rigidbody.velocity = backward;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Vector3 right = _transform.right * 10;
            _rigidbody.velocity = right;
        }
        else
        {
            
            _rigidbody.velocity = Vector3.zero;
        }
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Level9")
        {
            Debug.Log("Back to Level 9");
            //transform.position = spawnPoint;
            Debug.Log(Level9.ToString());

            SceneManager.LoadScene("Level9");
        }


    }
}



