using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLoop : MonoBehaviour
{
    public Camera cam;
    public GameObject pref;
    public GameObject pn;
    // Start is called before the first frame update
    void Start()
    {
        //cam = gameObject.GetComponent<Camera>();
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = cam.WorldToViewportPoint(transform.position);

        if (point.x > 1f )
        {
            this.transform.SetSiblingIndex(0);
           // GameObject c = Instantiate(pref) as GameObject;
           // c.transform.position = new Vector2(-246,15);
           // this.transform.position = new Vector2(transform.position.x-0.2f, transform.position.y);
        }
        if (point.x < 0f)
        {
            this.transform.SetSiblingIndex(pn.transform.childCount);
            // GameObject c = Instantiate(pref) as GameObject;
            // c.transform.position = new Vector2(-246,15);
            // this.transform.position = new Vector2(transform.position.x-0.2f, transform.position.y);
        }
    }

}
