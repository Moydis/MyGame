using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;

[RequireComponent(typeof(KonamiCode))]
public class CheatMode : MonoBehaviour
{
    private KonamiCode code;

    public Text successText;

    void Awake()
    {
        code = GetComponent<KonamiCode>();
    }

    void Update()
    {
        if (code.success)
        {
            successText.gameObject.SetActive(true);

           // void LoadScene(string sceneName)
            // {
               //  Debug.Log(Level3.ToString());

           //  }
        }
    }
}

