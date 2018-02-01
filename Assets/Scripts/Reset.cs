using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public Button yourButton;
    public Scene WallyGame;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(ResetScene);
    }

    public void ResetScene()
    {
        Debug.Log("ResetScene");

        Application.LoadLevel(Application.loadedLevelName);
        //SceneManager.UnloadScene(WallyGame);
        //SceneManager.LoadScene("WallYGame", LoadSceneMode.Single);

    }
}