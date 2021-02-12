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

    public int numHair;
    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public int numDress;
    public Sprite[] Dress;
    public SpriteRenderer playerDress;

   // public int numMackup;
  //  public Sprite[] Mackup;
 //   public SpriteRenderer playerMackup;


    public GameObject PanelChooseBody;
    public GameObject PanelChooseHair;
    public GameObject PanelChooseDress;
    public GameObject PanelChooseMackup;

    // Start is called before the first frame update
    void Start()
    {
        numFace = PlayerPrefs.GetInt("NumFace");
        numHair = PlayerPrefs.GetInt("NumHair");
        numDress = PlayerPrefs.GetInt("NumDress");
    //    numMackup = PlayerPrefs.GetInt("NumMackup");
        playerFace.GetComponent<SpriteRenderer>().sprite = spriteFace[numFace];
        playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
        playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
      //  playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];

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
        Savepersonazh();
      /*  PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.Save();*/

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
        Savepersonazh();
        /*PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.Save();
        */
    }


    public void ChooseNextHair()
    {
        if (numHair + 1 > Hair.Length - 1)
        {
            numHair = Hair.Length - 1;
        }
        else
        {
            numHair = numHair + 1;
            playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
        }
        Savepersonazh();
        // playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
    }
    public void ChoosePreviousHair()
    {
        if (numHair - 1 < 0)
        {
            numHair = 0;
        }
        else
        {
            numHair = numHair - 1;
            playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
        }
        Savepersonazh();
        //  playerHair.GetComponent<SpriteRenderer>().sprite = Hair[numHair];
    }


    public void ChooseNextDress()
    {
        if (numDress + 1 > Dress.Length - 1)
        {
            numDress = Dress.Length - 1;
        }

        else
        {
            numDress = numDress + 1;
            playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
        }
        Savepersonazh();
        //playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }
    public void ChoosePrevoiusDress()
    {
        if (numDress - 1 < 0)
        {
            numDress = 0;
        }
        else
        {
            numDress = numDress - 1;
            playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
        }
        Savepersonazh();
        //  playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }


    public void ChooseNextMackup()
    {
      /*  if (numMackup + 1 > Mackup.Length - 1)
        {
            numMackup = Dress.Length - 1;
        }
        else
        {
            numMackup = numMackup + 1;
            playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];
        }
        Savepersonazh();*/
        //  playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }
    public void ChoosePreviousMackup()
    {
   /*     if (numMackup - 1 < 0)
        {
            numMackup = 0;
        }
        else
        {
            numMackup = numMackup - 1;
            playerMackup.GetComponent<SpriteRenderer>().sprite = Mackup[numMackup];
        }
        Savepersonazh();*/
        //playerDress.GetComponent<SpriteRenderer>().sprite = Dress[numDress];
    }

    // PanelChooseBody;
    // public GameObject PanelChooseHair;
    //public GameObject PanelChooseDress;
    //public GameObject PanelChooseMackup;

    public GameObject[] panelWhatChoose;
    public void WhatChooseBody(int numpanel)
    {
        for(int i =0; i < panelWhatChoose.Length; i++)
        {
            if (i == numpanel)
            {
                panelWhatChoose[i].SetActive(true);
            }
            else {
                panelWhatChoose[i].SetActive(false);
            }
        }

      //  Debug.Log(panelWhatChoose[numpanel]);

    }

    public void Savepersonazh()
    {
        PlayerPrefs.SetInt("NumFace", numFace);
        PlayerPrefs.SetInt("NumHair", numHair);
        PlayerPrefs.SetInt("NumDress", numDress);
      //  PlayerPrefs.SetInt("NumMackup", numMackup);
        
        PlayerPrefs.Save();
    }
    public void GoToScene(int numScene)
    {


        SceneManager.LoadScene(numScene);
    }


}
