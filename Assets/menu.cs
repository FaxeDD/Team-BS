﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void clickOnPlay()
    {
        SceneManager.LoadScene("Fin du Game");
    }

    public void onQuit()
    {
        Application.Quit();
    }
}
