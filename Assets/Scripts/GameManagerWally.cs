using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerWally : MonoBehaviour, IGameManager
{
    public static GameManagerWally _instance;

    public static GameManagerWally Instance
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

    public float Score
    {
        get
        {
            throw new System.NotImplementedException();
        }
    }

    public float ScoreNeeded { get { return 0; } }

    public float MaxScore { get { return 0; } }

    public bool MaxScoreReached { get { return false; } }

    public int CurrentLevel { get { return 0; } }

    public int CurrentBooster { get { return 0; } }

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
