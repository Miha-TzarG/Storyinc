using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameControl : MonoBehaviour
{
    public GameObject btnSetting;
    public GameObject btnExit;
    public GameObject panelSetting;
    public GameObject panelChoselvl;

    public GameObject btnSound;
    

    public Sprite[] sprBtnSound;

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

        btnSetting.GetComponent<Button>().OnButtonClick = delegate
        {
            OpenSetting();
       
        };

        btnExit.GetComponent<Button>().OnButtonClick = delegate
        {
            ExitGame();

        };



    }



    
    public void OpenSetting()
    {
        panelSetting.SetActive(true);
        panelChoselvl.SetActive(false);
        Debug.Log("Setting");
    }

    public void SoundOffOn()
    {
        //  btnSound.GetComponent<Image>();
        if (btnSound.GetComponent<Image>().sprite == sprBtnSound[0])
        {
            btnSound.GetComponent<Image>().sprite = sprBtnSound[1];
            audioSource.enabled = true;
            musicOffOnn = 0;
            PlayerPrefs.SetInt("Music", musicOffOnn);
            PlayerPrefs.Save();
        }
        else
        {
            btnSound.GetComponent<Image>().sprite = sprBtnSound[0];
            audioSource.enabled = false;
            musicOffOnn = 1;
            PlayerPrefs.SetInt("Music", musicOffOnn);
            PlayerPrefs.Save();
        }



        }

    public void StartGameScene()
    {
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Debug.Log("dsa");
        PlayerPrefs.SetInt("Music", musicOffOnn);
        PlayerPrefs.Save();
        Application.Quit();
    }
}
