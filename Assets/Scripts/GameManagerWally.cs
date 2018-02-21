using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerWally : MonoBehaviour, IGameManager
{
    public Menu selector;
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


    int casesSwitch = 5;

    //1-Tutorial 2-Easy 3-Normal 4-Hard 5-Ultra
    public void StartGame(int level)
    {
        switch (casesSwitch)
        {
            case 1:
                {
                    Debug.Log("Tutorial");
                    selector.TutorialLevel();
                }
                break;

            case 2:
                  {
                      Debug.Log("Easy");
                      selector.EasyLevel();
                  }
                  break;
            case 3:
                 {
                     Debug.Log("Normal");
                     selector.NormalLevel();
                 }
                 break;

            case 4:
                  {
                     Debug.Log("Hard");
                     selector.HardLevel();
                  }
                  break;

            case 5:
                  {
                       Debug.Log("Ultra");
                       selector.UltraLevel();
                  }
                  break;

            default:
                Debug.Log("Default"); 
                break;
        }
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
