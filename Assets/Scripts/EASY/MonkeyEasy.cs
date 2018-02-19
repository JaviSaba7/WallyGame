using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyEasy : MonoBehaviour {

    public MonkeyBigButtonEasy BigButton;
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
        BigButton = go.GetComponent<MonkeyBigButtonEasy>();
        BigButton.MonkeyEasy = this;
        go.transform.localScale = Vector3.one;

    }

    public void SetNotChosen()
    {
        if (BigButton != null)
            DestroyImmediate(BigButton.gameObject);
        gameObject.SetActive(false);
        
    }

    public void SetChosen(GameObject prefab)
    {
        gameObject.SetActive(true);
        CreateButton(prefab);
    }
    public void Clicked()
    {
        GameSystemEasy.Instance.MonkeyClicked();

        //ShowEffetc();
    }
}
