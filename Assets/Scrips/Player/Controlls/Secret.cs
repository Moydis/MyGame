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
        
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Level9")
        {
            Debug.Log("Hit an obstical");
            //transform.position = spawnPoint;
            Debug.Log(Level9.ToString());

            SceneManager.LoadScene("Level9");
        }


    }
}



