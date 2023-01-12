using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public GameObject mainFirstButton, optionsFirstButton ,optionCloseButton; // , controlCloseButton , controlFirstButton
=======
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
// using UnityEngine.InputSystem;
public class MainMenu : MonoBehaviour
{

   
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05

    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
