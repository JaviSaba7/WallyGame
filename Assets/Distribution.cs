using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distribution : MonoBehaviour {

    public Vector3[] positions;
    public SpriteRenderer[] sprites;
    public Sprite[] Sprites;
    // Use this for initialization
    void Start()
    {
        //sprites[0].transform.position = positions[0];
        //sprites[1].transform.position = positions[1];
        //sprites[2].transform.position = positions[2];

        //sprites[Random.Range(0, 3)].transform.position = positions[0];

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Distribute()
    {
        sprites[0].sprite = Sprites[Random.Range(0, 4)];
        sprites[1].sprite = Sprites[Random.Range(0, 4)];
        sprites[2].sprite = Sprites[Random.Range(0, 4)];
        //sprites[3].sprite = Sprites[Random.Range(0, 4)];



    }
    /*
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;
    public GameObject monkey;

    public Vector3[] positions = new Vector3[4];

    // Use this for initialization
    void Start ()
    {
        positions[0] = new Vector3(-42, -26, 180);
        positions[1] = new Vector3(-27, 63, 180);
        positions[2] = new Vector3(37, 9, 180);
        //positions[3] = new Vector3(32, -26, 180);

        image1.transform.position = new Vector3(0, 0, 200);
        image2.transform.position = new Vector3(0, 0,200);
        image3.transform.position = new Vector3(0, 0, 200);
        monkey.transform.position = new Vector3(0, 0, 200);
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    public void Distribute()
    {
        monkey.transform.position = positions[Random.Range(0, 3)];
        image1.transform.position = positions[Random.Range(0, 3)];
        image2.transform.position = positions[Random.Range(0, 3)];
        image3.transform.position = positions[Random.Range(0, 3)];

    }*/
}
