using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monkey : MonoBehaviour {

    public MonkeyBigButton BigButton;
	// Use this for initialization
	void Start () {
        BigButton = null;

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void CreateButton(GameObject prefab)
    {
        GameObject go = Instantiate(prefab);
        go.transform.position = transform.position;
        go.transform.SetParent(transform.parent);
        go.transform.SetAsLastSibling();
        BigButton = go.GetComponent<MonkeyBigButton>();
        BigButton.Monkey = this;
        
    }

    public void SetNotChosen()
    {
        if (BigButton != null) Destroy(BigButton.gameObject);
        gameObject.SetActive(false);
        
    }

    public void SetChosen(GameObject prefab)
    {
        gameObject.SetActive(true);
        CreateButton(prefab);
    }
    public void Clicked()
    {
        GameSystem.Instance.MonkeyClicked();

        //ShowEffetc();
    }
}
