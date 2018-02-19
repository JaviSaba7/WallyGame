using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyTutorial : MonoBehaviour {

    public MonkeyBigButtonTutorial BigButtonTutorial;
	// Use this for initialization
	void Start () {
        
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
        BigButtonTutorial = go.GetComponent<MonkeyBigButtonTutorial>();
        BigButtonTutorial.MonkeyTutorial = this;
        go.transform.localScale = Vector3.one;

    }

    public void SetNotChosen()
    {
        if (BigButtonTutorial != null)
            DestroyImmediate(BigButtonTutorial.gameObject);
        gameObject.SetActive(false);
        
    }

    public void SetChosen(GameObject prefab)
    {
        gameObject.SetActive(true);
        CreateButton(prefab);
    }
    public void Clicked()
    {
        GameSystemTutorial.Instance.MonkeyClicked();

        //ShowEffetc();
    }
}
