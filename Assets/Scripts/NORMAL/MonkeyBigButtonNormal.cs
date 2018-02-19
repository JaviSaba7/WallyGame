using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBigButtonNormal : MonoBehaviour {

    public MonkeyNormal MonkeyNormal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        MonkeyNormal.Clicked();
    }
}
