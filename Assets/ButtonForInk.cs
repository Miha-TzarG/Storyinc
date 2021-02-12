using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonForInk : MonoBehaviour
{
    public Button bt;
    public RectTransform btn;
    public Text txt;
    public HistoryScript hs;
    // Start is called before the first frame update
    void Start()
    {
       /* bt.OnButtonClick = delegate
        {
            NewPers();
        };*/

        //  btn.rect.height = txt.rect.height;
    
      //  Rect rectContainer = txt.GetComponent<RectTransform>().rect;
       // Debug.Log(rectContainer.height);
    }

    public void NewPers()
    {
        if (txt.text == "Европейская")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.personazh.GetComponent<SpriteRenderer>().sprite = hs.vidPersonazha[2];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
        if (txt.text == "Азиатская")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.personazh.GetComponent<SpriteRenderer>().sprite = hs.vidPersonazha[0];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
        if (txt.text == "Афроамериканская")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.personazh.GetComponent<SpriteRenderer>().sprite = hs.vidPersonazha[1];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
        if (txt.text == "Латиноамериканская")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.personazh.GetComponent<SpriteRenderer>().sprite = hs.vidPersonazha[3];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
        if (txt.text == "Простой")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.playerDress.GetComponent<SpriteRenderer>().sprite = hs.Dress[0];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
        if (txt.text == "Стильный")
        {
            hs = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
            hs.playerDress.GetComponent<SpriteRenderer>().sprite = hs.Dress[1];
            //	cam = GameObject.FindObjectOfType<Camera>().GetComponent<HistoryScript>();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
