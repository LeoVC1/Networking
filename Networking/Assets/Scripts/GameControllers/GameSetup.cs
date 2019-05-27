﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameSetup : MonoBehaviour
{
    public static GameSetup GS;

    public Transform[] spawnPoints;

    public Image playerHealthBar;

    public GameObject escButtons;

    public RawImage minimapImage;


    private void OnEnable()
    {
        if(GS == null)
        {
            GS = this;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (escButtons.activeSelf == false)
            {
                Cursor.visible = true;
                escButtons.SetActive(true);
            }
            else
            {
                Cursor.visible = false;
                escButtons.SetActive(false);
            }
        }
    }

    public void OnButtonQuit()
    {
        Application.Quit();
    }
}
