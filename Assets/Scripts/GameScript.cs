using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
   

    public Text txt;
   public string txtOtvet;

    public Text btntxt_01;
    public Text btntxt_02;

    public GameObject btn1;
    public GameObject btn2;
    public int a;
    public bool bl;

    public int variantOtveta;

    public Text whoSay;

    public int numFace;
    public SpriteRenderer personazh;
    public Sprite[] vidPersonazha;

    public int numHair;
    public Sprite[] Hair;
    public SpriteRenderer playerHair;

    public int numDress;
    public Sprite[] Dress;
    public SpriteRenderer playerDress;

  //  public int numMackup;
 //   public Sprite[] Mackup;
  //  public SpriteRenderer playerMackup;

    public AudioClip Music;
    public AudioSource audioSource;
    public int musicOffOnn;
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
        //*************personazh Body
      /*  if (numFace == 0)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[0];
        }
        if (numFace == 1)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[1];
        }
        if (numFace == 2)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[2];
        }
        if (numFace == 3)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[3];
        }*/
        //*************personazh Hair
       /* if (numHair == 0)
        {
            playerHair.GetComponent<SpriteRenderer>().sprite = Hair[0];
        }
        if (numHair == 1)
        {
            playerHair.GetComponent<SpriteRenderer>().sprite = Hair[1];
        }
        */
        for(int i=0; i< vidPersonazha.Length; i++)
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
    void Update()
    {
        if (bl)
        {
            if (Input.GetMouseButtonUp(0))

            {
                a = a + 1;
            }

            if (a == 1)
            {
                Next1();

            }

            if (a == 2)

            {

                Next2();

            }

            if (a == 3)
            {
                Next3();

            }
            if (a == 4)
            {
                Next4();

            }
            if (a == 5)
            {
                Next5();

            }
            if (a == 6)
            {
                Next6();

            }
          if (a == 7)
            {
                Next7();
         
            }
            if (a == 8)
            {
                Next8();

            }
            if (a == 9)
            {
                Next9();

            }
            if (a == 10)
            {
                Next10();

            }
            if (a == 11)
            {
                Next11();

            }
            if (a == 12)
            {
                Next12();

            }
            if (a == 13)
            {
                Next13();

            }
            if (a == 14)
            {
                Next14();

            }
            if (a == 15)
            {
                Next15();

            }
            if (a == 16)
            {
                Next16();

            }
            if (a == 17)
            {
                Next17();

            }
            if (a == 18)
            {
                Next18();

            }
            if (a == 19)
            {
                Next19();

            }
            if (a == 20)
            {
                Next20();

            }
            if (a == 21)
            {
                Next21();

            }
        }
    }

    public void CristinaSay()
    {
        whoSay.text = "Кристина"; 
        
        if (numFace == 0)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[2];

        }
        if (numFace == 1)
        {
            personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[3];
        }
    }
    public void KyleSay()
    {
        whoSay.text = "Кайл";
        personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[4];

    }
    public void Dialog1()
    {
        CristinaSay();
        txtOtvet = btntxt_01.text;
        if (txtOtvet == "Кто вы?")
        {
           Next1();
        }

       
        if (txtOtvet == "Я в больнице!?")
        {
            KyleSay();
            txt.text = "– С пробуждением, спящая красавица! \n\n Кристина с трудом повернула голову и увидела парня. \n\n Симпатичный, хотя что-то в его облике сразу показалось ей неправильным.";
            btntxt_01.text = "Кто вы?";
            btntxt_02.text = "Где я?";
            txtOtvet = "Кто вы?";
        }


        if (txtOtvet == "Рассердиться")
        {
           
            Next7();
        }
       
   
    }
    public void Dialog2()
    {
        txtOtvet = btntxt_02.text;
       // CristinaSay();
        if (txtOtvet == "Где я?")
        {
            variantOtveta = 1;
            Next1();
        }

       
        txtOtvet = btntxt_02.text;
        CristinaSay();
        if (txtOtvet == "У-у-ф… как же всё болит…")
        {
            KyleSay();
            txt.text = "– С пробуждением, спящая красавица! \n\n Кристина с трудом повернула голову и увидела парня. \n\n Симпатичный, хотя что-то в его облике сразу показалось ей неправильным.";

            btntxt_01.text = "Кто вы?";
            btntxt_02.text = "Где я?";

        }

        if (txtOtvet == "Посочувствовать")
        {

            Next7();
        }
        if (txtOtvet == "Выход")
        {
            ExitScene();
          //  SceneManager.LoadScene(1);
        }
        
    }

    public void Next1()
    {
        btn1.SetActive(false);
        btn2.SetActive(false);

        if (variantOtveta == 1)
        {
            KyleSay();
            txt.text = "– В клинике Петридж - парк.";
        }
        else
        {
            KyleSay();
            txt.text = "– Я - Кайл.";
        }
    
        bl = true;


    }
    public void Next2()
    {
        KyleSay();
        if (variantOtveta == 1)
        {
            
            txt.text = "– Меня зовут Кайл.";
        }
        else
        {
            txt.text = "– А ты Кристина.";
        }
 

    }
    public void Next3()
    {
        CristinaSay();
        if (variantOtveta == 1)
        {
            txt.text = "– Кристина…";
        }
        else
        {
            txt.text = "– Я в курсе…";
        }
 

    }
    public void Next4()
    {
        CristinaSay();
        txt.text = "– Вы – врач?";
  
    }
    public void Next5()
    {
        KyleSay();
        txt.text = "– Не-е-т! Я тоже тут… лежу.";
     

    }
    public void Next6()
    {
        bl = false;
        txt.text = "Кайл неопределённо покрутил рукой в воздухе.";

        btn1.SetActive(true);
        btn2.SetActive(true);

        btntxt_01.text = "Рассердиться";
        btntxt_02.text = "Посочувствовать";
    }
    public void Next7()
    {
        CristinaSay();
        if (variantOtveta == 1)
        {
            txt.text = "– Надеюсь, ничего серьёзного?";
        }
        else
        {
            txt.text = "В моей палате?";
        }
        bl = true;
        btn1.SetActive(false);
        btn2.SetActive(false);
    }

 
    public void Next8()
    {
        KyleSay();
        if (variantOtveta == 1)
        {
            
            txt.text = "– Ну… это как посмотреть…";
        }
        else
        {
            txt.text = "– Нет, конечно!";
        }
      

    }
    public void Next9()
    {
        KyleSay();
        if (variantOtveta == 1)
        {
            txt.text = "– Но ты не переживай!";
        }
        else
        {
            txt.text = "– В палате реанимации.";
        }
       
    }
    public void Next10()
    {
        if (variantOtveta == 1)
        {
            KyleSay();
            txt.text = "– Главное, я пока живой!";
        }
        else
        {
            CristinaSay();
            txt.text = "– И оттуда отпускают?";
        }
  

    }
    public void Next11()
    {
        if (variantOtveta == 1)
        {
            CristinaSay();
            txt.text = "– Да я вижу…  Скажи, ты в курсе, как я сюда попала?";
        }
        else
        {
            KyleSay();
            txt.text = "– Ну… им сложновато меня удержать.";
        }


    }
    public void Next12()
    {
        if (variantOtveta == 1)
        {
            KyleSay();
            txt.text = "– Кажется, тебя кто-то сбил…";
        }
        else
        {
            CristinaSay();
            txt.text = "– А у меня ты что забыл?";
        }
    

    }
    public void Next13()
    {
        if (variantOtveta == 1)
        {
            CristinaSay();
            txt.text = "– Сбил?";
        }
        else
        {
            KyleSay();
            txt.text = "– Да просто… захотелось пообщаться с кем-нибудь.";
        }
        

    }
    public void Next14()
    {
        if (variantOtveta == 1)
        {
            CristinaSay();
            txt.text = "– Чёрт, ничего не помню!";
        }
        else
        {
            KyleSay();
            txt.text = "– Мне это теперь тяжеловато сделать…";
        }
      
    }
    public void Next15()
    {
        if (variantOtveta == 1)
        {
            txt.text = "Кристина откинулась на подушку и закрыла глаза, пытаясь вспомнить…";
        }
        else
        {
            //  CristinaSay();
            if (numFace == 0)
            {
                personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[1];

            }
            if (numFace == 1)
            {
                personazh.GetComponent<SpriteRenderer>().sprite = vidPersonazha[0];
            }
            txt.text = "– Что, уже всех тут успел достать?";
        }
       

    }
    public void Next16()
    {
        if (variantOtveta == 1)
        {
            txt.text = "End of story";
            bl = false;
            btn2.SetActive(true);
            btntxt_02.text = "Выход";

        }
        else
        {
            CristinaSay();
            txt.text = "– Ладно уж, раз ты уже здесь…  Скажи, ты в курсе, как я сюда попала?";
        }
       

    }

    public void Next17()
    {
        KyleSay();
        txt.text = "– Кажется, тебя кто-то сбил…";
        

    }

    public void Next18()
    {
        CristinaSay();
        txt.text = "– Сбил?";
       

    }

    public void Next19()
    {
        CristinaSay();
        txt.text = "– Чёрт, ничего не помню!";
      

    }
    public void Next20()
    {
        txt.text = "Кристина откинулась на подушку и закрыла глаза, пытаясь вспомнить…";
      
    }
    public void Next21()
    {
        txt.text = "End of story";
        bl = false;
        btn2.SetActive(true);
        btntxt_02.text = "Выход";

    }
   

    public void ExitScene()
    {
        SceneManager.LoadScene(1);
    }


}
