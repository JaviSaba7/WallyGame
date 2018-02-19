using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectMonkey : MonoBehaviour {

    public GameSystem GameManager;
    public bool clickDetected;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      
        if (clickDetected)
        {
            //active fade in
            //active random
            //active fade out

        }
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("WALLY DETECTED!");
            GameManager.score += 1;
        }
        //score ++

        clickDetected = true;      
    }
}
