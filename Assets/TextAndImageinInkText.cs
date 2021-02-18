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
    public Text txtinImageinDialogPodskazka;

    public Text txtWhoSay;
  //  public Image imgInDialog;
 //   public Vector2 imgWhosay;
    public GameObject imgPlayer;
    public GameObject imgNPC;
    public GameObject imgMisly;
    public GameObject imgPodskazka;


    public Sprite[] Bg;

    public InkScript Iscript;

    public GameObject cam;
    public GameObject left;
    public bool leftbool;
    public GameObject right;
    public bool rightbool;
    public GameObject center;
    public bool centerbool;
    public float speed;

    public SpriteRenderer spriteNPC;
    public SpriteRenderer spritePlayer;
    public SpriteRenderer spritePlayerHair;
    public SpriteRenderer spritePlayerDress;
    public float prozrachnostPlayer;
    public float prozrachnostNPC;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("Location");
        left= GameObject.FindGameObjectWithTag("Left");
        right = GameObject.FindGameObjectWithTag("Right");
        center = GameObject.FindGameObjectWithTag("Center");
        spriteNPC = GameObject.FindGameObjectWithTag("NPC").GetComponent<SpriteRenderer>();
        spritePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        spritePlayerHair = GameObject.FindGameObjectWithTag("Hair").GetComponent<SpriteRenderer>();
        spritePlayerDress = GameObject.FindGameObjectWithTag("Dress").GetComponent<SpriteRenderer>();

        //   transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.5f);
        Iscript = GameObject.FindGameObjectWithTag("Ink").GetComponent<InkScript>();
        txtstr = Iscript.names;
        txtinImageinDialog.text = txtDialog.text;
        txtinImageinDialogNPC.text = txtDialog.text;
        txtinImageinDialogMisly.text = txtDialog.text;
        txtinImageinDialogPodskazka.text = txtDialog.text;

        if (txtstr.Contains("Персефона"))
        {
            //Debug.Log("gven");
            imgPlayer.SetActive(true);
            imgNPC.SetActive(false);
            imgMisly.SetActive(false);
            imgPodskazka.SetActive(false);
            
            leftbool = true;
            rightbool = false;
            centerbool = false;
            StartCoroutine(Dvizhenielocation());
        }
        else
        {
            imgPlayer.SetActive(false);
            imgNPC.SetActive(true);
            imgMisly.SetActive(false);
            imgPodskazka.SetActive(false);
            leftbool = false;
            rightbool = true;
            centerbool = false;

            StartCoroutine(Dvizhenielocation());
          
        }

        if(txtstr == "" || txtstr == "window")
        {
            transform.position = new Vector2(transform.position.x + 0.15f, transform.position.y + 3.8f);
            imgMisly.SetActive(true);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgPodskazka.SetActive(false);
            leftbool = false;
            rightbool = false;
            centerbool = true;
            StartCoroutine(Dvizhenielocation());
        }
        if (txtstr == "Podskazka")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            imgMisly.SetActive(false);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgPodskazka.SetActive(true);
            leftbool = false;
            rightbool = false;
            centerbool = true;
           txtstr = "Персефона";
            StartCoroutine(Dvizhenielocation());
        }

     /*   if (txtstr == "window")
        {
            transform.position = new Vector2(transform.position.x, transform.position.y);
            imgMisly.SetActive(true);
            imgPlayer.SetActive(false);
            imgNPC.SetActive(false);
            imgPodskazka.SetActive(false);
           // leftbool = false;
           // rightbool = false;
          //  centerbool = true;
            //txtstr = "Персефона";
           // StartCoroutine(Dvizhenielocation());
        }
     */
        StartCoroutine(Asd());
 
    }
    IEnumerator Asd()
    {
        yield return new WaitForSeconds(0.001f);
     
    }

    IEnumerator Dvizhenielocation()
    {
        yield return new WaitForSeconds(0.001f);
        if (leftbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
            if (cam.transform.position != right.transform.position  && prozrachnostPlayer != 1 || prozrachnostNPC != 0)
            {
                
              
               
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer + 0.02f;

                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC - 0.02f;

                StartCoroutine(Dvizhenielocation());
            }
        }
        if (rightbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, speed * Time.deltaTime);
            if (cam.transform.position != left.transform.position && prozrachnostNPC != 1 || prozrachnostPlayer != 0)
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                prozrachnostPlayer = prozrachnostPlayer - 0.02f;

                
                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                prozrachnostNPC = prozrachnostNPC + 0.02f;

                StartCoroutine(Dvizhenielocation());
            }
            
        }
        if (centerbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, center.transform.position, speed * Time.deltaTime);
            if (cam.transform.position != center.transform.position || prozrachnostNPC != 0 || prozrachnostPlayer != 0)
            {
                spritePlayer.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerHair.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
                spritePlayerDress.color = (new Color(255f, 255f, 255f, prozrachnostPlayer));
             //   if (prozrachnostPlayer > 250)
              //  {
                    prozrachnostPlayer = prozrachnostPlayer - 0.02f;
              //  }
               // else
               // {
               //     prozrachnostPlayer = 0;
                //}
                spriteNPC.color = (new Color(255f, 255f, 255f, prozrachnostNPC));
                
                prozrachnostNPC = prozrachnostNPC - 0.02f;

                StartCoroutine(Dvizhenielocation());
            }
        }
   
    }

    void Update()
    {
      /*  if (leftbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, right.transform.position, speed * Time.deltaTime);
        }
        if (rightbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, left.transform.position, speed * Time.deltaTime);
        }
        if (centerbool)
        {
            cam.transform.position = Vector3.MoveTowards(cam.transform.position, center.transform.position, speed * Time.deltaTime);
        }*/
    }
}
