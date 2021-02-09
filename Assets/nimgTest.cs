using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nimgTest : MonoBehaviour
{
    public float newX;
    public float newY;

    public float oldX;
    public float oldY;

    public float speedUmenshenie;
    public float speedUvelichenie;
    public float speedScale;
    public Camera cam;
    public SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = cam.WorldToViewportPoint(transform.position);

        if ( point.x > 0.6f || point.x < 0f + 0.4f)
        {
            // Debug.Log("dsad");
         sp.color = new Color(255f, 255f, 255f, .5f);

            oldX = oldX - speedUmenshenie;
            oldY = oldY - speedUmenshenie;
            if (oldX <= newX)
            {
                oldX = newX;
                oldY = newY;
                speedUmenshenie = 0;
                speedUvelichenie = speedScale;
            }
            transform.localScale = new Vector2(oldX, oldY);
            // transform.localScale = new Vector2(newX, newY);
        //    StartBtn.SetActive(false);
      //      RestartBtn.SetActive(false);


        }
        else
        {
            //b = 0.001f;

            oldX = oldX + speedUvelichenie;
            oldY = oldY + speedUvelichenie;
            if (oldX >= newX + 0.2f)
            {
                oldX = newX + 0.2f;
                oldY = newY + 0.2f;
                speedUvelichenie = 0;
                speedUmenshenie = speedScale;
            }
            transform.localScale = new Vector2(oldX, oldY);

            sp.color = new Color(255f, 255f, 255f, 1f);

            // transform.localScale = new Vector2(oldX, oldY);
            //StartBtn.SetActive(true);
           // RestartBtn.SetActive(true);
         //   this.transform.SetSiblingIndex(pn.transform.childCount);
        }
    }
}
