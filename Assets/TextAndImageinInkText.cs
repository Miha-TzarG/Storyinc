using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAndImageinInkText : MonoBehaviour
{
    public Text txtDialog;
    public Text txtinImageinDialog;
    public Image imgInDialog;
    // Start is called before the first frame update
    void Start()
    {
        txtinImageinDialog.text = txtDialog.text;

      //  RectTransform uitransform = imgInDialog.GetComponent<RectTransform>();
      //  RectTransform uitransform2 = this.GetComponent<RectTransform>();
     //   uitransform.sizeDelta = uitransform2.sizeDelta;
        //   Debug.Log(txtDialog.rectTransform.);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
