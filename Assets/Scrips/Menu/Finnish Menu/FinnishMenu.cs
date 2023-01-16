using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using Cursor = UnityEngine.Cursor;
public class FinnishMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }
}
