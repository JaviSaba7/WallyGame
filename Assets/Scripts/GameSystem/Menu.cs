using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject PracticeGameSystem;
    public GameObject EasyGameSystem;
    public GameObject NormalGameSystem;
    public GameObject HardGameSystem;
    public GameObject UltraGameSystem;

    public GameObject ClickTutorial;
    public GameObject ClickNormal;
    public GameObject ClickEasy;
    public GameObject ClickHard;
    public GameObject ClickUltra;


    public GameObject Buttons;
    //public GameSystem gameSystem;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void TutorialLevel()
    {
        GameManagerWally.Instance.StartGame(1);
        Debug.Log("Practice Level enabled");
        PracticeGameSystem.SetActive(true);
        ClickTutorial.SetActive(true);
        Buttons.SetActive(false);
    }

    public void EasyLevel()
    {
        GameManagerWally.Instance.StartGame(2);
        Debug.Log("Easy Level enabled");
        EasyGameSystem.SetActive(true);
        ClickEasy.SetActive(true);

        Buttons.SetActive(false);

    }

    public void NormalLevel()
    {
        GameManagerWally.Instance.StartGame(3);
        Debug.Log("Normal Level enabled");
        NormalGameSystem.SetActive(true);
        ClickNormal.SetActive(true);

        Buttons.SetActive(false);

    }

    public void HardLevel()
    {
        GameManagerWally.Instance.StartGame(4);
        Debug.Log("Hard Level enabled");
        HardGameSystem.SetActive(true);
        ClickHard.SetActive(true);

        Buttons.SetActive(false);

    }

    public void UltraLevel()
    {
        GameManagerWally.Instance.StartGame(5);
        Debug.Log("Ultra Level enabled");
        UltraGameSystem.SetActive(true);
        ClickUltra.SetActive(true);

        Buttons.SetActive(false);

    }
}
