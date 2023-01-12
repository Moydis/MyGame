using System.Collections;
using UnityEngine;
<<<<<<< HEAD
=======
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05

public class KonamiCode : MonoBehaviour
{
    private const float WaitTime = 1.0f;

<<<<<<< HEAD
    private KeyCode[] keys = new KeyCode[]
    {
        KeyCode.UpArrow,
        KeyCode.UpArrow,
        KeyCode.DownArrow,
        KeyCode.DownArrow,
        KeyCode.LeftArrow,
        KeyCode.RightArrow,
        KeyCode.LeftArrow,
        KeyCode.RightArrow,
        KeyCode.B,
        KeyCode.A
=======
    private string[] axisNames = new string[]
    {
        "Vertical",
        "Vertical",
        "Vertical",
        "Vertical",
        "Horizontal",
        "Horizontal",
        "Horizontal",
        "Horizontal",
        "B",
        "A"
    };

    private float[] axes = new float[]
    {
        0,  // Up
        0,  // Up
        0,  // Down
        0,  // Down
        0,  // Left
        0,  // Right
        0,  // Left
        0,  // Right
        1,  // B
        1   // A
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05
    };

    public bool success;

    IEnumerator Start()
    {
        float timer = 0f;
        int index = 0;

        while (true)
        {
<<<<<<< HEAD
            if (Input.GetKeyDown(keys[index]))
            {
                index++;

                if (index == keys.Length)
=======
            float axisValue = Input.GetAxis(axisNames[index]);
            if (axisValue == axes[index])
            {
                index++;

                if (index == axes.Length)
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05
                {
                    success = true;
                    timer = 0f;
                    index = 0;
                }
                else
                {
                    timer = WaitTime;
                }
            }
<<<<<<< HEAD
            else if (Input.anyKeyDown)
            {
                // print("Wrong key in sequence.");
=======
            else if (Mathf.Abs(axisValue) > 0)
            {
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05
                timer = 0;
                index = 0;
            }

            if (timer > 0)
            {
                timer -= Time.deltaTime;

                if (timer <= 0)
                {
                    print("Reset timer");
                    timer = 0;
                    index = 0;
                }
            }

            yield return null;
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 4b88a7e643144132ca51beeadc12b444bd627a05
