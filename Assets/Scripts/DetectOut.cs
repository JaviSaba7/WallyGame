using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectOut : MonoBehaviour {

    public GameSystem GameManager;
    public bool clickDetected;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("-1s");
            GameManager.timeofGame -= 1;
        }
    }
}
