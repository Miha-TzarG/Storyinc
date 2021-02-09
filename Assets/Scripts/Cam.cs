using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Screen.width >= 1440 && Screen.height >= 2760)
        {

            GetComponent<Camera>().orthographicSize = 5.18f;
        }

        if (Screen.width < 1440 && Screen.height < 2760)
        {

            GetComponent<Camera>().orthographicSize = 6.25f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
