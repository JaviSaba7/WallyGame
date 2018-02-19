﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickPlayerHard : MonoBehaviour
{
    public Button[] button;
    public GameSystemHard managementHard;
    public GameObject particleLose;
    public float counter;
    public bool turnOff = false;
    void Start()
    {
        for (int i = 0; i < 370; i++)
        {
            button[i].onClick.AddListener(PlayerClicked);

        }
    }

    void PlayerClicked()
    {
        Debug.Log("Clicked on a player");
        managementHard.timeofGame -= 1;
        particleLose.SetActive(true);
        turnOff = true;
    }
    void Update()
    {

        if (turnOff) counter++;
        if (counter > 60)
        {
            particleLose.SetActive(false);
            Debug.Log("TIME PASADO");

            counter = 0;
            turnOff = false;
        }

    }

}