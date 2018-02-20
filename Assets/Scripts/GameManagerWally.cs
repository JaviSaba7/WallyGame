using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerWally : MonoBehaviour
{
    public GameManagerWally _instance;

    //public GameObject block;

    public GameManagerWally Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManagerWally>();

                if (_instance == null)
                {
                    GameObject go = new GameObject();
                    go.name = "GameManagerWally";
                    _instance = go.AddComponent<GameManagerWally>();
                }
            }

            return _instance;
        }
    }
    /*
    float Score { get; }
    float ScoreNeeded { get; }
    float MaxScore { get; }
    bool MaxScoreReached { get; }
    int CurrentLevel { get; }
    int CurrentBooster { get; }
    */
    public void Win()
    {

    }

    public void Loose()
    {

    }

    public void StartGame(int level)
    {

    }

    public void SetLevel(int level)
    {

    }

    public void CatchedSponsor(int type, float value)
    {

    }

    public void RestartGame()
    {

    }

    public void StartPractice()
    {

    }

    public void SetAudio()
    {

    }
}
