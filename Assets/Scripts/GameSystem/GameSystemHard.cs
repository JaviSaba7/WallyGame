using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using TMPro;

public class GameSystemHard : MonoBehaviour {

    private static GameSystemHard _instance;

    public static GameSystemHard Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameSystemHard>();

                if (_instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameSystemHard";
                    _instance = go.AddComponent<GameSystemHard>();
                }
            }

            return _instance;
        }
    }

    public float timeToStart = 3.0f;
    public float timeofGame = 30.0f;
    public float score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI counterToStartText;
    public TextMeshProUGUI gameTimeText;
    public bool startGame;
    public bool startToPlay;
    public GameObject characters;
    public DistributionHard distribution;
    public GameObject reset;

    public float counter;
    public bool turnOff = false;
    public GameObject particleWin;

    // Use this for initialization
    void Start ()
    {
        score = 0;
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

        if(startToPlay)
        {
            gameTimeText.text = timeofGame.ToString("0");
            timeofGame -= Time.deltaTime;
            characters.SetActive(true);
            
        }

        if (timeofGame < 0.0f)
        {
            timeofGame = 0.0f;
            reset.SetActive(true);
            //characters.SetActive(false);

        }

        scoreText.text = score.ToString("");

    }

    public void MonkeyClicked()
    {
        Debug.Log("Clicked on a monkey");
        particleWin.SetActive(true);
        turnOff = true;
        distribution.Randomize();
        score += 1;
    }
}
    
