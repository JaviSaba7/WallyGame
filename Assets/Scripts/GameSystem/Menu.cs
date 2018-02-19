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

    public void PracticeLevel()
    {
        Debug.Log("Practice Level enabled");
        PracticeGameSystem.SetActive(true);
        ClickTutorial.SetActive(true);
        Buttons.SetActive(false);
    }

    public void EasyLevel()
    {
        Debug.Log("Easy Level enabled");
        EasyGameSystem.SetActive(true);
        ClickEasy.SetActive(true);

        Buttons.SetActive(false);
    }

    public void NormalLevel()
    {
        Debug.Log("Normal Level enabled");
        NormalGameSystem.SetActive(true);
        ClickNormal.SetActive(true);

        Buttons.SetActive(false);
    }

    public void HardLevel()
    {
        Debug.Log("Hard Level enabled");
        HardGameSystem.SetActive(true);
        ClickHard.SetActive(true);

        Buttons.SetActive(false);
    }

    public void UltraLevel()
    {
        Debug.Log("Ultra Level enabled");
        UltraGameSystem.SetActive(true);
        ClickUltra.SetActive(true);

        Buttons.SetActive(false);
    }
}
