using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollRectSnap : MonoBehaviour
{
    public bool dragging = false;
    public RectTransform panel;
    public RectTransform center;
    public float[] distance;
    public float[] distReposition;
    public GameObject[] bttn;
    public int minButtonNum;
    public int bttnDistance;
    public int bttnLenght;

 /*   public float newX;
    public float newY;

    public float oldX;
    public float oldY;

    public float speedUmenshenie;
    public float speedUvelichenie;
    public float speedScale;*/

    public nimgTest newImage;

    // Start is called before the first frame update
    void Start()
    {
        bttnLenght = bttn.Length;
        distance = new float[bttnLenght];
        distReposition = new float[bttnLenght];
        bttnDistance = (int)Mathf.Abs(bttn[1].GetComponent<RectTransform>().anchoredPosition.x - bttn[0].GetComponent<RectTransform>().anchoredPosition.x);

        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < bttn.Length; i++)
        {
            distReposition[i] = center.GetComponent<RectTransform>().position.x - bttn[i].GetComponent<RectTransform>().position.x;
            //      distance[i] = Mathf.Abs(center.transform.position.x - bttn[i].transform.position.x);
            distance[i] = Mathf.Abs(distReposition[i]);
            if(distReposition[i] > 6)
            {
                float curX = bttn[i].GetComponent<RectTransform>().anchoredPosition.x;
                float curY = bttn[i].GetComponent<RectTransform>().anchoredPosition.y;

                Vector2 newAnchoredPos = new Vector2(curX + (bttnLenght * bttnDistance), curY);
                bttn[i].GetComponent<RectTransform>().anchoredPosition = newAnchoredPos;       
            }
            if (distReposition[i] < -6)
            {
                float curX = bttn[i].GetComponent<RectTransform>().anchoredPosition.x;
                float curY = bttn[i].GetComponent<RectTransform>().anchoredPosition.y;

                Vector2 newAnchoredPos = new Vector2(curX - (bttnLenght * bttnDistance), curY);
                bttn[i].GetComponent<RectTransform>().anchoredPosition = newAnchoredPos;
            }
        }

        float minDistance = Mathf.Min(distance);

        for(int a = 0; a < bttn.Length; a++)
        {
            if(minDistance == distance[a])
            {
                minButtonNum = a;
            }
        }

        if (!dragging)
        {
            // LerpToBttn(minButtonNum * -bttnDistance);
            LerpToBttn(-bttn[minButtonNum].GetComponent<RectTransform>().anchoredPosition.x);
        //    Debug.Log("Nuzhniy: " + bttn[minButtonNum].GetComponent<nimgTest>());
            newImage = bttn[minButtonNum].GetComponent<nimgTest>();
        //    Debug.Log(bttn[minButtonNum]);
            newImage.uvelich = true;
            for(int b =0; b< bttn.Length; b++)
            {
                if (minButtonNum != b)
                {
                    newImage = bttn[b].GetComponent<nimgTest>();
                    newImage.uvelich = false;
                }
            }
     
        }
    //    else
       // {
           // Debug.Log("Drugie: " + bttn[minButtonNum].GetComponent<nimgTest>());
          //  newImage = bttn[minButtonNum++].GetComponent<nimgTest>();
         //   newImage.uvelich = false;
        //}

    }

    void LerpToBttn(float position)
    {
        float newX = Mathf.Lerp(panel.anchoredPosition.x, position, Time.deltaTime * 1f); //скорость возврата. стояло изначально 10
        Vector2 newPosition = new Vector2(newX, panel.anchoredPosition.y);

        panel.anchoredPosition = newPosition;

    }

    public void StartDrag()
    {
        dragging = true;
    }
    public void EndDrag()
    {
        dragging = false;
    }
}
