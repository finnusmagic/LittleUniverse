using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public static bool isOn = false;

    void Start()
    {

    }

    public void TogglePauseMenu()
    {
        gameObject.SetActive(!gameObject.activeSelf);
        PauseMenu.isOn = gameObject.activeSelf;
    }
}
