﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using TMPro;

public class GameSystemNormal : MonoBehaviour {

    public Menu selector;

    public GameObject block;

    private static GameSystemNormal _instance;

    public static GameSystemNormal Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameSystemNormal>();

                if (_instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameSystemNormal";
                    _instance = go.AddComponent<GameSystemNormal>();
                }
            }

            return _instance;
        }
    }

    public float timeToStart = 3.0f;
    public float timeofGame = 30.0f;
    public float score = 8;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI counterToStartText;
    public TextMeshProUGUI gameTimeText;
    public bool startGame;
    public bool startToPlay;
    public GameObject characters;
    public DistributionNormal distribution;
    public GameObject reset;
    public float scoreForWin = 8;
    public bool stopTime = false;

    public float counter;
    public bool turnOff = false;
    public GameObject particleWin;
    public GameObject blockWin;

    // Use this for initialization
    void Start ()
    {
        score = scoreForWin;
        distribution.Randomize();
        startGame = true;
    }

    // Update is called once per frame
    void Update ()
    {
        if (turnOff) counter++;
        if (counter > 60)
        {
            particleWin.SetActive(false);
            Debug.Log("TIME PASADO");

            counter = 0;
            turnOff = false;
        }

        if (startGame)
        {
            counterToStartText.text = timeToStart.ToString("0");
            timeToStart -= Time.deltaTime;
        }

        if(timeToStart < 0)
        {
            counterToStartText.enabled = false;
            gameTimeText.enabled = true;
            startToPlay = true;
            timeToStart = 3;
            startGame = false;
        }
        if (timeToStart < 0.5)
        {
            counterToStartText.text = timeToStart.ToString("GO!");

        }

        if (stopTime == false)
        {
            if (startToPlay)
            {
                gameTimeText.text = timeofGame.ToString("0");
                timeofGame -= Time.deltaTime;
                characters.SetActive(true);

            }
        }

        //WIN CONDITION
        if (score <= 0)
        {
            GameManagerWally.Instance.Win();
            //characters.SetActive(false);
            selector.ClickUltra.SetActive(false);
            blockWin.SetActive(true); //Active a grey screen (blocking touch);
            reset.SetActive(true); //Active the reset
            stopTime = true;
        }

       //LOSE CONDITION
        if (timeofGame < 0.0f)
        {
            timeofGame = 0.0f;
            //characters.SetActive(false);
            selector.ClickNormal.SetActive(false);
            block.SetActive(true); //Active a grey screen (blocking touch);
            reset.SetActive(true); //Active the reset

           
            GameManagerWally.Instance.Loose();
        }

        scoreText.text = score.ToString("");

    }

    public void MonkeyClicked()
    {
        Debug.Log("Clicked on a monkey");
        particleWin.SetActive(true);
        turnOff = true;
        distribution.Randomize();
        score -= 1;
    }
}
    
