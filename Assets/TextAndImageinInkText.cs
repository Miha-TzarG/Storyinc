using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAndImageinInkText : MonoBehaviour
{
    public string txtstr;
    public Text txtDialog;
    public Text txtinImageinDialog;
    public Text txtinImageinDialogNPC;
    public Text txtinImageinDialogMisly;

    public Text txtWhoSay;
  //  public Image imgInDialog;
 //   public Vector2 imgWhosay;
    public GameObject imgPlayer;
    public GameObject imgNPC;
    public GameObject imgMisly;

    public Sprite[] Bg;

    public InkScript Iscript;
    // Start is called before the first frame update
    void Start()
    {
     //   transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.5f);
        Iscript = GameObject.FindGameObjectWithTag("Ink").GetComponent<InkScript>();
        txtstr = Iscript.names;
        txtinImageinDialog.text = txtDialog.text;
        txtinImageinDialogNPC.text = txtDialog.text;
        txtinImageinDialogMisly.text = txtDialog.text;

        if (txtstr.Contains("Гвен"))
        {
            //Debug.Log("gven");
            imgPlayer.SetActive(true);
            imgNPC.SetActive(false);
            imgMisly.SetActive(false);
        }
        else
        {
            imgPlayer.SetActive(false);
            imgNPC.SetActive(true);
            imgMisly.SetActive(false);
        }

        if(txtstr == "")
        {
            transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.8f);
            imgMisly.SetActive(true);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
        }
       
        //  txtstr = txtWhoSay.text;

        /*   if (txtstr != "Гвен")
           {
               imgPlayer.SetActive(false);
               imgNPC.SetActive(true);

           }
           else
           {
               imgPlayer.SetActive(true);
               imgNPC.SetActive(false);
             //  imgInDialog.sprite = Bg[0];
              // imgWhosay.x = 200;
               //imgWhosay.transform.position = new Vector2(imgWhosay.transform.position.y-20, imgWhosay.transform.position.y);
           }*/
        StartCoroutine(Asd());
   
    //    imgInDialog.sprite = Bg[1];
      //  RectTransform uitransform = imgInDialog.GetComponent<RectTransform>();
      //  RectTransform uitransform2 = this.GetComponent<RectTransform>();
     //   uitransform.sizeDelta = uitransform2.sizeDelta;
        //   Debug.Log(txtDialog.rectTransform.);
    }
    IEnumerator Asd()
    {
        yield return new WaitForSeconds(0.001f);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
