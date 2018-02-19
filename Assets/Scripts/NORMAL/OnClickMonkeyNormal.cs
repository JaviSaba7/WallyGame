using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickMonkeyNormal : MonoBehaviour
{
    public Button[] button;
    public GameObject particleWin;
    public float counter = 0;
    public bool turnOff = false;
    void Start()
    {
        for(int i = 0; i < 19; i++)
        {
            button[i].onClick.AddListener(MonkeyClicked);

        }
    }

    void MonkeyClicked()
    {

    }

    void Update()
    {

        
        
    }


}