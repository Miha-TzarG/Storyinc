using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Newimage : MonoBehaviour
{

    public Scrollbar sb;
    public Image[] img;


    public float newX;
    public float newY;

    public float oldX;
    public float oldY;

    public float speedUmenshenie;
    public float speedUvelichenie;
    public float speedScale;

    public GameObject pn;

    public int a;
    public Camera cam;

    public Image sp;

    public GameObject StartBtn;
    public GameObject RestartBtn;


    //  public RectTransform[] rt;
    // Start is called before the first frame update
    void Start()
    {
       // cam = GetComponent<Camera>();
        //   Debug.Log(pn.transform.childCount);

        //   rt[0] = img[0].GetComponent<RectTransform>();
        //   rt[1] = img[1].GetComponent<RectTransform>();
        //  rt.sizeDelta = new Vector2(54, 50);
    }

    // Update is called once per frame
    void Update()
    {
          Vector3 point = cam.WorldToViewportPoint(transform.position);
      
        if (point.y < 0f || point.y > 1f || point.x > 0.7f || point.x < 0f+0.3f)
        {
           // Debug.Log("dsad");
            sp.color = new Color(255f, 255f, 255f, .5f);

            oldX = oldX - speedUmenshenie;
            oldY = oldY - speedUmenshenie;
            if(oldX <= newX)
            {
                oldX = newX;
                oldY = newY;
                speedUmenshenie = 0;
                speedUvelichenie = speedScale ;
            }
            transform.localScale = new Vector2(oldX, oldY);
            // transform.localScale = new Vector2(newX, newY);
            StartBtn.SetActive(false);
            RestartBtn.SetActive(false);
         
         
        }
        else {
            //b = 0.001f;

            oldX = oldX + speedUvelichenie;
            oldY = oldY + speedUvelichenie;
            if (oldX >= newX+0.2f)
            {
                oldX = newX + 0.2f;
                oldY = newY + 0.2f;
                speedUvelichenie = 0;
                speedUmenshenie = speedScale;
            }
            transform.localScale = new Vector2(oldX, oldY);

            sp.color = new Color(255f, 255f, 255f, 1f);

           // transform.localScale = new Vector2(oldX, oldY);
            StartBtn.SetActive(true);
            RestartBtn.SetActive(true);
       this.transform.SetSiblingIndex(pn.transform.childCount);
        }
        /* if(sb.value <= 0.1f)
         {
             img[0].transform.localScale = new Vector2(newX, newY);
          //   img[0].transform.SetSiblingIndex(3);
             //   rt[0].sizeDelta = new Vector2(189, 244);
             // img[0].sizeDe = new Vector2(189,244);

         }
         else
         {
             img[0].transform.localScale = new Vector2(1f, 1f);
            // img[0].transform.SetSiblingIndex(1);
             // rt[0].sizeDelta = new Vector2(145, 186);
         }
         if (sb.value >= 0.40f && sb.value <= 0.50f)
         {
             img[1].transform.localScale = new Vector2(newX, newY);
           //  img[1].transform.SetSiblingIndex(3);

             ///  rt[1].sizeDelta = new Vector2(189, 244);


         }
         else
         {
             img[1].transform.localScale = new Vector2(1f, 1f);
            // img[1].transform.SetSiblingIndex(2);
             //   rt[1].sizeDelta = new Vector2(145, 186);
         }*/


    }
}
