using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HistoryScript : MonoBehaviour
{

    public int numFace;
    public SpriteRenderer personazh;
    public Sprite[] vidPersonazha;

    public int numHair;
    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public int numDress;
    public Sprite[] Dress;
    public SpriteRenderer playerDress;

    public AudioClip Music;
    public AudioSource audioSource;
    public int musicOffOnn;
    // Start is called before the first frame update
    void Start()
    {
        musicOffOnn = PlayerPrefs.GetInt("Music");
        if (musicOffOnn == 0)
        {
            audioSource.enabled = true;
            // audioSource.PlayOneShot(Music);
        }
        else audioSource.enabled = false;
        StartCoroutine(pers());
        numFace = PlayerPrefs.GetInt("NumFace");

        numHair = PlayerPrefs.GetInt("NumHair");
        numDress = PlayerPrefs.GetInt("NumDress");
        //   numMackup = PlayerPrefs.GetInt("NumMackup");

    }

    IEnumerator pers()
    {
        yield return new WaitForSeconds(0.01f);
        for (int i = 0; i < vidPersonazha.Length; i++)
        {

            if (i == numFace)
            {
                personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[i];

            }


            if (i == numHair)
            {
                playerHair.GetComponent<SpriteRenderer>().sprite = Hair[i];

            }

            if (i == numDress)
            {
                playerDress.GetComponent<SpriteRenderer>().sprite = Dress[i];

            }
        }
        //*************personazh Dress

        //*************personazh Makup
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitScene()
    {
        SceneManager.LoadScene(1);
    }

}
