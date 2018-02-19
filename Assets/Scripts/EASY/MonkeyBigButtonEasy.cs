using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBigButtonEasy : MonoBehaviour {

    public MonkeyEasy MonkeyEasy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        MonkeyEasy.Clicked();
    }
}
