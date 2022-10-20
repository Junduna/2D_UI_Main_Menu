using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public void print(bool value)
    {
        if (value)
        {
            Debug.Log("Mute");
        } else
        {
            Debug.Log("On");
        }
    }

    public void OptVolume (float volume)
    {
        Debug.Log(volume);
    }
}
