using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickPlayer : MonoBehaviour
{
    public Button[] button;
    public GameSystem management;
    void Start()
    {
        for (int i = 0; i < 370; i++)
        {
            button[i].onClick.AddListener(PlayerClicked);

        }
    }

    void PlayerClicked()
    {
        Debug.Log("Clicked on a player");
        management.timeofGame -= 1;
    }
}