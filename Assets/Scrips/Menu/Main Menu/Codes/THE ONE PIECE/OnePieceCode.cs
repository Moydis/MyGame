using System.Collections;
using UnityEngine;

public class OnePieceCode : MonoBehaviour
{
    private const float WaitTime = 1.0f;

    private KeyCode[] keys = new KeyCode[]
    {
        KeyCode.O,
        KeyCode.N,
        KeyCode.E,
        KeyCode.Space,
        KeyCode.P,
        KeyCode.I,
        KeyCode.E,
        KeyCode.C,
        KeyCode.E,
       
    };

    public bool success;

    IEnumerator Start()
    {
        float timer = 0f;
        int index = 0;

        while (true)
        {
            if (Input.GetKeyDown(keys[index]))
            {
                index++;

                if (index == keys.Length)
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
            else if (Input.anyKeyDown)
            {
                // print("Wrong key in sequence.");
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
