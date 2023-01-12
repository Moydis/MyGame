using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEditor.Experimental.GraphView.GraphView;

public class KonamiCode : MonoBehaviour
{
    private const float WaitTime = 1.0f;

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
    };

    public bool success;

    IEnumerator Start()
    {
        float timer = 0f;
        int index = 0;

        while (true)
        {
            float axisValue = Input.GetAxis(axisNames[index]);
            if (axisValue == axes[index])
            {
                index++;

                if (index == axes.Length)
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
            else if (Mathf.Abs(axisValue) > 0)
            {
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
}