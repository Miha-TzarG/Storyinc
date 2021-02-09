using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public Image img;

    public bool uvelich;

   public Vector3 v;

    public GameObject pn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 point = cam.WorldToViewportPoint(transform.position);
        Vector3 point= cam.ViewportToWorldPoint(new Vector2(.5f, .5f));
      //  v.x = point.x;
      //  v.y = point.y;
        if (uvelich)
        {

           // if (point.x <= 0.6f && point.x >= 0f + 0.4f)
          //  {
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

            img.color = new Color(255f, 255f, 255f, 1f);
            sp.sortingOrder = 1;
            this.transform.SetSiblingIndex(pn.transform.childCount);
            // point.x = 0.5f;
            //  Debug.Log(point);

            //  transform.position = Vector3.MoveTowards(this.transform.position, v, Time.deltaTime * 1f);
            // }
        }
        else
        {
            //  if (point.x > 0.6f && point.x < 0f + 0.4f)
            // {
            img.color = new Color(255f, 255f, 255f, .5f);

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
            sp.sortingOrder = 0;
            
            // }
        }

            /*  if ( point.x > 0.6f || point.x < 0f + 0.4f)
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
              }*/
        }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bg")
        {
            uvelich = true;
         //   Debug.Log(collision);
         //  v.x = collision.transform.position.x;
            //StartCoroutine(Umenshit());
            //  Debug.Log("sdss" + this.name);
        }
    }
    /*  public void OnTriggerEnter2D(Collider2D collision)
      {
          if (collision.tag == "Bg")
          {
              StartCoroutine(Umenshit());
            //  Debug.Log("sdss" + this.name);
          }
      }
      IEnumerator Umenshit()
      {
          yield return new WaitForSeconds(0.05f);
          Vector3 point = cam.WorldToViewportPoint(transform.position);

          if (point.x > 0.6f || point.x < 0f + 0.4f)
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
                  StopCoroutine(Umenshit());
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

          }
          StartCoroutine(Umenshit());
      }
    */
      public void OnTriggerExit2D(Collider2D collision)
      {
        if (collision.tag == "Bg")
        {
            uvelich = false;
            //StartCoroutine(Umenshit());
            //  Debug.Log("sdss" + this.name);
        }
    }

}
