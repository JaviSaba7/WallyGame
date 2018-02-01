using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickMonkey : MonoBehaviour
{
    public Button[] button;
    public GameSystem management;
    public Distribution distribution;
    void Start()
    {
        for(int i = 0; i < 20; i++)
        {
            button[i].onClick.AddListener(MonkeyClicked);

        }
    }

    void MonkeyClicked()
    {
        Debug.Log("Clicked on a monkey");
        distribution.Randomize();
        management.score += 1;
    }
}