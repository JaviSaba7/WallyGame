using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyUltra : MonoBehaviour {

    public MonkeyBigButtonUltra BigButtonUltra;
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
        BigButtonUltra = go.GetComponent<MonkeyBigButtonUltra>();
        BigButtonUltra.MonkeyUltra = this;
        go.transform.localScale = Vector3.one;

    }

    public void SetNotChosen()
    {
        if (BigButtonUltra != null)
            DestroyImmediate(BigButtonUltra.gameObject);
        gameObject.SetActive(false);
        
    }

    public void SetChosen(GameObject prefab)
    {
        gameObject.SetActive(true);
        CreateButton(prefab);
    }
    public void Clicked()
    {
        GameSystemUltra.Instance.MonkeyClicked();

        //ShowEffetc();
    }
}
