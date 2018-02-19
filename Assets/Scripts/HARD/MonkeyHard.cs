using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyHard : MonoBehaviour {

    public MonkeyBigButtonHard BigButtonHard;
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
        BigButtonHard = go.GetComponent<MonkeyBigButtonHard>();
        BigButtonHard.MonkeyHard = this;
        go.transform.localScale = Vector3.one;

    }

    public void SetNotChosen()
    {
        if (BigButtonHard != null)
            DestroyImmediate(BigButtonHard.gameObject);
        gameObject.SetActive(false);
        
    }

    public void SetChosen(GameObject prefab)
    {
        gameObject.SetActive(true);
        CreateButton(prefab);
    }
    public void Clicked()
    {
        GameSystemHard.Instance.MonkeyClicked();

        //ShowEffetc();
    }
}
