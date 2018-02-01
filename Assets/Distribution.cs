using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Distribution : MonoBehaviour {


    public Image[] Players_images;

    public List<Sprite> Sprites;

    public Image[] Monkeys;

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
        for (int k = 0; k < 1; k++)
        {
            Monkeys[Random.Range(0, 20)].gameObject.SetActive(true);
        }
    }
    public void DisableAll()
    {
        for (int k = 0; k < 20; k++)
        {
            Monkeys[k].gameObject.SetActive(false);
        }
    }
    
    public void Randomize()
    {
        for (int i = 0; i < Players_images.Length; i++)
        {
            int rdm = Random.Range(0, Sprites.Count);
            Players_images[i].sprite = Sprites[rdm];
        }
        DisableAll();
        EnableOneRandom();
        Debug.Log("Random players and monkeys");

    }

}
