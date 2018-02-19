using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBigButtonHard : MonoBehaviour {

    public MonkeyHard MonkeyHard;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        MonkeyHard.Clicked();
    }
}
