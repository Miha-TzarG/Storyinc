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

    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public Sprite[] Dress;
    public SpriteRenderer playerDress;

    // Start is called before the first frame update
    void Start()
    {
        numFace = PlayerPrefs.GetInt("NumFace");
        playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseFace()
    {


        if (numFace + 1 > spriteFace.Length-1)
        {
            numFace = spriteFace.Length-1;
        }
        else
        {
            numFace = numFace + 1;
            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }
        /*   playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numSpriteFace];
           if(numSpriteFace == 0)
           {
               txtWhatFace.text = "Европейский тип лица";
           }
           if (numSpriteFace == 1)
           {
               txtWhatFace.text = "Смуглый тип лица";
           }*/
        //   numFace = numSpriteFace;
        PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.Save();

    }
    public void PrevChooseFace()
    {
      
        if (numFace-1 < 0)
        {
            numFace = 0;
        }
        else
        {
            numFace = numFace - 1;
            playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        }
       // Debug.Log(numFace);
        /*   playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numSpriteFace];
           if(numSpriteFace == 0)
           {
               txtWhatFace.text = "Европейский тип лица";
           }
           if (numSpriteFace == 1)
           {
               txtWhatFace.text = "Смуглый тип лица";
           }*/
        //   numFace = numSpriteFace;
        PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.Save();

    }


    public void ChooseHair(int numHair)
    {
        playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
    }
    public void ChooseDress(int numDress)
    {
        playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }

    public void GoToScene(int numScene)
    {


        SceneManager.LoadScene(numScene);
    }


}
