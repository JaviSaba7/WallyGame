using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Detection : MonoBehaviour
{
    public Camera camera;
    public bool detectingMonkey;
    public GameSystem management;
    public MaterialSwitcher matSwitcher;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit detection = new RaycastHit();
        Debug.DrawRay(ray.origin, ray.direction, Color.yellow);

        if (Physics.Raycast(ray, out detection, Mathf.Infinity))
        {
            detectingMonkey = true;
            
           
        }
        else
        {
            detectingMonkey = false;
        }

        if (detectingMonkey)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("WIN!");
                management.score += 1;
                matSwitcher.matRandom = Random.Range(0, 3);

            }
        }

        if (!detectingMonkey)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("LOSE!");
                management.timeofGame -= 1;
            }
        }
    }
}