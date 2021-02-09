using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InventoryScrypt : MonoBehaviour
{
    public int numFace;
    public Sprite[] spriteFace;
    public SpriteRenderer playerFace;
    public Text txtWhatFace;

   

    // Start is called before the first frame update
    void Start()
    {
        numFace = PlayerPrefs.GetInt("NumFace");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseFace(int numSpriteFace)
    {
        playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numSpriteFace];
        if(numSpriteFace == 0)
        {
            txtWhatFace.text = "Европейский тип лица";
        }
        if (numSpriteFace == 1)
        {
            txtWhatFace.text = "Смуглый тип лица";
        }
        numFace = numSpriteFace;
        PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.Save();

    }

    public void GoToScene(int numScene)
    {


        SceneManager.LoadScene(numScene);
    }


}
