using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBigButtonUltra : MonoBehaviour {

    public MonkeyUltra MonkeyUltra;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        MonkeyUltra.Clicked();
    }
}
