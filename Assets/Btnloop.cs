using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btnloop : MonoBehaviour
{
    public Transform PN;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(PN.transform.position.x, PN.transform.position.y);

    }
}
