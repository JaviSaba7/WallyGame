using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyBigButton : MonoBehaviour {

    public Monkey Monkey;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Clicked()
    {
        Monkey.Clicked();
    }
}
