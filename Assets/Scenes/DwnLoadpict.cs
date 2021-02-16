using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
public class DwnLoadpict : MonoBehaviour
{
    public List<NumLevel> numberLevel;


    public string url = "https://www.tzargor.ru/";
    public SpriteRenderer sp;
    public Sprite[] sprPersonazh;
    public string[] textPersonazh;
    public Sprite[] sprHeir;
    public string[] textHair;
    public Sprite[] sprDress;
    public string[] textDress;

    public string[] folder;

    public string[] texter;
    public Image img;
    public string a;
    //  [Obsolete]
    [Obsolete]
    WWW www;
    [Obsolete]
    WWW www2;

    public int zagruzka;

    public Text txt;
  //  public Slider slider;
  //  public Text progressText;
    public GameObject[] go;
    // Start is called before the first frame update

     void Start()
    {
       

        StartCoroutine(LoadImages());
     }

 
    
    //   IEnumerator Start()
    IEnumerator LoadImages()
    {
        // Debug.Log(numberLevel[0].spriteLevelLocation[4]);
        //  a = textPersonazh[j];
      //  yield return new WaitForSeconds(0.0001f);
        for (int k = 0; k < 12; k++)
        {
            // if (zagruzka < 0)
            // {
            url = "https://www.tzargor.ru/Sprites/Location/0/Location/" + numberLevel[0].nameLevelLocation[k];
            // www2 = new WWW(url);
            www2 = new WWW(url);

                // Ожидаем загрузку ресурса
               yield return www2;
                var tex2 = www2.texture;

           // if (!www2.isDone)
           // {
                // Создаем спрайт из текстуры
                var mySprite2 = Sprite.Create(tex2, new Rect(0.0f, 0.0f, tex2.width, tex2.height), new Vector2(0.5f, 0.5f), 100.0f);
                // В подготовленный spriteRenderer вставляем спрайт
                numberLevel[0].spriteLevelLocation[k] = mySprite2;
            zagruzka = zagruzka + 4;
            //}
        }
    /*    if (!www2.isDone)
        {
            //       zagruzka = Mathf.RoundToInt(www2.progress * 100);
            Debug.Log("DownLoad2: " + Mathf.RoundToInt(www2.progress * 100) + "%");

        }
        else Debug.Log("Download2 100%");*/
        //   }
        //   numberLevel[0].spriteLevelLocation[4]

        //******************************************
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                if (i == 0)
                {
                    a = textPersonazh[j];
                    url = "https://www.tzargor.ru/Sprites/Personazh/" + folder[i] + "/" + a;
                    www = new WWW(url);

                    // Ожидаем загрузку ресурса
                   yield return www;
                    var tex = www.texture;
                    // Создаем спрайт из текстуры
                    var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                    // В подготовленный spriteRenderer вставляем спрайт
                    sprPersonazh[j] = mySprite;
                    zagruzka = zagruzka + 5;
                }
                if (i == 1)
                {
                    a = textHair[j];
                    url = "https://www.tzargor.ru/Personazh/" + folder[i] + "/" + a;
                    www = new WWW(url);

                    // Ожидаем загрузку ресурса
                    yield return www;
                    var tex = www.texture;
                    // Создаем спрайт из текстуры
                    var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                    // В подготовленный spriteRenderer вставляем спрайт
                    sprHeir[j] = mySprite;
                    zagruzka = zagruzka + 5;
                }
                if (i == 2)
                {
                    a = textDress[j];
                    url = "https://www.tzargor.ru/Personazh/" + folder[i] + "/" + a;
                    www = new WWW(url);

                    // Ожидаем загрузку ресурса
                    yield return www;
                    var tex = www.texture;
                    // Создаем спрайт из текстуры
                    var mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
                    // В подготовленный spriteRenderer вставляем спрайт
                    sprDress[j] = mySprite;
                    zagruzka = zagruzka + 5;
                    if (zagruzka >= 100)
                    {
                        zagruzka = 100;
                    }
                }

               // Debug.Log(folder[i]+"  " + a);
            }
           // zagruzka = zagruzka + 6;
        }
     /*   while (!www.isDone)
        {

            float progress = Mathf.Clamp01(www.progress / 0.9f);
            slider.value = progress;
            progressText.text = (progress * 100f).ToString("F0") + "%";

            yield return null;
        }*/

       /* if (!www.isDone)
        {

            Debug.Log("DownLoad2: " + Mathf.RoundToInt(www.progress * 100) + "%");

        }
        else Debug.Log("Download2 100%");*/
       
    }

  

    // Update is called once per frame
    void Update()
    {

        //*****************************************
       /* if (zagruzka < 50) {
            if (!www2.isDone)
            {
                 zagruzka = Mathf.RoundToInt(www2.progress * 100);
                Debug.Log("DownLoad2: " + Mathf.RoundToInt(www2.progress * 100) + "%");

            }
            else Debug.Log("Download2 100%");
        }
        if (zagruzka > 50)
        {
            if (!www.isDone)
            {
                  zagruzka = Mathf.RoundToInt(www.progress * 100);
                Debug.Log("DownLoad: " + Mathf.RoundToInt(100 + www.progress * 100) + "%");

            }
            else Debug.Log("Download 100%" + "%");
        }*/
        txt.text = zagruzka.ToString();
    }

    public int zak;
    public void Izmenit()
    {

        img.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[zak];
        zak = zak - 1;
      //  go[0].SetActive(true);
      //  txt.text = go[0].name.ToString();
       // go[1].SetActive(false);

     //   img.GetComponent<SpriteRenderer>().sprite = sprPersonazh[z];
    }
    public void Izmenit2()
    {
        img.GetComponent<SpriteRenderer>().sprite = numberLevel[0].spriteLevelLocation[zak];
        zak = zak + 1;
       // go[1].SetActive(true);
       // txt.text = go[1].name.ToString();
       // go[0].SetActive(false);

        //   img.GetComponent<SpriteRenderer>().sprite = sprPersonazh[z];
    }

}
[System.Serializable]
public struct NumLevel
{

    public Sprite[] spriteLevelLocation;
    public string[] nameLevelLocation;
}
