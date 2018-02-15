using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DistributionEasy : MonoBehaviour {


    public Image[] Players_images;

    public List<Sprite> Sprites;

    public Image[] Monkeys;

    public GameObject BigButtonPrefab;
   

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void EnableOneRandom()
    {
        Monkeys[Random.Range(0, 19)].GetComponent<Monkey>().SetChosen(BigButtonPrefab);
        //for (int k = 0; k < 1; k++)
        //{
           
        //}
    }
    public void DisableAll()
    {
        for (int k = 0; k < 19; k++)
        {
            Monkeys[k].GetComponent<Monkey>().SetNotChosen();
        }
    }
    
    public void Randomize()
    {
        for (int i = 0; i < Players_images.Length; i++)
        {
            int rdm = Random.Range(0, Sprites.Count);
            Players_images[i].sprite = Sprites[rdm];
        }
       // Debug.Break();
        DisableAll();
        EnableOneRandom();
        //Debug.Log("Random players and monkeys");

    }

}
