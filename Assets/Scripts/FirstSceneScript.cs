using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirstSceneScript : MonoBehaviour
{
    public Slider slider;
    public Text progressText;
    // Start is called before the first frame update
    void Start()
    {
  

        StartCoroutine(Zapusk());
     
    }
    IEnumerator Zapusk()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(LoadAsync(1));
    }
    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
     

        while (!operation.isDone)
        {

            float progress = Mathf.Clamp01(operation.progress / 0.9f); 
         slider.value = progress;
            progressText.text = (progress * 100f).ToString("F0") + "%";

            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextScene()
    {
        SceneManager.LoadScene(1);
    }

}
